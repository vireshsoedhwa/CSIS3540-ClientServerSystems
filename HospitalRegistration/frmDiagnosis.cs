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
    public partial class frmDiagnosis : Form
    {
        private MySqlConnection connection;
        private DataSet ds;
        private MySqlDataAdapter mcmd;
        XmlTextReader reader = new XmlTextReader("data.xml");


        //These variables will be used for Diagnosis, Billing and Reporting
        string medication_Codes = ""; 
        string medication_Qty = "";
        string medication_Price = "";
        string medication_SubTotal = "";
        //-----------------------------------------------------------------

        //This variable is to store the temporary date for updating

        DateTime Tempdateupdate;

        //for doctor info
        int doctor_id;
        string doctor_firstname;
        string doctor_lastname;
        

        private void connect()
        {
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
            connection = new MySqlConnection(connectionString);        
        }


        public frmDiagnosis(int p_doctor_id, string p_doctor_firstname, string p_doctor_lastname)
        {
            InitializeComponent();


            doctor_id=p_doctor_id;
            doctor_firstname=p_doctor_firstname;
            doctor_lastname = p_doctor_lastname;
            

           
            
        }

        private void frmDiagnosis_Load(object sender, EventArgs e)
        {
            connect();
           
            diag_datagrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            
             //load to Doctor Fields
            this.detail_drID.Text = doctor_id.ToString();
            this.detail_drFirst.Text = doctor_firstname;
            this.detail_drLast.Text = doctor_lastname;
            
            DateTime thisdate = DateTime.Today;
            diagnosisdate.Text = thisdate.ToString("d");

            
            
        }

        private void btnDiaSrc_Click(object sender, EventArgs e)
        {
            if (connection != null)
            {
                int searchparamcount = 0;
                //DATE_FORMAT(D.dia_date,'%Y/%m/%d')

                string query = "SELECT D.*, P.pa_FirstName, P.pa_LastName, P.pa_BloodType, DN.dr_FirstName, DN.dr_LastName ";
                query += "from Diagnosis D ";
                query += "INNER JOIN Patient P ON P.pa_Id = D.Patient_pa_Id ";
                query += "INNER JOIN DoctorNurses DN ON D.dia_dr_ID = DN.dr_ID where ";

                if (!String.IsNullOrEmpty(txtPaID.Text))
                {
                    query += "pa_Id =" + "\"" + txtPaID.Text.ToString() + "\"";
                    searchparamcount++;
                }
                if (!String.IsNullOrEmpty(txtPaFirst.Text))
                {
                    if (searchparamcount > 0)
                    {
                        query += " and ";
                    }
                    query += "pa_FirstName =" + "\"" + txtPaFirst.Text.ToString() + "\"";
                    searchparamcount++;
                }
                if (!String.IsNullOrEmpty(txtPaLast.Text))
                {
                    if (searchparamcount > 0)
                    {
                        query += " and ";
                    }
                    query += "pa_LastName =" + "\"" + txtPaLast.Text.ToString() + "\"";
                    searchparamcount++;
                }

                if (searchparamcount == 0)
                {
                    MessageBox.Show("Enter search parameters");
                    return;
                }

                try
                {
                    connection.Open();
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    MySqlDataAdapter mcmd = new MySqlDataAdapter();
                    MySqlDataReader reader;
                    mcmd.SelectCommand = cmd;

                    reader = cmd.ExecuteReader();

                    diag_datagrid.Rows.Clear();

                    int checkifdatareaderempty = 0;
                    while (reader.Read())
                    {
                        this.diag_datagrid.Rows.Add(
                           reader["dia_ID"].ToString(),//dia_id
                           reader["dia_dr_ID"].ToString(),//doctorid
                           reader["Patient_pa_Id"].ToString(),//patienid                                        
                           reader["pa_FirstName"].ToString(),//patient first name
                           reader["pa_LastName"].ToString(),//patient last name
                           reader["dia_Subject"].ToString(),//subject
                           reader["dia_TreatmentDescription"].ToString(),
                           reader["dia_Title"].ToString(),
                           reader["dia_AllergicHistoryDescription"].ToString(),
                           ((DateTime)reader["dia_date"]),
                           reader["dia_pa_Height"].ToString(),
                           reader["dia_pa_Weight"].ToString(),
                           reader["pa_BloodType"].ToString(),
                           reader["dia_pa_BloodPressure"].ToString(),
                           reader["dia_pa_BodyTemp"].ToString(),
                           reader["dr_FirstName"].ToString(),
                           reader["dr_LastName"].ToString(),
                           reader["dia_ExtensiveStay"].ToString(),
                           reader["dia_medication_names"].ToString(),
                           //reader["dia_medication_price"].ToString(),
                           reader["dia_medication_cost"].ToString(),
                           reader["dia_consultation_fee"].ToString(),
                           reader["dia_cost"].ToString()
                           );
                        checkifdatareaderempty++;
                    }
                    connection.Close();

                    if(checkifdatareaderempty == 0)
                    {
                        searchparamcount = 0;
                        //patient diagnosis record not found....trying to find patient in patient table
                        MessageBox.Show("There is no Diagnosis record for this patient. Displaying patient record instead");
                        query = "select * from Patient where ";
                        
                        if (!String.IsNullOrEmpty(txtPaID.Text))
                        {
                            query += "pa_Id =" + "\"" + txtPaID.Text.ToString() + "\"";
                            searchparamcount++;
                        }
                        if (!String.IsNullOrEmpty(txtPaFirst.Text))
                        {
                            if (searchparamcount > 0)
                            {
                                query += " and ";
                            }
                            query += "pa_FirstName =" + "\"" + txtPaFirst.Text.ToString() + "\"";
                            searchparamcount++;
                        }
                        if (!String.IsNullOrEmpty(txtPaLast.Text))
                        {
                            if (searchparamcount > 0)
                            {
                                query += " and ";
                            }
                            query += "pa_LastName =" + "\"" + txtPaLast.Text.ToString() + "\"";
                            searchparamcount++;
                        }
                        if (searchparamcount == 0)
                        {
                            MessageBox.Show("Enter search parameters");
                            return;
                        }
                        try
                        {
                            connection.Open();
                            MySqlCommand cmdv2 = new MySqlCommand(query, connection);
                            MySqlDataAdapter mcmdv2 = new MySqlDataAdapter();
                            MySqlDataReader readerv2;
                            mcmdv2.SelectCommand = cmd;

                            readerv2 = cmdv2.ExecuteReader();

                            diag_datagrid.Rows.Clear();

                            /*
                            diag_datagrid.Columns[0].HeaderText = "Patient ID";
                            diag_datagrid.Columns[1].HeaderText = "Patient Firstname";
                            diag_datagrid.Columns[2].HeaderText = "Patient Lastname";
                            diag_datagrid.Columns[3].HeaderText = "Patient Gender";
                            diag_datagrid.Columns[4].HeaderText = "Patient Birthdate";
                            diag_datagrid.Columns[4].HeaderText = "Patient Phone";
                            */

                            while (readerv2.Read())
                            {
                                DateTime today = DateTime.Today;
                                /*
                                this.diag_datagrid.Rows.Add(
                                   readerv2["pa_ID"].ToString(),
                                   readerv2["pa_FirstName"].ToString(),
                                   readerv2["pa_LastName"].ToString(),
                                   readerv2["pa_Gender"].ToString(),
                                   readerv2["pa_BirthDate"].ToString(),
                                   readerv2["pa_PhoneNumber"].ToString()
                                   );*/
                                   this.diag_datagrid.Rows.Add(
                                   "",//dia_id
                                   doctor_id.ToString(),//doctorid
                                   readerv2["pa_Id"].ToString(),//patienid                                        
                                   readerv2["pa_FirstName"].ToString(),//patient first name
                                   readerv2["pa_LastName"].ToString(),//patient last name
                                   "",//subject
                                   "",
                                   "",
                                   "",
                                   today,
                                   "",
                                   "",
                                   "",
                                   "",
                                   "",
                                   doctor_firstname,
                                   doctor_lastname
                                   );                                   
                            }
                        }
                        catch (Exception exv2)
                        {
                            MessageBox.Show(exv2.Message);
                        }
                                connection.Close();
                    }                  
                }
                catch (Exception ex)
                {
                    //MessageBox.Show("error");
                    MessageBox.Show(ex.Message);
                }                
            }   
        }

        private void diag_datagrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           if(e.RowIndex >= 0)
           {   
               //if (diag_datagrid.Rows[e.RowIndex].Cells["col_dia_ID"].Value.ToString().Trim()=="")
               try
               {

                   detail_diaID.Text = diag_datagrid.Rows[e.RowIndex].Cells["col_dia_ID"].Value.ToString();
                   detail_paID.Text = diag_datagrid.Rows[e.RowIndex].Cells["col_paID"].Value.ToString();
                   detail_paFirst.Text = diag_datagrid.Rows[e.RowIndex].Cells["col_paFirstName"].Value.ToString();
                   detail_paLast.Text = diag_datagrid.Rows[e.RowIndex].Cells["col_paLastName"].Value.ToString();
                   detail_height.Text = diag_datagrid.Rows[e.RowIndex].Cells["PatientHeight"].Value.ToString();
                   detail_weight.Text = diag_datagrid.Rows[e.RowIndex].Cells["PatientWeight"].Value.ToString();
                   detail_bloodType.Text = diag_datagrid.Rows[e.RowIndex].Cells["Bloodtype"].Value.ToString();
                   detail_bodyTemp.Text = diag_datagrid.Rows[e.RowIndex].Cells["BodyTemp"].Value.ToString();
                   detail_bloodPressure.Text = diag_datagrid.Rows[e.RowIndex].Cells["BloodPressure"].Value.ToString();
                   detail_drID.Text = diag_datagrid.Rows[e.RowIndex].Cells["col_dr_ID"].Value.ToString();
                   detail_drFirst.Text = diag_datagrid.Rows[e.RowIndex].Cells["DrFirstname"].Value.ToString();
                   detail_drLast.Text = diag_datagrid.Rows[e.RowIndex].Cells["Drlastname"].Value.ToString();
                   detail_diatitle.Text = diag_datagrid.Rows[e.RowIndex].Cells["DiagnosisTitle"].Value.ToString();
                   detail_Subject.Text = diag_datagrid.Rows[e.RowIndex].Cells["col_dia_Subject"].Value.ToString();
                   detail_allergicHist.Text = diag_datagrid.Rows[e.RowIndex].Cells["AllergicHistory"].Value.ToString();
                   diagnosisdate.Text = ((DateTime)diag_datagrid.Rows[e.RowIndex].Cells["col_date"].Value).ToString("d");
                   detail_tretDesc.Text = diag_datagrid.Rows[e.RowIndex].Cells["Treatmentdiscription"].Value.ToString();

                   if (diag_datagrid.Rows[e.RowIndex].Cells["ExtensiveStay"].Value.ToString() == "0")
                   {
                       detail_extensivestay.Checked = false;
                   }
                   else
                   {
                       detail_extensivestay.Checked = true;
                   }

                   txtMedicationNames.Text = diag_datagrid.Rows[e.RowIndex].Cells["MedicationName"].Value.ToString();

                   if(diag_datagrid.Rows[e.RowIndex].Cells["MedicationPrice"].Value.ToString() != "")
                   {
                        txtMedicationCost.Text = diag_datagrid.Rows[e.RowIndex].Cells["MedicationPrice"].Value.ToString();
                   }
                   if(diag_datagrid.Rows[e.RowIndex].Cells["Consultationfee"].Value.ToString() != "")
                   {
                        txtConsultationFee.Text = diag_datagrid.Rows[e.RowIndex].Cells["Consultationfee"].Value.ToString();
                   }
                   if(diag_datagrid.Rows[e.RowIndex].Cells["DiagnosisCost"].Value.ToString() != "")
                   {
                        txtTotalDiagcost.Text = diag_datagrid.Rows[e.RowIndex].Cells["DiagnosisCost"].Value.ToString();
                   }          
                   
                   Tempdateupdate = ((DateTime)diag_datagrid.Rows[e.RowIndex].Cells["col_date"].Value);


                   //enable update button
                   this.btnUpdatediagnosis.Enabled = true;

                   

               }
               catch { 
               
               }

           }
            
        }

        private void btnMedicationLookup_Click(object sender, EventArgs e)
        {   

            //load medication look up
            frmMedicationLookUp frmML = new frmMedicationLookUp();

            //initialize variables
            frmML.v_medCode = medication_Codes;
            frmML.v_medName = txtMedicationNames.Text;
            frmML.v_medQty = medication_Qty;
            frmML.v_medPrice = medication_Price;
            frmML.v_medSubTotal = medication_SubTotal;

            //validate medication cost
            decimal medCost = 0;
            if (decimal.TryParse(txtMedicationCost.Text, out medCost))
                frmML.v_Total = decimal.Parse(txtMedicationCost.Text);
            else
                frmML.v_Total = 0;

            //display the lookup
            frmML.ShowDialog();

            //capture the data
            medication_Codes = frmML.v_medCode;
            txtMedicationNames.Text = frmML.v_medName;
            medication_Qty = frmML.v_medQty;
            medication_Price = frmML.v_medPrice;
            medication_SubTotal = frmML.v_medSubTotal;
            txtMedicationCost.Text = frmML.v_Total.ToString();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {   //Closes The Form
            this.Close();
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(detail_paID.Text))
            {
                btnAddNew.Visible = false;
                btnsavenewrecord.Visible = true;
                detail_diaID.Clear();
                detail_diatitle.Clear();
                detail_Subject.Clear();
                detail_allergicHist.Clear();
                detail_tretDesc.Clear();
                detail_extensivestay.Checked = false;
                txtMedicationNames.Clear();
                txtMedicationCost.Text = "0.00";
                txtConsultationFee.Text = "0.00";
                txtTotalDiagcost.Text = "0.00";

                detail_height.Clear();
                detail_weight.Clear();
                detail_bloodType.Clear();
                detail_bloodPressure.Clear();
                detail_bodyTemp.Clear();

                diag_datagrid.Rows.Clear();

                detail_drID.Text = doctor_id.ToString();
                detail_drFirst.Text = doctor_firstname.ToString();
                detail_drLast.Text = doctor_lastname.ToString();

                DateTime today = DateTime.Today;

                diagnosisdate.Text = today.ToString("d");


                //disable update button
                this.btnUpdatediagnosis.Enabled = false;


            }
            else
            {
                MessageBox.Show("Search for patient record first");
            }
            
        }




        private void btnCleardiagnosis_Click(object sender, EventArgs e)
        {
            detail_diatitle.Clear();
            detail_Subject.Clear();
            detail_tretDesc.Clear();
            //detail_drID.Clear();
            //detail_drLast.Clear();
            //detail_drFirst.Clear();
            detail_allergicHist.Clear();
            detail_height.Clear();
            detail_weight.Clear();
            detail_bloodPressure.Clear();
            detail_bloodType.Clear();
            detail_bodyTemp.Clear();
            detail_paID.Clear();
            detail_diaID.Clear();
            txtTotalDiagcost.Text = "0.00";
            txtMedicationNames.Clear();

            detail_paFirst.Clear();
            detail_paLast.Clear();

            diag_datagrid.Rows.Clear();

            medication_Codes = "";            
            medication_Qty = "";
            medication_Price = "";
            medication_SubTotal = "";
            txtMedicationCost.Text = "0.00";

            txtConsultationFee.Text = "0.00";
            
            DateTime thisdate = DateTime.Today;
            diagnosisdate.Text = thisdate.ToString("d");

            btnsavenewrecord.Visible = false;
            btnAddNew.Visible = true;
        }

        private void btnUpdatediagnosis_Click(object sender, EventArgs e)
        {
            if (connection != null)
            {
                //validation here
                //-------------------------------
                if ((detail_height.Text.Trim() == "") ||
                    (detail_weight.Text.Trim() == "") ||
                    (detail_bloodType.Text.Trim() == "") ||
                    (detail_bloodPressure.Text.Trim() == "") ||
                    (detail_bodyTemp.Text.Trim() == "") ||
                    (detail_diaID.Text.Trim() == "") ||
                    (detail_diatitle.Text.Trim() == "") ||
                    (detail_Subject.Text.Trim() == ""))
                {
                    MessageBox.Show("All fields must be filled");
                    return;
                }

                connection.Open();

                calctotalcost(null, null);

                string nameOfProcedure = "edit_DiaRDS";
                MySqlCommand cmd = new MySqlCommand(nameOfProcedure, connection);
                cmd.CommandType = CommandType.StoredProcedure;


                cmd.Parameters.AddWithValue("p_dia_id", detail_diaID.Text.Trim());
                cmd.Parameters["p_dia_id"].Direction = ParameterDirection.Input;

                cmd.Parameters.AddWithValue("p_dia_Title", detail_diatitle.Text.Trim());
                cmd.Parameters["p_dia_Title"].Direction = ParameterDirection.Input;

                cmd.Parameters.AddWithValue("p_dia_Subject", detail_Subject.Text.Trim());
                cmd.Parameters["p_dia_Subject"].Direction = ParameterDirection.Input;

                cmd.Parameters.AddWithValue("p_dia_TreatmentDescription", detail_tretDesc.Text.Trim());
                cmd.Parameters["p_dia_TreatmentDescription"].Direction = ParameterDirection.Input;

                cmd.Parameters.AddWithValue("p_dia_dr_ID", detail_drID.Text.Trim());
                cmd.Parameters["p_dia_dr_ID"].Direction = ParameterDirection.Input;

                cmd.Parameters.AddWithValue("p_dia_AllergicHistoryDescription", detail_allergicHist.Text.Trim());
                cmd.Parameters["p_dia_AllergicHistoryDescription"].Direction = ParameterDirection.Input;

                cmd.Parameters.AddWithValue("p_dia_pa_Height", detail_height.Text.Trim());
                cmd.Parameters["p_dia_pa_Height"].Direction = ParameterDirection.Input;

                cmd.Parameters.AddWithValue("p_dia_pa_Weight", detail_weight.Text.Trim());
                cmd.Parameters["p_dia_pa_Weight"].Direction = ParameterDirection.Input;

                cmd.Parameters.AddWithValue("p_dia_pa_BloodPressure", detail_bloodPressure.Text.Trim());
                cmd.Parameters["p_dia_pa_BloodPressure"].Direction = ParameterDirection.Input;

                cmd.Parameters.AddWithValue("p_dia_pa_BodyTemp", detail_bodyTemp.Text.Trim());
                cmd.Parameters["p_dia_pa_BodyTemp"].Direction = ParameterDirection.Input;

                if (detail_extensivestay.Checked == true)
                {
                    cmd.Parameters.AddWithValue("p_dia_ExtensiveStay", true);
                    cmd.Parameters["p_dia_ExtensiveStay"].Direction = ParameterDirection.Input;
                }
                else
                {
                    cmd.Parameters.AddWithValue("p_dia_ExtensiveStay", false);
                    cmd.Parameters["p_dia_ExtensiveStay"].Direction = ParameterDirection.Input;
                }

                cmd.Parameters.AddWithValue("p_dia_NextAppointmentDate", null);
                cmd.Parameters["p_dia_NextAppointmentDate"].Direction = ParameterDirection.Input;

                cmd.Parameters.AddWithValue("p_dia_med_ID", medication_Codes);
                cmd.Parameters["p_dia_med_ID"].Direction = ParameterDirection.Input;

                cmd.Parameters.AddWithValue("p_Patient_pa_Id", detail_paID.Text.Trim());
                cmd.Parameters["p_Patient_pa_Id"].Direction = ParameterDirection.Input;
                


                //DateTime thisDate1 = new DateTime(2011, 6, 10);



                cmd.Parameters.AddWithValue("p_dia_date", Tempdateupdate);
                cmd.Parameters["p_dia_date"].Direction = ParameterDirection.Input;

                cmd.Parameters.AddWithValue("p_dia_cost", txtTotalDiagcost.Text.Trim());
                cmd.Parameters["p_dia_cost"].Direction = ParameterDirection.Input;
                
                cmd.Parameters.AddWithValue("p_dia_medication_ids", medication_Codes );
                cmd.Parameters["p_dia_medication_ids"].Direction = ParameterDirection.Input;

                cmd.Parameters.AddWithValue("p_dia_medication_names", txtMedicationNames.Text.Trim());
                cmd.Parameters["p_dia_medication_names"].Direction = ParameterDirection.Input;

                cmd.Parameters.AddWithValue("p_dia_medication_qty", medication_Qty);
                cmd.Parameters["p_dia_medication_qty"].Direction = ParameterDirection.Input;

                cmd.Parameters.AddWithValue("p_dia_medication_price", medication_Price);
                cmd.Parameters["p_dia_medication_price"].Direction = ParameterDirection.Input;

                cmd.Parameters.AddWithValue("p_dia_medication_subtotal", medication_SubTotal);
                cmd.Parameters["p_dia_medication_subtotal"].Direction = ParameterDirection.Input;

                cmd.Parameters.AddWithValue("p_dia_medication_cost", txtMedicationCost.Text.Trim());
                cmd.Parameters["p_dia_medication_cost"].Direction = ParameterDirection.Input;

                cmd.Parameters.AddWithValue("p_dia_consultation_fee", txtConsultationFee.Text.Trim());
                cmd.Parameters["p_dia_consultation_fee"].Direction = ParameterDirection.Input;                
                try
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Diagnosis Record Updated");

                    //disable update button
                    this.btnUpdatediagnosis.Enabled = false;
                }    
                catch
                {
                    MessageBox.Show("Update failed!");
                    
                    //disable update button
                    this.btnUpdatediagnosis.Enabled = true;
                }
                connection.Close();
                btnCleardiagnosis_Click(sender, e);
            }
        }

        private void Savenewrecord_Click(object sender, EventArgs e)
        {
            if (connection != null)
            {
                //validation here. Must not accept empty firstname and lastname

                //validation here
                //-------------------------------
                if ((detail_height.Text.Trim() == "") ||
                    (detail_weight.Text.Trim() == "") ||
                    (detail_bloodType.Text.Trim() == "") ||
                    (detail_bloodPressure.Text.Trim() == "") ||
                    (detail_bodyTemp.Text.Trim() == "") ||
                    (detail_diatitle.Text.Trim() == "") ||
                    (detail_Subject.Text.Trim() == ""))                    
                {
                    MessageBox.Show("All relevant fields must be filled");
                    return;
                }

                else
                {
                    if (connection != null)
                    {
                        calctotalcost(null, null);

                        connection.Open();
                        string nameOfProcedure = "addDiaRds";
                        MySqlCommand cmd = new MySqlCommand(nameOfProcedure, connection);
                        cmd.CommandType = CommandType.StoredProcedure;

                        cmd.Parameters.AddWithValue("dia_Title", detail_diatitle.Text.Trim());
                        cmd.Parameters["dia_Title"].Direction = ParameterDirection.Input;

                        cmd.Parameters.AddWithValue("dia_Subject", detail_Subject.Text.Trim());
                        cmd.Parameters["dia_Subject"].Direction = ParameterDirection.Input;

                        cmd.Parameters.AddWithValue("dia_TreatmentDescription", detail_tretDesc.Text.Trim());
                        cmd.Parameters["dia_TreatmentDescription"].Direction = ParameterDirection.Input;

                        cmd.Parameters.AddWithValue("dia_dr_ID", doctor_id);
                        cmd.Parameters["dia_dr_ID"].Direction = ParameterDirection.Input;

                        cmd.Parameters.AddWithValue("dia_AllergicHistoryDescription", detail_allergicHist.Text.Trim());
                        cmd.Parameters["dia_AllergicHistoryDescription"].Direction = ParameterDirection.Input;

                        cmd.Parameters.AddWithValue("dia_pa_Height", detail_height.Text.Trim());
                        cmd.Parameters["dia_pa_Height"].Direction = ParameterDirection.Input;

                        cmd.Parameters.AddWithValue("dia_pa_Weight", detail_weight.Text.Trim());
                        cmd.Parameters["dia_pa_Weight"].Direction = ParameterDirection.Input;

                        cmd.Parameters.AddWithValue("dia_pa_BloodPressure", detail_bloodPressure.Text.Trim());
                        cmd.Parameters["dia_pa_BloodPressure"].Direction = ParameterDirection.Input;

                        cmd.Parameters.AddWithValue("dia_pa_BodyTemp", detail_bodyTemp.Text.Trim());
                        cmd.Parameters["dia_pa_BodyTemp"].Direction = ParameterDirection.Input;

                        if (detail_extensivestay.Checked == true)
                        {
                            cmd.Parameters.AddWithValue("dia_ExtensiveStay", true);
                            cmd.Parameters["dia_ExtensiveStay"].Direction = ParameterDirection.Input;
                        }
                        else
                        {
                            cmd.Parameters.AddWithValue("dia_ExtensiveStay", false);
                            cmd.Parameters["dia_ExtensiveStay"].Direction = ParameterDirection.Input;
                        }

                        cmd.Parameters.AddWithValue("dia_NextAppointmentDate", null);
                        cmd.Parameters["dia_NextAppointmentDate"].Direction = ParameterDirection.Input;

                        cmd.Parameters.AddWithValue("dia_med_ID", null);
                        cmd.Parameters["dia_med_ID"].Direction = ParameterDirection.Input;

                        cmd.Parameters.AddWithValue("Patient_pa_Id", detail_paID.Text.Trim());
                        cmd.Parameters["Patient_pa_Id"].Direction = ParameterDirection.Input;

                        DateTime inputtoday = DateTime.Today;

                        cmd.Parameters.AddWithValue("dia_date", inputtoday);
                        cmd.Parameters["dia_date"].Direction = ParameterDirection.Input;

                        cmd.Parameters.AddWithValue("dia_cost", txtTotalDiagcost.Text.Trim());
                        cmd.Parameters["dia_cost"].Direction = ParameterDirection.Input;

                        cmd.Parameters.AddWithValue("dia_medication_ids", medication_Codes);
                        cmd.Parameters["dia_medication_ids"].Direction = ParameterDirection.Input;

                        cmd.Parameters.AddWithValue("dia_medication_names", txtMedicationNames.Text.Trim());
                        cmd.Parameters["dia_medication_names"].Direction = ParameterDirection.Input;

                        cmd.Parameters.AddWithValue("dia_medication_qty", medication_Qty);
                        cmd.Parameters["dia_medication_qty"].Direction = ParameterDirection.Input;

                        cmd.Parameters.AddWithValue("dia_medication_price", medication_Price);
                        cmd.Parameters["dia_medication_price"].Direction = ParameterDirection.Input;

                        cmd.Parameters.AddWithValue("dia_medication_subtotal", medication_SubTotal);
                        cmd.Parameters["dia_medication_subtotal"].Direction = ParameterDirection.Input;

                        cmd.Parameters.AddWithValue("dia_medication_cost", txtMedicationCost.Text.Trim());
                        cmd.Parameters["dia_medication_cost"].Direction = ParameterDirection.Input;

                        cmd.Parameters.AddWithValue("dia_consultation_fee", txtConsultationFee.Text.Trim());
                        cmd.Parameters["dia_consultation_fee"].Direction = ParameterDirection.Input;

                        MySqlParameter retrId = new MySqlParameter("returnId", MySqlDbType.Int16);
                        retrId.Direction = ParameterDirection.Output;
                        cmd.Parameters.Add(retrId);
                        cmd.ExecuteNonQuery();

                        connection.Close();

                        int regIDadded = 0;
                        regIDadded = int.Parse(cmd.Parameters["returnId"].Value.ToString());
                        if (regIDadded > 0)
                        {
                            MessageBox.Show("Diagnosis added with id: " + regIDadded);
                        }
                        else
                        {
                            MessageBox.Show("An Error Occurred");
                        }
                        btnCleardiagnosis_Click(sender, e);
                    }
                }
            }
        }

        private void calctotalcost(object sender, MouseEventArgs e)
        {
            decimal consulfee = 0;
            decimal medicationcost = 0;

            if (decimal.TryParse(txtConsultationFee.Text.ToString(),out consulfee) && 
                decimal.TryParse(txtMedicationCost.Text.ToString(), out medicationcost))
            {
                txtTotalDiagcost.Text = (consulfee + medicationcost).ToString();
            }
            else
            {
                MessageBox.Show("please enter numeric value for consulfee");
            }
        }

        private void txtConsultationFee_TextChanged(object sender, EventArgs e)
        {
            calctotalcost(null, null);
        }
    }
}


