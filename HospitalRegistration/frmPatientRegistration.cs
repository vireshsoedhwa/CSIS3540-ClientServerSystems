using MySql.Data.MySqlClient;
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

namespace PatientRegistration
{
    public partial class frmPatientRegistration : Form
    {
        private MySqlConnection connection;
        string connectionString = "";

        public frmPatientRegistration()
        {
            InitializeComponent();
        }

        private void frmPatientRegistration_Load(object sender, EventArgs e)
        {

            bdPicker.Format = DateTimePickerFormat.Custom;
            bdPicker.CustomFormat = "yyyy/MM/dd";

            PatientdataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            
            XmlTextReader reader = new XmlTextReader("data.xml");
            //string connectionString = "";

            string[] names = { "server", "database", "uid", "password" };
            string[] values = new string[3];
            for (int i = 0; i < names.Length; i++)
            {
                reader.ReadToFollowing(names[i]);
                reader.Read();
                connectionString += names[i] + "=" + reader.Value + ";";
            }

            reader.Close();

            try
            {
                connection = new MySqlConnection(connectionString);
                lstResult.Items.Add("Connected");
            }
            catch (MySqlException ex)
            {
                //0: Cannot connect to server.
                //1045: Invalid user name and/or password.
                switch (ex.Number)
                {
                    case 0:
                        lstResult.Items.Add("Cannot connect to server.  Contact administrator");
                        break;

                    case 1045:
                        lstResult.Items.Add("Invalid username/password, please try again");
                        break;
                }
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            /*if (txtID.Text.Trim() != "")
            {
                if (connection != null)
                {
                    connection.Open();
                    string nameOfProcedure = "PatientLookup";
                    MySqlCommand cmd = new MySqlCommand(nameOfProcedure, connection);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@paID", txtID.Text);
                    cmd.Parameters["@paID"].Direction = ParameterDirection.Input;

                    try
                    {
                        MySqlDataReader reader = cmd.ExecuteReader();

                        while (reader.Read())
                        {
                            PatientdataGridView.Rows.Add(
                                reader["pa_Id"].ToString(),
                                reader["pa_FirstName"].ToString(),
                                reader["pa_LastName"].ToString(),
                                reader["pa_Gender"].ToString(),
                                ((DateTime)reader["pa_BirthDate"]).ToString("d"),
                                reader["pa_PhoneNumber"].ToString(),
                                reader["pa_Emergency_Contact"].ToString(),
                                reader["pa_Emergency_ContactNumber"].ToString(),
                                reader["pa_BloodType"].ToString(),
                                reader["pa_Address"].ToString(),
                                reader["pa_Email"].ToString(),
                                reader["pa_Ins_Number"].ToString(),
                                reader["pa_Ins_Company"].ToString(),
                                reader["pa_Nationality"].ToString(),
                                reader["pa_GovBenefits"].ToString(),
                                reader["pa_GovBenefitsID"].ToString(),
                                reader["pa_Status"].ToString()
                            );
                        }
                    }
                    catch (Exception ex)
                    {
                        //MessageBox.Show("Error with the data from database!");
                        MessageBox.Show(ex.Message);
                    }
                    connection.Close();
                }
            }else
            {
                MessageBox.Show("The ID must be entered!!!");
            }*/
            PatientdataGridView.DataSource = null;
            PatientdataGridView.Rows.Clear();
            string paid, pafname, palname;
            if (txtID.Text.Trim() == "")
            {
                paid = null;
            }
            else
            {
                paid = txtID.Text;
            }
            if (txtFName.Text.Trim() == "")
            {
                pafname = null;
            }
            else
            {
                pafname = txtFName.Text;
            }
            if (txtLName.Text.Trim() == "")
            {
                palname = null;
            }
            else
            {
                palname = txtLName.Text;
            }
            
            
            
           // if (txtID.Text.Trim() != "")
           // {
                if (connection != null)
                {
                    connection.Open();
                    string nameOfProcedure = "PatientLookup";
                    MySqlCommand cmd = new MySqlCommand(nameOfProcedure, connection);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@paID", paid);
                    cmd.Parameters["@paID"].Direction = ParameterDirection.Input;
                    cmd.Parameters.AddWithValue("@paFirstName", pafname);
                    cmd.Parameters["@paFirstName"].Direction = ParameterDirection.Input;
                    cmd.Parameters.AddWithValue("@paLastName", palname);
                    cmd.Parameters["@paLastName"].Direction = ParameterDirection.Input;

                    try
                    {
                        MySqlDataReader reader = cmd.ExecuteReader();
                        int ctr = 0;
                        while (reader.Read())
                        {
                            PatientdataGridView.Rows.Add(
                                reader["pa_Id"].ToString(),
                                reader["pa_FirstName"].ToString(),
                                reader["pa_LastName"].ToString(),
                                reader["pa_Gender"].ToString(),
                                ((DateTime)reader["pa_BirthDate"]).ToString("d"),
                                reader["pa_PhoneNumber"].ToString(),
                                reader["pa_Emergency_Contact"].ToString(),
                                reader["pa_Emergency_ContactNumber"].ToString(),
                                reader["pa_BloodType"].ToString(),
                                reader["pa_Address"].ToString(),
                                reader["pa_Email"].ToString(),
                                reader["pa_Ins_Number"].ToString(),
                                reader["pa_Ins_Company"].ToString(),
                                reader["pa_Nationality"].ToString(),
                                reader["pa_GovBenefits"].ToString(),
                                reader["pa_GovBenefitsID"].ToString(),
                                reader["pa_Status"].ToString()
                            );

                            ctr++;
                        }

                        lblStatus.Text = ctr + " records found..";
                    }
                    catch
                    {
                        MessageBox.Show("Error with the data from database!");
                        //MessageBox.Show(ex.Message);
                    }
                    connection.Close();
                }
           // }
           // else
           // {
           //     MessageBox.Show("The ID must be entered!!!");
           // }
        }

        private void PatientdataGridView_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int PatientselectedRowCount = PatientdataGridView.Rows.GetRowCount(DataGridViewElementStates.Selected);
            string gender = "";
            string governbenefits = "";
            string status = "";

            if (PatientselectedRowCount == 1)
            {
                try
                {
                    txtID.Text = PatientdataGridView.SelectedRows[0].Cells[0].Value.ToString();
                    txtFName.Text = PatientdataGridView.SelectedRows[0].Cells[1].Value.ToString();
                    txtLName.Text = PatientdataGridView.SelectedRows[0].Cells[2].Value.ToString();
                    gender = PatientdataGridView.SelectedRows[0].Cells[3].Value.ToString();
                    if (gender.Equals("M"))
                    {
                        rbtnMale.Checked = true;
                    }
                    else if (gender.Equals("F"))
                    {
                        rbtnFemale.Checked = true;
                    }
                    
                    bdPicker.Text = PatientdataGridView.SelectedRows[0].Cells[4].Value.ToString();
                    txtPhone.Text = PatientdataGridView.SelectedRows[0].Cells[5].Value.ToString();
                    txtEC.Text = PatientdataGridView.SelectedRows[0].Cells[6].Value.ToString();
                    txtECN.Text = PatientdataGridView.SelectedRows[0].Cells[7].Value.ToString();
                    txtBloodType.Text = PatientdataGridView.SelectedRows[0].Cells[8].Value.ToString();
                    txtAddress.Text = PatientdataGridView.SelectedRows[0].Cells[9].Value.ToString();
                    txtEmail.Text = PatientdataGridView.SelectedRows[0].Cells[10].Value.ToString();
                    txtInsNumber.Text = PatientdataGridView.SelectedRows[0].Cells[11].Value.ToString();
                    txtInsCompany.Text = PatientdataGridView.SelectedRows[0].Cells[12].Value.ToString();
                    txtNationality.Text = PatientdataGridView.SelectedRows[0].Cells[13].Value.ToString();
                    governbenefits = PatientdataGridView.SelectedRows[0].Cells[14].Value.ToString();
                    if (governbenefits.Equals("Yes"))
                    {
                        rbtnGBYes.Checked = true;
                    }
                    else if (governbenefits.Equals("No"))
                    {
                        rbtnGBNo.Checked = true;
                    }
                    txtGB_Id.Text = PatientdataGridView.SelectedRows[0].Cells[15].Value.ToString();
                    status = PatientdataGridView.SelectedRows[0].Cells[16].Value.ToString();
                    if (status.Equals("Active"))
                    {
                        rbtnActive.Checked = true;
                    }
                    else if (status.Equals("Inactive"))
                    {
                        rbtnInactive.Checked = true;
                    }
                }
                catch
                {
                    MessageBox.Show("Error with the data from the gridview!");
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            txtID.Text = "";

            if ((txtID.Text.Trim() != "") ||
                (txtFName.Text.Trim() != "") ||
                (txtLName.Text.Trim() != "") ||
                (rbtnMale.Checked != false) ||
                (rbtnFemale.Checked != false) ||
                (txtPhone.Text.Trim() != "") ||
                (txtEC.Text.Trim() != "") ||
                (txtECN.Text.Trim() != "") ||
                (txtBloodType.Text.Trim() != "") ||
                (txtAddress.Text.Trim() != "") ||
                (txtEmail.Text.Trim() != "") ||
                (txtInsNumber.Text.Trim() != "") ||
                (txtInsCompany.Text.Trim() != "") ||
                (txtNationality.Text.Trim() != "") ||
                (rbtnGBYes.Checked != false) ||
                (rbtnGBNo.Checked != false) ||
                (txtGB_Id.Text.Trim() != "") ||
                (rbtnActive.Checked != false) ||
                (rbtnInactive.Checked != false))
            {
                if (connection != null)
                {
                    connection.Open();
                    string nameOfProcedure = "addPatient";
                    MySqlCommand cmd = new MySqlCommand(nameOfProcedure, connection);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@firstname", txtFName.Text);
                    cmd.Parameters["@firstname"].Direction = ParameterDirection.Input;
                    cmd.Parameters.AddWithValue("@lastname", txtLName.Text);
                    cmd.Parameters["@lastname"].Direction = ParameterDirection.Input;
                    string gender = "";
                    if (rbtnMale.Checked == true)
                    {
                        gender = "M";
                    }
                    else if (rbtnFemale.Checked == true)
                    {
                        gender = "F";
                    }
                    cmd.Parameters.AddWithValue("@gender", gender);
                    cmd.Parameters["@gender"].Direction = ParameterDirection.Input;
                    DateTime dt = new DateTime(int.Parse(bdPicker.Value.Year.ToString()), int.Parse(bdPicker.Value.Month.ToString()), int.Parse(bdPicker.Value.Day.ToString()));
                    cmd.Parameters.AddWithValue("@birthdate", dt);
                    cmd.Parameters["@birthdate"].Direction = ParameterDirection.Input;
                    cmd.Parameters.AddWithValue("@phone", txtPhone.Text);
                    cmd.Parameters["@phone"].Direction = ParameterDirection.Input;
                    cmd.Parameters.AddWithValue("@emerCon", txtEC.Text);
                    cmd.Parameters["@emerCon"].Direction = ParameterDirection.Input;
                    cmd.Parameters.AddWithValue("@emerConN", txtECN.Text);
                    cmd.Parameters["@emerConN"].Direction = ParameterDirection.Input;
                    cmd.Parameters.AddWithValue("@bloodtype", txtBloodType.Text);
                    cmd.Parameters["@bloodtype"].Direction = ParameterDirection.Input;
                    cmd.Parameters.AddWithValue("@address", txtAddress.Text);
                    cmd.Parameters["@address"].Direction = ParameterDirection.Input;
                    cmd.Parameters.AddWithValue("@email", txtEmail.Text);
                    cmd.Parameters["@email"].Direction = ParameterDirection.Input;
                    cmd.Parameters.AddWithValue("@insNum", txtInsNumber.Text);
                    cmd.Parameters["@insNum"].Direction = ParameterDirection.Input;
                    cmd.Parameters.AddWithValue("@insComp", txtInsCompany.Text);
                    cmd.Parameters["@insComp"].Direction = ParameterDirection.Input;
                    cmd.Parameters.AddWithValue("@nationality", txtNationality.Text);
                    cmd.Parameters["@nationality"].Direction = ParameterDirection.Input;
                    string govBenefits = "";
                    if (rbtnGBYes.Checked == true)
                    {
                        govBenefits = "Yes";
                    }
                    else if (rbtnGBNo.Checked == true)
                    {
                        govBenefits = "No";
                    }
                    cmd.Parameters.AddWithValue("@govBenefits", govBenefits);
                    cmd.Parameters["@govBenefits"].Direction = ParameterDirection.Input;
                    cmd.Parameters.AddWithValue("@govBenefitsID", txtGB_Id.Text);
                    cmd.Parameters["@govBenefitsID"].Direction = ParameterDirection.Input;
                    string paStatus = "";
                    if (rbtnActive.Checked == true)
                    {
                        paStatus = "Active";
                    }
                    else if (rbtnInactive.Checked == true)
                    {
                        paStatus = "Inactive";
                    }
                    cmd.Parameters.AddWithValue("@paStatus", paStatus);
                    cmd.Parameters["@paStatus"].Direction = ParameterDirection.Input;
                    try
                    {
                        cmd.ExecuteNonQuery();
                        lstResult.Items.Add("New record added successfully!");
                        lblStatus.Text = "New record added successfully!";
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error while adding new record!: " + ex);
                        //MessageBox.Show(ex.Message);
                    }
                    connection.Close();
                }
            }else
            {
                MessageBox.Show("All fields must be entered!");
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtID.Text.Trim() != "")
            {
                if (connection != null)
                {
                    connection.Open();
                    string nameOfProcedure = "updatePatient";
                    MySqlCommand cmd = new MySqlCommand(nameOfProcedure, connection);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@paID", txtID.Text);
                    cmd.Parameters["@paID"].Direction = ParameterDirection.Input;
                    cmd.Parameters.AddWithValue("@firstname", txtFName.Text);
                    cmd.Parameters["@firstname"].Direction = ParameterDirection.Input;
                    cmd.Parameters.AddWithValue("@lastname", txtLName.Text);
                    cmd.Parameters["@lastname"].Direction = ParameterDirection.Input;
                    string gender = "";
                    if (rbtnMale.Checked == true)
                    {
                        gender = "M";
                    }
                    else if (rbtnFemale.Checked == true)
                    {
                        gender = "F";
                    }
                    cmd.Parameters.AddWithValue("@gender", gender);
                    cmd.Parameters["@gender"].Direction = ParameterDirection.Input;
                    DateTime dt = new DateTime(int.Parse(bdPicker.Value.Year.ToString()), int.Parse(bdPicker.Value.Month.ToString()), int.Parse(bdPicker.Value.Day.ToString()));
                    cmd.Parameters.AddWithValue("@birthdate", dt);
                    cmd.Parameters["@birthdate"].Direction = ParameterDirection.Input;
                    cmd.Parameters.AddWithValue("@phone", txtPhone.Text);
                    cmd.Parameters["@phone"].Direction = ParameterDirection.Input;
                    cmd.Parameters.AddWithValue("@emerCon", txtEC.Text);
                    cmd.Parameters["@emerCon"].Direction = ParameterDirection.Input;
                    cmd.Parameters.AddWithValue("@emerConN", txtECN.Text);
                    cmd.Parameters["@emerConN"].Direction = ParameterDirection.Input;
                    cmd.Parameters.AddWithValue("@bloodtype", txtBloodType.Text);
                    cmd.Parameters["@bloodtype"].Direction = ParameterDirection.Input;
                    cmd.Parameters.AddWithValue("@address", txtAddress.Text);
                    cmd.Parameters["@address"].Direction = ParameterDirection.Input;
                    cmd.Parameters.AddWithValue("@email", txtEmail.Text);
                    cmd.Parameters["@email"].Direction = ParameterDirection.Input;
                    cmd.Parameters.AddWithValue("@insNum", txtInsNumber.Text);
                    cmd.Parameters["@insNum"].Direction = ParameterDirection.Input;
                    cmd.Parameters.AddWithValue("@insComp", txtInsCompany.Text);
                    cmd.Parameters["@insComp"].Direction = ParameterDirection.Input;
                    cmd.Parameters.AddWithValue("@nationality", txtNationality.Text);
                    cmd.Parameters["@nationality"].Direction = ParameterDirection.Input;
                    string govBenefits = "";
                    if (rbtnGBYes.Checked == true)
                    {
                        govBenefits = "Yes";
                    }
                    else if (rbtnGBNo.Checked == true)
                    {
                        govBenefits = "No";
                    }
                    cmd.Parameters.AddWithValue("@govBenefits", govBenefits);
                    cmd.Parameters["@govBenefits"].Direction = ParameterDirection.Input;
                    cmd.Parameters.AddWithValue("@govBenefitsID", txtGB_Id.Text);
                    cmd.Parameters["@govBenefitsID"].Direction = ParameterDirection.Input;
                    string paStatus = "";
                    if (rbtnActive.Checked == true)
                    {
                        paStatus = "Active";
                    }
                    else if (rbtnInactive.Checked == true)
                    {
                        paStatus = "Inactive";
                    }
                    cmd.Parameters.AddWithValue("@paStatus", paStatus);
                    cmd.Parameters["@paStatus"].Direction = ParameterDirection.Input;
                    try
                    {
                        cmd.ExecuteNonQuery();
                        //lstResult.Items.Add("Record updated successfully!");
                        lblStatus.Text = "Record updated successfully!";



                        //if successful update
                        try
                        {
                            int PatientselectedRowCount = PatientdataGridView.Rows.GetRowCount(DataGridViewElementStates.Selected);
                            DataGridViewRow row = this.PatientdataGridView.Rows[PatientselectedRowCount];
                            PatientdataGridView.SelectedRows[0].Cells[1].Value = txtFName.Text;
                            PatientdataGridView.SelectedRows[0].Cells[2].Value = txtLName.Text;
                            if (rbtnMale.Checked == true)
                            {
                                PatientdataGridView.SelectedRows[0].Cells[3].Value = "Male";
                            }
                            else if (rbtnFemale.Checked == true)
                            {
                                PatientdataGridView.SelectedRows[0].Cells[3].Value = "Female";
                            }
                            PatientdataGridView.SelectedRows[0].Cells[4].Value = bdPicker.Text;
                            PatientdataGridView.SelectedRows[0].Cells[5].Value = txtPhone.Text;
                            PatientdataGridView.SelectedRows[0].Cells[6].Value = txtEC.Text;
                            PatientdataGridView.SelectedRows[0].Cells[7].Value = txtECN.Text;
                            PatientdataGridView.SelectedRows[0].Cells[8].Value = txtBloodType.Text;
                            PatientdataGridView.SelectedRows[0].Cells[9].Value = txtAddress.Text;
                            PatientdataGridView.SelectedRows[0].Cells[10].Value = txtEmail.Text;
                            PatientdataGridView.SelectedRows[0].Cells[11].Value = txtInsNumber.Text;
                            PatientdataGridView.SelectedRows[0].Cells[12].Value = txtInsCompany.Text;
                            PatientdataGridView.SelectedRows[0].Cells[13].Value = txtNationality.Text;
                            if (rbtnGBYes.Checked == true)
                            {

                                PatientdataGridView.SelectedRows[0].Cells[14].Value = "Yes";
                            }
                            else if (rbtnGBNo.Checked == true)
                            {
                                PatientdataGridView.SelectedRows[0].Cells[14].Value = "No";
                            }
                            PatientdataGridView.SelectedRows[0].Cells[15].Value = txtGB_Id.Text;
                            if (rbtnActive.Checked == true)
                            {
                                PatientdataGridView.SelectedRows[0].Cells[16].Value = "Active";
                            }
                            else if (rbtnInactive.Checked == true)
                            {
                                PatientdataGridView.SelectedRows[0].Cells[16].Value = "Inactive";
                            }
                        }
                        catch
                        {
                            MessageBox.Show("Error with the data import into the gridview!");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error while updating record!: " + ex);
                        //MessageBox.Show(ex.Message);
                    }
                    connection.Close();
                }
            }else 
            {
                MessageBox.Show("The ID must be entered!!!");
            }


           
        }
        
        private void btnClear_Click(object sender, EventArgs e)
        {
            txtID.Clear();
            txtFName.Clear();
            txtLName.Clear();
            rbtnMale.Checked = false;
            rbtnFemale.Checked = false;
            bdPicker.ResetText();
            txtPhone.Clear();
            txtEC.Clear();
            txtECN.Clear();
            txtBloodType.Clear();
            txtAddress.Clear();
            txtEmail.Clear();
            txtInsNumber.Clear();
            txtInsCompany.Clear();
            txtNationality.Clear();
            rbtnGBYes.Checked = false;
            rbtnGBNo.Checked = false;
            txtGB_Id.Clear();
            rbtnActive.Checked = false;
            rbtnInactive.Checked = false;
            txtID.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
