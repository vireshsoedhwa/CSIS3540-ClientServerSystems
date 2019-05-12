using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using MySql.Data.MySqlClient;


namespace HospitalRegistration
{
    public partial class frmLogin : Form
    {
        //MySQL Parameters
        MySqlConnection connection;

        //Set Global Variables 
        //-----------------------------------
        //get the data and pass the value to Main Form
        private string userId;
        private string firstName;
        private string lastName;
        private string userType;

        public string v_userId
        {
            get { return userId; }
            set { userId = value; }

        }
        public string v_firstName
        {
            get { return firstName; }
            set { firstName = value; }

        }

        public string v_lastName
        {
            get { return lastName; }
            set { lastName = value; }

        }

        public string v_userType
        {
            get { return userType; }
            set { userType = value; }

        }

        //----------------------------------- End

        //Set Connection String
        string connectionString = "";

        //Variable To Check If User Access Is Disabled
        bool disabledAccess = false;


        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogon_Click(object sender, EventArgs e)
        {
            try
            {
                //wait to process
                Cursor.Current = Cursors.WaitCursor;

                //validation
                if (this.txtUserName.Text.Trim() == "" || this.txtPassword.Text.Trim() == "")
                {
                    MessageBox.Show("Username or Password Must Not Be Empty", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Stop);

                    //cursor return to default
                    Cursor.Current = Cursors.Default;

                    return;
                }



                //Connect to Server
                connection = new MySqlConnection(connectionString);


                if (connection != null)
                {
                    connection.Open();
                    string query = "SELECT dr_ID, dr_FirstName, dr_LastName, dr_UserAccountType,dr_DisableYN FROM DoctorNurses where Ucase(dr_Username)=Ucase(@username) and dr_password=@password";

                    MySqlCommand cmd = new MySqlCommand(query, connection);

                    //complete the parameters needed to Select
                    cmd.Parameters.AddWithValue("username", txtUserName.Text.Trim());
                    cmd.Parameters["username"].Direction = ParameterDirection.Input;

                    cmd.Parameters.AddWithValue("password", txtPassword.Text.Trim());
                    cmd.Parameters["password"].Direction = ParameterDirection.Input;

                    MySqlDataReader reader = cmd.ExecuteReader();



                    //check if successful logon or not
                    int ctr = 0;

                    //populate data and store in global variables
                    while (reader.Read())
                    {
                        //gvc.UserFullName(reader["dr_FirstName"].ToString(), reader["dr_LastName"].ToString(), reader["dr_UserAccountType"].ToString());
                        v_userId = reader["dr_ID"].ToString();
                        v_firstName = reader["dr_FirstName"].ToString();
                        v_lastName = reader["dr_LastName"].ToString();
                        v_userType = reader["dr_UserAccountType"].ToString();
                        disabledAccess = bool.Parse(reader["dr_DisableYN"].ToString());
                        ctr++;
                    }

                    //close all connections
                    reader.Close();
                    connection.Close();

                    // if not successful
                    if (ctr == 0)
                        MessageBox.Show("Username or Password Is Incorrect", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    else if (disabledAccess == true)
                        MessageBox.Show("Your Account Has Disabled", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    else
                        this.Close();


                }

                //cursor return to default
                Cursor.Current = Cursors.Default;
            }
            
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
               
                //cursor return to default
                Cursor.Current = Cursors.Default;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            //this.Close();
            Application.Exit();
        }

        private void frmLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            //if (gvc.firstName == "" || gvc.firstName == null)
            if (v_firstName == "")
                  Application.Exit();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            //Read Server Parameters
            XmlTextReader readerServerParams = new XmlTextReader("data.xml");

            string[] names = { "server", "database", "uid", "password" };
            string[] values = new string[3];
            for (int i = 0; i < names.Length; i++)
            {
                readerServerParams.ReadToFollowing(names[i]);
                readerServerParams.Read();
                connectionString += names[i] + "=" + readerServerParams.Value + ";";
            }

            readerServerParams.Close();
            //End Read Params
        }

        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Return))
            {
                btnLogon.PerformClick();
            }
           
        }
    }
}
