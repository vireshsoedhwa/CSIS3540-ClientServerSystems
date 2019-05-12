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
    public partial class frmDoctorNurses : Form
    {
        MySqlConnection connection;
        
        //get the account id
        int accountID;

        //Get the data grid view row index
        int dataGridRowIndex;

        //Show if Account is Disabled or Enabled
        string disableAccountYN;

        //Three important variables
        String v_firstname, v_lastname, v_department;

        //Variables To Check if The user has access rights
        string userId, userType;

        public frmDoctorNurses(string p_id, string p_userType)
        {
            InitializeComponent();

            //assign id and user type
            userId = p_id;
            userType = p_userType;

        }

        private void frmDoctorNurses_Load(object sender, EventArgs e)
        {
            try
            {
                XmlTextReader reader = new XmlTextReader("data.xml");
                string connectionString = "";
                string[] names = { "server", "database", "uid", "password" };
                string[] values = new string[3];
                for (int i = 0; i < names.Length; i++)
                {
                    reader.ReadToFollowing(names[i]);
                    reader.Read();
                    connectionString += names[i] + "=" + reader.Value + ";";
                }

                reader.Close();

                //Connect to Server
                connection = new MySqlConnection(connectionString);

                //Disable Resizing of the form
                this.FormBorderStyle = FormBorderStyle.FixedSingle;

                //set DatagridView Properties
                dgvDoctorsNurses.SelectionMode = DataGridViewSelectionMode.FullRowSelect;


                // LoadData();



                //if Login as System Administrator
                if (userType == "System Admin")
                {
                    groupBoxSystemAdmin.Visible = true;
                    dgvDoctorsNurses.Visible = true;
                    btnAdd.Visible = true;
                    lblAccessRights.Visible = false;
                    //load all data
                    LoadData();

                    //  addButtons(true);
                }
                else //login as a doctor or nurse
                {
                    groupBoxSystemAdmin.Visible = false;
                    dgvDoctorsNurses.Visible = false;
                    btnAdd.Visible = false;
                    lblAccessRights.Visible = true;

                    btnSearch.Enabled = false;
                    btnAdd.Enabled = false;
                    btnReset.Enabled = false;


                    //load user's information
                    UsersData(int.Parse(userId.ToString()));

                }
            } //end try
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);

                //cursor return to default
                Cursor.Current = Cursors.Default;
            }

        }

        private void frmDoctorNurses_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (connection != null)
                connection.Close();

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {

                if (connection != null)
                {
                    //validation here
                    //-------------------------------
                    if ((txtFirstname.Text.Trim() == "") || (txtLastname.Text.Trim() == "") || (this.txtDepartment.Text.Trim() == "") || (this.txtLicenseNo.Text.Trim() == "") || (this.txtMobileNo.Text.Trim() == "") || (this.txtOfficeNo.Text.Trim() == "") || (this.txtUsername.Text.Trim() == ""))
                    {
                        MessageBox.Show("All fields must be filled","Information", MessageBoxButtons.OK,MessageBoxIcon.Information);
                        return;
                    }

                    //if password and password confirm are the same
                    int cmpValue = 0;
                    cmpValue = String.Compare(txtPassword.Text.Trim(), txtPasswordConfirm.Text.Trim(), false);

                    if (cmpValue != 0)
                    {
                        MessageBox.Show("Password Must Be The Same", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }

                    //if gender : male or female is checked
                    String gender;

                    if (!rdoFemale.Checked && !rdoMale.Checked)
                    {
                        MessageBox.Show("Check if male or female", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                    else if (!rdoFemale.Checked && rdoMale.Checked)
                        gender = "Male";
                    else
                        gender = "Female";


                    //if account needs to be disabled
                    int disableAccount;
                    string disableAccountYN;
                    if (!this.rdoYes.Checked && !this.rdoNo.Checked)
                    {
                        MessageBox.Show("Check if the account needs to be enabled or disabled", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                    else if (!this.rdoYes.Checked && this.rdoNo.Checked)
                    {
                        disableAccount = 0;
                        disableAccountYN = "No";
                    }
                    else
                    {
                        disableAccount = 1;
                        disableAccountYN = "Yes";
                    }

                    //if account type has selected
                    if ((cboAccountType.Text.Trim() == ""))
                    {
                        MessageBox.Show("Check if 'User Account Type' is selected", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }

                    //if title of doctor has supplied.
                    if (cboTitle.Text.Trim() == "")
                    {
                        MessageBox.Show("Check if 'Title' is selected", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }

                    //check if users already exists
                    bool userExists = checkExistingUserName(0);
                    if (userExists)
                    {
                        MessageBox.Show("User Name Is Already Taken", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }

                    //end validation
                    //-------------------------------

                    connection.Open();
                    string nameOfProcedure = "add_DoctorNurses";
                    MySqlCommand cmd = new MySqlCommand(nameOfProcedure, connection);
                    cmd.CommandType = CommandType.StoredProcedure;

                    v_firstname = UppercaseFirst(txtFirstname.Text.Trim());
                    v_lastname = UppercaseFirst(this.txtLastname.Text.Trim());
                    v_department = UppercaseFirst(txtDepartment.Text.Trim());

                    //complete the parameters needed to insert
                    cmd.Parameters.AddWithValue("firstname", v_firstname);
                    cmd.Parameters["firstname"].Direction = ParameterDirection.Input;

                    cmd.Parameters.AddWithValue("lastname", v_lastname);
                    cmd.Parameters["lastname"].Direction = ParameterDirection.Input;

                    cmd.Parameters.AddWithValue("gender", gender);
                    cmd.Parameters["gender"].Direction = ParameterDirection.Input;

                    cmd.Parameters.AddWithValue("licenseNumber", txtLicenseNo.Text.Trim());
                    cmd.Parameters["licenseNumber"].Direction = ParameterDirection.Input;

                    cmd.Parameters.AddWithValue("department", v_department);
                    cmd.Parameters["department"].Direction = ParameterDirection.Input;

                    cmd.Parameters.AddWithValue("title", this.cboTitle.Text.Trim());
                    cmd.Parameters["title"].Direction = ParameterDirection.Input;

                    cmd.Parameters.AddWithValue("officeNumber", txtOfficeNo.Text.Trim());
                    cmd.Parameters["officeNumber"].Direction = ParameterDirection.Input;

                    cmd.Parameters.AddWithValue("mobileNumber", txtMobileNo.Text.Trim());
                    cmd.Parameters["mobileNumber"].Direction = ParameterDirection.Input;

                    cmd.Parameters.AddWithValue("userAccountType", cboAccountType.Text.Trim());
                    cmd.Parameters["userAccountType"].Direction = ParameterDirection.Input;

                    cmd.Parameters.AddWithValue("username", this.txtUsername.Text.Trim());
                    cmd.Parameters["username"].Direction = ParameterDirection.Input;

                    cmd.Parameters.AddWithValue("userpassword", this.txtPassword.Text.Trim());
                    cmd.Parameters["userpassword"].Direction = ParameterDirection.Input;

                    cmd.Parameters.AddWithValue("disableYN", disableAccount);
                    cmd.Parameters["disableYN"].Direction = ParameterDirection.Input;

                    //output the ID
                    MySqlParameter retId = new MySqlParameter("returnId", MySqlDbType.Int16);
                    retId.Direction = ParameterDirection.Output;
                    cmd.Parameters.Add(retId);



                    //if Logon as System Admmin


                    cmd.ExecuteNonQuery();


                    connection.Close();

                    accountID = int.Parse(cmd.Parameters["returnId"].Value.ToString());
                    if (accountID > 0)
                    {

                        this.dgvDoctorsNurses.Rows.Add(accountID, v_firstname, v_lastname, v_department, disableAccountYN, gender, txtLicenseNo.Text.Trim(), this.cboTitle.Text.Trim(), txtOfficeNo.Text.Trim(), txtMobileNo.Text, cboAccountType.Text.Trim(), txtUsername.Text.Trim(), txtPassword.Text.Trim());
                        lblNote.Text = "Note: Record Inserted";
                        ClearFields();
                    }
                    else
                        MessageBox.Show("An Error Occurred");



                } //end if
            } //end try
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);

                //cursor return to default
                Cursor.Current = Cursors.Default;
            }

        }

        //Method to User's Data For Update
        private void UsersData(int p_userid)
        {
            

            if (connection != null)
            {


                connection.Open();
                string query = "select * from DoctorNurses where dr_ID=" + p_userid;
                MySqlCommand cmd = new MySqlCommand(query, connection);
               
                MySqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    accountID = int.Parse(dr["dr_ID"].ToString());
                    txtFirstname.Text = dr["dr_FirstName"].ToString();
                    txtLastname.Text = dr["dr_LastName"].ToString();
                    txtDepartment.Text = dr["dr_Department"].ToString();

                    if (dr["dr_Gender"].ToString() == "Female")
                    {
                        rdoFemale.Checked = true;
                        rdoMale.Checked = false;
                    }
                    else
                    {
                        rdoFemale.Checked = false;
                        rdoMale.Checked = true;
                    }

                    txtLicenseNo.Text = dr["dr_LicenseNumber"].ToString();
                    cboTitle.Text = dr["dr_Title"].ToString();
                    txtOfficeNo.Text = dr["dr_OfficeNumber"].ToString();
                    txtMobileNo.Text = dr["dr_MobileNumber"].ToString();
                    this.cboAccountType.Text = dr["dr_UserAccountType"].ToString();
                    txtUsername.Text = dr["dr_Username"].ToString();
                    txtPassword.Text = dr["dr_Password"].ToString();
                    txtPasswordConfirm.Text = dr["dr_Password"].ToString();

                    //if (int.Parse(dr["dr_DisableYN"].ToString()) == 0)
                    if (dr.GetInt16(12) == 0)
                    {
                        rdoNo.Checked = true;
                        rdoYes.Checked = false;
                    }
                    else
                    {
                        rdoNo.Checked = false;
                        rdoYes.Checked = true;
                    }


                }

                dr.Close();

                connection.Close();

            }//End users Data 

        }


        //Method to Load Data
        private void LoadData()
        {   
            //Show Current Data
            dgvDoctorsNurses.Visible = true;

            if (connection != null)
            {


                connection.Open();
                string nameOfProcedure = "load_data_doctorsAndNurses";
                MySqlCommand cmd = new MySqlCommand(nameOfProcedure, connection);
                cmd.CommandType = CommandType.StoredProcedure;


                //load everything in data grid view
                dgvDoctorsNurses.Rows.Clear();
               


                MySqlDataReader dr = cmd.ExecuteReader();
                
                while (dr.Read())
                {
                    
                    if (dr["dr_DisableYN"].ToString().CompareTo("True")==0)
                        disableAccountYN = "Yes";
                    else
                        disableAccountYN = "No";

                    this.dgvDoctorsNurses.Rows.Add(dr["dr_ID"].ToString(), dr["dr_FirstName"].ToString(), dr["dr_LastName"].ToString(), dr["dr_Department"].ToString(), disableAccountYN, dr["dr_Gender"].ToString(), dr["dr_LicenseNumber"].ToString(), dr["dr_Title"].ToString(), dr["dr_OfficeNumber"].ToString(), dr["dr_MobileNumber"].ToString(), dr["dr_UserAccountType"].ToString(), dr["dr_Username"].ToString(), dr["dr_Password"].ToString());
                  
                   
                   
                }

                dr.Close();

                connection.Close();

                

                this.dgvDoctorsNurses.Rows[0].Selected = false;

            }//End Load Data 

        }

        private string UppercaseFirst(string s)
        {
            // Return first char Uppercase and concat the rest.
            return char.ToUpper(s[0]) + s.Substring(1);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvDoctorsNurses_CellClick(object sender, DataGridViewCellEventArgs e)
        {   
            //load data from data grid to fields
            if (e.RowIndex >= 0)
            {
                



                dataGridRowIndex = e.RowIndex;

                dgvDoctorsNurses.Rows[e.RowIndex].ReadOnly = true;

                accountID = int.Parse(dgvDoctorsNurses.Rows[e.RowIndex].Cells["ID"].Value.ToString());

                //validate if the user has the right access.Otherwise wont allow to view details
               // if (accountID != int.Parse(userId.ToString()))
               // {
               //     if (userType != "System Admin")
               //     {
               //         MessageBox.Show("You Do Not The Permission To View", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
               //         return;
               //     }
               // }

                txtFirstname.Text = dgvDoctorsNurses.Rows[e.RowIndex].Cells["firstname"].Value.ToString().Trim();
                txtLastname.Text = dgvDoctorsNurses.Rows[e.RowIndex].Cells["lastname"].Value.ToString().Trim();
                txtDepartment.Text = dgvDoctorsNurses.Rows[e.RowIndex].Cells["department"].Value.ToString().Trim();

                if (dgvDoctorsNurses.Rows[e.RowIndex].Cells["gender"].Value.ToString().Trim() == "Female")
                {
                    rdoFemale.Checked = true;
                    rdoMale.Checked = false;
                }
                else
                {
                    rdoFemale.Checked = false;
                    rdoMale.Checked = true;
                }

                txtLicenseNo.Text = dgvDoctorsNurses.Rows[e.RowIndex].Cells["licenseNumber"].Value.ToString().Trim();
                cboTitle.Text = dgvDoctorsNurses.Rows[e.RowIndex].Cells["title"].Value.ToString().Trim();
                txtOfficeNo.Text = dgvDoctorsNurses.Rows[e.RowIndex].Cells["officeNumber"].Value.ToString().Trim();
                txtMobileNo.Text = dgvDoctorsNurses.Rows[e.RowIndex].Cells["mobileNumber"].Value.ToString().Trim();
                this.cboAccountType.Text = dgvDoctorsNurses.Rows[e.RowIndex].Cells["userAccountType"].Value.ToString().Trim();
                txtUsername.Text = dgvDoctorsNurses.Rows[e.RowIndex].Cells["username"].Value.ToString().Trim();
                txtPassword.Text = dgvDoctorsNurses.Rows[e.RowIndex].Cells["password"].Value.ToString().Trim();
                txtPasswordConfirm.Text = txtPassword.Text;

                if (dgvDoctorsNurses.Rows[e.RowIndex].Cells["disable"].Value.ToString().Trim() == "No")
                {
                    rdoNo.Checked = true;
                    rdoYes.Checked = false;
                }
                else
                {
                    rdoNo.Checked = false;
                    rdoYes.Checked = true;
                }

                
                //Call enable/disable Buttons;
                editButtons(true);

            }
        }



        private void btnEdit_Click(object sender, EventArgs e)
        {
           

            if (accountID.ToString().Length == 0 || accountID==0)
            {
                MessageBox.Show("Maybe You Need To Add The Data First", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (connection != null)
            {
                //validation here
                //-------------------------------
                if ((txtFirstname.Text.Trim() == "") || (txtLastname.Text.Trim() == "") || (this.txtDepartment.Text.Trim() == "") || (this.txtLicenseNo.Text.Trim() == "") || (this.txtMobileNo.Text.Trim() == "") || (this.txtOfficeNo.Text.Trim() == "") || (this.txtUsername.Text.Trim() == ""))
                {
                    MessageBox.Show("All fields must be filled", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                //if password and password confirm are the same
                int cmpValue = 0;
                cmpValue = String.Compare(txtPassword.Text.Trim(), txtPasswordConfirm.Text.Trim(), false);

                if (cmpValue != 0)
                {
                    MessageBox.Show("Password Must Be The Same");
                    return;
                }

                //if gender : male or female is checked
                String gender;

                if (!rdoFemale.Checked && !rdoMale.Checked)
                {
                    MessageBox.Show("Check if male or female");
                    return;
                }
                else if (!rdoFemale.Checked && rdoMale.Checked)
                    gender = "Male";
                else
                    gender = "Female";


                //if account needs to be disabled
                int disableAccount;
                string disableAccountYN;
                if (!this.rdoYes.Checked && !this.rdoNo.Checked)
                {
                    MessageBox.Show("Check if the account needs to be enabled or disabled");
                    return;
                }
                else if (!this.rdoYes.Checked && this.rdoNo.Checked)
                {
                    disableAccount = 0;
                    disableAccountYN = "No";
                }
                else
                {
                    disableAccount = 1;
                    disableAccountYN = "Yes";
                }

                //if account type has selected
                if ((cboAccountType.Text.Trim() == ""))
                {
                    MessageBox.Show("Check if 'User Account Type' is selected");
                    return;
                }

                //if title of doctor has supplied.
                if (cboTitle.Text.Trim() == "")
                {
                    MessageBox.Show("Check if 'Title' is selected");
                    return;
                }

                //check if users already exists
                bool userExists = checkExistingUserName(int.Parse(userId.ToString()));
                if (userExists)
                {
                    MessageBox.Show("User Name Is Not Allowed", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                //end validation
                //-------------------------------
                try
                {
                    connection.Open();
                    string nameOfProcedure = "edit_DoctorNurses";
                    MySqlCommand cmd = new MySqlCommand(nameOfProcedure, connection);
                    cmd.CommandType = CommandType.StoredProcedure;

                
                    v_firstname= UppercaseFirst(txtFirstname.Text.Trim());
                    v_lastname = UppercaseFirst(this.txtLastname.Text.Trim());
                    v_department=UppercaseFirst(txtDepartment.Text.Trim());

                    //complete the parameters needed to insert
                    cmd.Parameters.AddWithValue("firstname", v_firstname);
                    cmd.Parameters["firstname"].Direction = ParameterDirection.Input;

                    cmd.Parameters.AddWithValue("lastname", v_lastname);
                    cmd.Parameters["lastname"].Direction = ParameterDirection.Input;

                    cmd.Parameters.AddWithValue("gender", gender);
                    cmd.Parameters["gender"].Direction = ParameterDirection.Input;

                    cmd.Parameters.AddWithValue("licenseNumber", txtLicenseNo.Text.Trim());
                    cmd.Parameters["licenseNumber"].Direction = ParameterDirection.Input;

                    cmd.Parameters.AddWithValue("department", v_department);
                    cmd.Parameters["department"].Direction = ParameterDirection.Input;

                    cmd.Parameters.AddWithValue("title", this.cboTitle.Text.Trim());
                    cmd.Parameters["title"].Direction = ParameterDirection.Input;

                    cmd.Parameters.AddWithValue("officeNumber", txtOfficeNo.Text.Trim());
                    cmd.Parameters["officeNumber"].Direction = ParameterDirection.Input;

                    cmd.Parameters.AddWithValue("mobileNumber", txtMobileNo.Text.Trim());
                    cmd.Parameters["mobileNumber"].Direction = ParameterDirection.Input;

                    cmd.Parameters.AddWithValue("userAccountType", cboAccountType.Text.Trim());
                    cmd.Parameters["userAccountType"].Direction = ParameterDirection.Input;

                    cmd.Parameters.AddWithValue("username", this.txtUsername.Text.Trim());
                    cmd.Parameters["username"].Direction = ParameterDirection.Input;

                    cmd.Parameters.AddWithValue("userpassword", this.txtPassword.Text.Trim());
                    cmd.Parameters["userpassword"].Direction = ParameterDirection.Input;

                    cmd.Parameters.AddWithValue("disableYN", disableAccount);
                    cmd.Parameters["disableYN"].Direction = ParameterDirection.Input;

                    //get the ID
                    cmd.Parameters.AddWithValue("id", accountID);
                    cmd.Parameters["id"].Direction = ParameterDirection.Input;




                    //if Logon as System Admmin

               
                    cmd.ExecuteNonQuery();
                    connection.Close();


                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.ToString());
                    connection.Close();
                    return;
                }

                //if successful update, update the data grid view
                //-----------------------------------------------
                if (userType == "System Admin")
                {
                    DataGridViewRow row = this.dgvDoctorsNurses.Rows[dataGridRowIndex];

                    row.Cells[1].Value = v_firstname;
                    row.Cells[2].Value = v_lastname;
                    row.Cells[3].Value = v_department;
                    row.Cells[4].Value = disableAccountYN;
                    row.Cells[5].Value = gender;
                    row.Cells[6].Value = txtLicenseNo.Text.Trim();
                    row.Cells[7].Value = this.cboTitle.Text.Trim();
                    row.Cells[8].Value = txtOfficeNo.Text.Trim();
                    row.Cells[6].Value = txtMobileNo.Text.Trim();
                    row.Cells[7].Value = this.cboAccountType.Text.Trim();
                    row.Cells[8].Value = txtUsername.Text.Trim();
                    row.Cells[9].Value = txtPassword.Text.Trim();
                    row.Cells[10].Value = txtPasswordConfirm.Text.Trim();
                    //end update cells
                    //-----------------------------------------------

                    //if successfull edit
                    ClearFields();

                    //Call enable/disable Buttons;
                    addButtons(true);

                    //load new data
                    LoadData();

                }
                lblNote.Text = "Note: Update Completed..";


               

            } //end if
           

        }


        //clear
        private void ClearFields()
        {
            txtFirstname.Text = "";
            txtLastname.Text = "";
            txtDepartment.Text = "";
            txtLicenseNo.Text = "";
            txtMobileNo.Text = "";
            txtOfficeNo.Text = "";
            txtPassword.Text = "";
            txtPasswordConfirm.Text = "";
            txtUsername.Text = "";
            
            cboAccountType.Text = "";
            cboTitle.Text = "";

            rdoFemale.Checked = false;
            rdoMale.Checked = false;
            rdoYes.Checked = false;
            rdoNo.Checked = false;

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {

                if (connection != null)
                {
                    //validation here. Must not accept empty firstname and lastname
                    //-------------------------------
                    String v_firstname = null, v_lastname = null;

                    if ((txtFirstname.Text.Trim() == "") && (txtLastname.Text.Trim() == ""))
                    {
                        MessageBox.Show("First Or Last Name Must be filled");
                        return;
                    }

                    if ((txtFirstname.Text.Trim() != ""))
                        v_firstname = txtFirstname.Text.Trim();

                    if ((txtLastname.Text.Trim() != ""))
                        v_lastname = txtLastname.Text.Trim();

                    //end validation
                    //-------------------------------

                    connection.Open();
                    string nameOfProcedure = "searchDoctors";
                    MySqlCommand cmd = new MySqlCommand(nameOfProcedure, connection);
                    cmd.CommandType = CommandType.StoredProcedure;


                    //complete the parameters needed to insert
                    cmd.Parameters.AddWithValue("firstname", v_firstname);
                    cmd.Parameters["firstname"].Direction = ParameterDirection.Input;

                    cmd.Parameters.AddWithValue("lastname", v_lastname);
                    cmd.Parameters["lastname"].Direction = ParameterDirection.Input;


                    //if Logon as System Admmin

                    MySqlDataReader dr = cmd.ExecuteReader();



                    this.dgvDoctorsNurses.Rows.Clear();

                    int ctr = 0;
                    while (dr.Read())
                    {

                        if (dr["dr_DisableYN"].ToString().CompareTo("True") == 0)
                            disableAccountYN = "Yes";
                        else
                            disableAccountYN = "No";

                        //this.dgvSearchResults.Rows.Add(dr["dr_ID"].ToString(), dr["dr_FirstName"].ToString(), dr["dr_LastName"].ToString(), dr["dr_Department"].ToString(), disableAccountYN, dr["dr_Gender"].ToString(), dr["dr_LicenseNumber"].ToString(), dr["dr_Title"].ToString(), dr["dr_OfficeNumber"].ToString(), dr["dr_MobileNumber"].ToString(), dr["dr_UserAccountType"].ToString(), dr["dr_Username"].ToString(), dr["dr_Password"].ToString());
                        this.dgvDoctorsNurses.Rows.Add(dr["dr_ID"].ToString(), dr["dr_FirstName"].ToString(), dr["dr_LastName"].ToString(), dr["dr_Department"].ToString(), disableAccountYN, dr["dr_Gender"].ToString(), dr["dr_LicenseNumber"].ToString(), dr["dr_Title"].ToString(), dr["dr_OfficeNumber"].ToString(), dr["dr_MobileNumber"].ToString(), dr["dr_UserAccountType"].ToString(), dr["dr_Username"].ToString(), dr["dr_Password"].ToString());
                        ctr++;

                    }

                    dr.Close();

                    connection.Close();

                    //Show Results
                    //dgvSearchResults.Visible = true;
                    //dgvDoctorsNurses.Visible = false;

                    //-----------------------------------------------

                    //Show Results
                    lblNote.Text = "Note: " + ctr.ToString() + " record(s) found";

                    //select first result
                    if (ctr > 0)
                    {
                        dgvDoctorsNurses_CellClick(dgvDoctorsNurses, new DataGridViewCellEventArgs(0, 0));

                        //Call enable/disable Buttons;
                        editButtons(true);
                    }


                } //end if
            } //end try
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);

                //cursor return to default
                Cursor.Current = Cursors.Default;
            }
        }

        //Reset Fields and Data
        private void btnReset_Click(object sender, EventArgs e)
        {
            //Clear All the fields 
            ClearFields();

            //Call enable/disable Buttons
            addButtons(true);

            //Resets Note:
            lblNote.Text = "Note: ";

            //re-load data
            LoadData();


        }

        //disable/enable addbuttons
        //--------------------------
        private void addButtons(bool v_bool)
        {
            if (v_bool)
            {
                btnAdd.Enabled = true;
                btnEdit.Enabled = false;

            }
        }
        
        private void editButtons(bool v_bool)
        {
            if (v_bool)
            {
                btnAdd.Enabled = false;
                btnEdit.Enabled = true;

            }
        }

       
        //-------------------------- end disable/enable buttons


        private bool checkExistingUserName(int p_userID)
        {
            bool userExists = false;

            if (connection != null)
            {
                
                connection.Open();
                string query;
                MySqlCommand cmd; // = new MySqlCommand(query, connection);

                //if (userID == 0)
                //{
                //    query = "select dr_ID from DoctorNurses where Ucase(dr_Username)=Ucase(@username) and Ucase(dr_Password)=Ucase(@password) limit 0,1";
                //    cmd = new MySqlCommand(query, connection);
                //    cmd.Parameters.AddWithValue("username", username);
                //    cmd.Parameters["username"].Direction = ParameterDirection.Input;
               // }
               // else
               // {
                    query = "select dr_ID from DoctorNurses where Ucase(dr_Username)=Ucase(@username) and Ucase(dr_Password)=Ucase(@password) limit 0,1";

                    cmd = new MySqlCommand(query, connection);

                    cmd.Parameters.AddWithValue("username", txtUsername.Text.Trim());
                    cmd.Parameters["username"].Direction = ParameterDirection.Input;

                    cmd.Parameters.AddWithValue("password", this.txtPassword.Text.Trim());
                    cmd.Parameters["password"].Direction = ParameterDirection.Input;

              //  }
                
                



                MySqlDataReader dr = cmd.ExecuteReader();

                int ctr = 0;
                while (dr.Read())
                {

                    if (accountID != int.Parse(dr["dr_ID"].ToString()) || p_userID==0)
                         ctr++;
                }

                dr.Close();

                connection.Close();

                //select first result
                if (ctr > 0)
                    userExists = true;
            } //end if

            return userExists;
        }

        private void cboAccountType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboAccountType.Text == "Nurse")
                cboTitle.Text = "None";
        }
    }
}
