using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Xml;



namespace HospitalRegistration
{
    public partial class frmBilling : Form
    {
        //Declare Connection
        MySqlConnection connection;

        
        public frmBilling()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                //load the initial data
                //today's date is default data
                LoadData(this.datePckrFrom.Text, this.datePckrTo.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);

                //cursor return to default
                Cursor.Current = Cursors.Default;
            }
        }

        private void frmBilling_Load(object sender, EventArgs e)
        {   
            //red the connection string from xml file
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
            this.dgvPatientNames.SelectionMode = DataGridViewSelectionMode.FullRowSelect;


            LoadData(this.datePckrFrom.Text, this.datePckrTo.Text);
        }

        private void LoadData(string dateFrom, string dateTo)
        {
            //Show Current Data To Be Printed
            if (connection != null)
            {   
                //change to wait cursor
                Cursor.Current = Cursors.WaitCursor;

                connection.Open();
                string nameOfProcedure = "load_DataForBilling";
                MySqlCommand cmd = new MySqlCommand(nameOfProcedure, connection);
                cmd.CommandType = CommandType.StoredProcedure;

                //complete the parameters needed to insert
                cmd.Parameters.AddWithValue("dateFrom", dateFrom);
                cmd.Parameters["dateFrom"].Direction = ParameterDirection.Input;

                cmd.Parameters.AddWithValue("dateTo", dateTo);
                cmd.Parameters["dateTo"].Direction = ParameterDirection.Input;


                //load everything in data grid view
                this.dgvPatientNames.Rows.Clear();
                this.dgvDiagnosis.Rows.Clear();


                MySqlDataReader dr = cmd.ExecuteReader();

                int ctr = 0;
                while (dr.Read())
                {
                    //this.dgvPatientNames.Rows.Add(dr["pa_Id"].ToString(), dr["dia_ID"].ToString(), dr["pa_FirstName"].ToString(), dr["pa_LastName"].ToString(), dr["birth_date"].ToString());
                    this.dgvPatientNames.Rows.Add(dr["pa_Id"].ToString(), dr["pa_FirstName"].ToString(), dr["pa_LastName"].ToString(), dr["birth_date"].ToString());
                    ctr++;
                }

                lblPatientNamesResults.Text = "Yield " + ctr + " Results.";

                dr.Close();

                connection.Close();

                //deselect the first selection
                if (ctr > 0)
                    this.dgvPatientNames.Rows[0].Selected = false;

                //change to default cursor
                Cursor.Current = Cursors.Default;
            }//End Load Data 

        }


        //close the form
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Clear the Grid and Fields
        private void btnClear_Click(object sender, EventArgs e)
        {
            this.dgvPatientNames.Rows.Clear();
            this.dgvDiagnosis.Rows.Clear();

            txtFirstName.Text = "";
            txtLastName.Text = "";
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

            try
            {

                if (connection != null)
                {
                    Cursor.Current = Cursors.WaitCursor;

                    //validation here. Must not accept empty firstname and lastname
                    //-------------------------------
                    String v_firstname = "", v_lastname = "";

                    if ((txtFirstName.Text.Trim() == "") && (txtLastName.Text.Trim() == ""))
                    {
                        MessageBox.Show("First Or Last Name Must be filled", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    if ((txtFirstName.Text.Trim() != ""))
                        v_firstname = txtFirstName.Text.Trim();

                    if ((txtLastName.Text.Trim() != ""))
                        v_lastname = txtLastName.Text.Trim();

                    //end validation
                    //-------------------------------

                    connection.Open();
                    string nameOfProcedure = "search_Names_For_Billing";
                    MySqlCommand cmd = new MySqlCommand(nameOfProcedure, connection);
                    cmd.CommandType = CommandType.StoredProcedure;


                    //complete the parameters needed to insert
                    cmd.Parameters.AddWithValue("firstname", v_firstname);
                    cmd.Parameters["firstname"].Direction = ParameterDirection.Input;

                    cmd.Parameters.AddWithValue("lastname", v_lastname);
                    cmd.Parameters["lastname"].Direction = ParameterDirection.Input;


                    //if Logon as System Admmin

                    MySqlDataReader dr = cmd.ExecuteReader();

                    //Clear The Data In DataGridView controls
                    this.dgvPatientNames.Rows.Clear();
                    this.dgvDiagnosis.Rows.Clear();

                    int ctr = 0;
                    while (dr.Read())
                    {

                        //this.dgvPatientNames.Rows.Add(dr["pa_Id"].ToString(), dr["dia_ID"].ToString(), dr["pa_FirstName"].ToString(), dr["pa_LastName"].ToString(), dr["birth_date"].ToString());
                        this.dgvPatientNames.Rows.Add(dr["pa_Id"].ToString(), dr["pa_FirstName"].ToString(), dr["pa_LastName"].ToString(), dr["birth_date"].ToString());
                        ctr++;

                    }

                    dr.Close();

                    connection.Close();


                    //-----------------------------------------------

                    //deselect the first selection
                    if (ctr > 0)
                        this.dgvPatientNames.Rows[0].Selected = false;

                    //Show Results
                    this.lblPatientNamesResults.Text = "Results: " + ctr.ToString() + " record(s) found";


                    Cursor.Current = Cursors.Default;

                } //end button search

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);

                //cursor return to default
                Cursor.Current = Cursors.Default;
            }


        }

        private void dgvPatientNames_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                Cursor.Current = Cursors.WaitCursor;

                if (connection != null)
                {
                    connection.Open();

                    //set the query
                    string query = "SELECT D.dia_ID, D.dia_Title, D.dia_Subject, Concat(R.dr_FirstName , ' ' , R.dr_LastName) as 'Doctor FullName', D.dia_medication_ids, D.dia_medication_names , D.dia_medication_qty, D.dia_medication_price, D.dia_medication_subtotal, D.dia_medication_cost,  D.dia_consultation_fee, D.dia_cost, DATE_FORMAT(D.dia_date, '%Y/%m/%d') as 'diagnosed_date' ";
                    query += " FROM Diagnosis D INNER JOIN DoctorNurses R ";
                    query += " Where D.dia_dr_ID = R.dr_ID ";
                    query += " And D.Patient_pa_Id = @get_patient_id ";
                    //query += " And D.dia_date = @get_diagnosed_date ";
                    query += " order by D.dia_date desc";

                    //set the mySql command
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("get_patient_id", int.Parse(this.dgvPatientNames.Rows[e.RowIndex].Cells["patient_id"].Value.ToString()));
                    cmd.Parameters["get_patient_id"].Direction = ParameterDirection.Input;

                    //cmd.Parameters.AddWithValue("get_diagnosed_date", this.dgvPatientNames.Rows[e.RowIndex].Cells["date"].Value.ToString());
                    //cmd.Parameters["get_diagnosed_date"].Direction = ParameterDirection.Input;


                    //declare data reader
                    MySqlDataReader reader;

                    //execute query
                    reader = cmd.ExecuteReader();


                    //clear items
                    this.dgvDiagnosis.Rows.Clear();


                    //populate data
                    int ctr = 0;
                    while (reader.Read())
                    {
                        this.dgvDiagnosis.Rows.Add(reader["dia_ID"].ToString(), reader["dia_Title"].ToString(), reader["dia_Subject"].ToString(), reader["Doctor FullName"].ToString(), reader["dia_medication_ids"].ToString(), reader["dia_medication_names"].ToString(), reader["dia_medication_qty"].ToString(), reader["dia_medication_price"].ToString(), reader["dia_medication_subtotal"].ToString(), reader["dia_medication_cost"].ToString(), reader["dia_consultation_fee"].ToString(), reader["dia_cost"].ToString(), reader["diagnosed_date"].ToString());
                        ctr++;
                    }

                    //close connection
                    reader.Close();
                    connection.Close();

                    //deselect the first selection
                    if (ctr > 0)
                    { 
                        this.dgvDiagnosis.Rows[0].Selected = false;
                        this.lblDiagnosisResults.Text = "Results :" + ctr.ToString() + " found.";
                    }



                } //end if connection

                Cursor.Current = Cursors.Default;

            } //end if get row index
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
           
            //check if the user has made a selection
            if (dgvDiagnosis.SelectedRows.Count > 0)
            {   
                //wait to process
                Cursor.Current = Cursors.WaitCursor;

                try
                {
                    if (connection != null)
                    {
                        connection.Open();
                        string nameOfProcedure = "insert_into_Billing";
                        MySqlCommand cmd = new MySqlCommand(nameOfProcedure, connection);
                        cmd.CommandType = CommandType.StoredProcedure;

                        int dia_id = int.Parse(this.dgvDiagnosis.Rows[dgvDiagnosis.SelectedRows[0].Index].Cells["id"].Value.ToString());

                        //complete the parameters needed to insert
                        cmd.Parameters.AddWithValue("diagnosed_id", dia_id);
                        cmd.Parameters["diagnosed_id"].Direction = ParameterDirection.Input;

                        //Execute Command
                        cmd.ExecuteNonQuery();

                        //Close Connection
                        connection.Close();

                        //if no errors print the data

                        frmBillingReport fbrep = new frmBillingReport(dia_id);
                        fbrep.ShowDialog();

                    } //end if connection is null
              

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }

                //Return To Default
                Cursor.Current = Cursors.Default;

            } //end if data grid view is selected
            else
                MessageBox.Show("Please Make A Selection", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Stop);




        } //end print



    }
}
