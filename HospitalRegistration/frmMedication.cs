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

namespace Medication
{
    public partial class frmMedication : Form
    {
        private MySqlConnection connection;

        public frmMedication()
        {
            InitializeComponent();
        }
                
        private void Medication_Load(object sender, EventArgs e)
        {
            MedicationdataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            XmlTextReader reader = new XmlTextReader("data.xml");
            string connectionString = "";

            //string[] names = { "SERVER", "database", "uid", "password" };
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
            MedicationdataGridView.DataSource = null;
            MedicationdataGridView.Rows.Clear();
            string medid, medname;
            if (txtID.Text.Trim() == "")
            {
                medid = null;
            }
            else
            {
                medid = txtID.Text;
            }
            if (txtName.Text.Trim() == "")
            {
                medname = null;
            }
            else
            {
                medname = txtName.Text;
            }

            if ((txtID.Text.Trim() != "") || (txtName.Text.Trim() != ""))
            {
                if (connection != null)
                {
                    connection.Open();
                    string nameOfProcedure = "MedicationLookup";
                    MySqlCommand cmd = new MySqlCommand(nameOfProcedure, connection);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@medID", medid);
                    cmd.Parameters["@medID"].Direction = ParameterDirection.Input;
                    cmd.Parameters.AddWithValue("@medName", medname);
                    cmd.Parameters["@medName"].Direction = ParameterDirection.Input;

                    try
                    {
                        MySqlDataReader reader = cmd.ExecuteReader();

                        while (reader.Read())
                        {
                            MedicationdataGridView.Rows.Add(
                                reader["med_ID"].ToString(),
                                reader["med_Name"].ToString(),
                                reader["med_Dosage"].ToString(),
                                reader["med_Prescribed"].ToString(),
                                reader["med_StockLevel"].ToString(),
                                reader["med_Cost"].ToString()
                            );
                        }
                    }catch
                    {
                        MessageBox.Show("Error with the data from database!");
                    }
                    connection.Close();
                }
            }
            else
            {
                MessageBox.Show("The ID must be entered!!!");
            }
        }

        private void MedicationdataGridView_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int MedselectedRowCount = MedicationdataGridView.Rows.GetRowCount(DataGridViewElementStates.Selected);
            
            if (MedselectedRowCount == 1)
            {
                try
                {
                    txtID.Text = MedicationdataGridView.SelectedRows[0].Cells[0].Value.ToString();
                    txtName.Text = MedicationdataGridView.SelectedRows[0].Cells[1].Value.ToString();
                    txtDosage.Text = MedicationdataGridView.SelectedRows[0].Cells[2].Value.ToString();
                    string prescribed = MedicationdataGridView.SelectedRows[0].Cells[3].Value.ToString();
                    if (prescribed == "True")
                    {
                        rbtnPTrue.Checked = true;
                    }
                    else
                    {
                        rbtnPFalse.Checked = true;
                    }
                    txtStockLevel.Text = MedicationdataGridView.SelectedRows[0].Cells[4].Value.ToString();
                    txtCost.Text = MedicationdataGridView.SelectedRows[0].Cells[5].Value.ToString();                    
                }
                catch
                {
                    MessageBox.Show("Error with the data from the gridview!");
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if ((txtID.Text.Trim() != "") ||
                (txtName.Text.Trim() != "") ||
                (txtDosage.Text.Trim() != "") ||
                (rbtnPTrue.Checked != true) ||
                (rbtnPFalse.Checked != true) ||
                (txtStockLevel.Text.Trim() != "") ||
                (txtCost.Text.Trim() != ""))
            {
                if (connection != null)
                {
                    connection.Open();
                    string nameOfProcedure = "addMedication";
                    MySqlCommand cmd = new MySqlCommand(nameOfProcedure, connection);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@medName", txtName.Text);
                    cmd.Parameters["@medName"].Direction = ParameterDirection.Input;
                    cmd.Parameters.AddWithValue("@dosage", txtDosage.Text);
                    cmd.Parameters["@dosage"].Direction = ParameterDirection.Input;
                    string prescribed = "";
                    if (rbtnPTrue.Checked == true)
                    {
                        prescribed = "True";
                    }
                    else
                    {
                        prescribed = "False";
                    }                    
                    cmd.Parameters.AddWithValue("@prescribed", prescribed);
                    cmd.Parameters["@prescribed"].Direction = ParameterDirection.Input;
                    cmd.Parameters.AddWithValue("@stocklevel", txtStockLevel.Text);
                    cmd.Parameters["@stocklevel"].Direction = ParameterDirection.Input;
                    cmd.Parameters.AddWithValue("@cost", txtCost.Text);
                    cmd.Parameters["@cost"].Direction = ParameterDirection.Input;
                    try
                    {
                        cmd.ExecuteNonQuery();
                        lstResult.Items.Add("New medication added successfully!");
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show("Error while adding new medication!: "+ex.Message);
                    }
                    connection.Close();
                }
            }
            else
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
                    string nameOfProcedure = "updateMedication";
                    MySqlCommand cmd = new MySqlCommand(nameOfProcedure, connection);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@medID", txtID.Text);
                    cmd.Parameters["@medID"].Direction = ParameterDirection.Input;
                    cmd.Parameters.AddWithValue("@medName", txtName.Text);
                    cmd.Parameters["@medName"].Direction = ParameterDirection.Input;
                    cmd.Parameters.AddWithValue("@dosage", txtDosage.Text);
                    cmd.Parameters["@dosage"].Direction = ParameterDirection.Input;
                    string prescribed = "";
                    if (rbtnPTrue.Checked == true)
                    {
                        prescribed = "True";
                    }
                    else
                    {
                        prescribed = "False";
                    }

                    cmd.Parameters.AddWithValue("@prescribed", prescribed);
                    cmd.Parameters["@prescribed"].Direction = ParameterDirection.Input;
                    cmd.Parameters.AddWithValue("@stocklevel", txtStockLevel.Text);
                    cmd.Parameters["@stocklevel"].Direction = ParameterDirection.Input;
                    cmd.Parameters.AddWithValue("@cost", txtCost.Text);
                    cmd.Parameters["@cost"].Direction = ParameterDirection.Input;
                    try
                    {
                        cmd.ExecuteNonQuery();
                        lstResult.Items.Add("Medication updated successfully!");
                        
                        try
                        {
                            int MedicationselectedRowCount = MedicationdataGridView.Rows.GetRowCount(DataGridViewElementStates.Selected);
                            DataGridViewRow row = this.MedicationdataGridView.Rows[MedicationselectedRowCount];
                            MedicationdataGridView.SelectedRows[0].Cells[1].Value = txtName.Text;
                            MedicationdataGridView.SelectedRows[0].Cells[2].Value = txtDosage.Text;
                            if (rbtnPTrue.Checked == true)
                            {
                                MedicationdataGridView.SelectedRows[0].Cells[3].Value = "True";
                            }else if(rbtnPFalse.Checked == true)
                            {
                                MedicationdataGridView.SelectedRows[0].Cells[3].Value = "False";
                            }
                            MedicationdataGridView.SelectedRows[0].Cells[4].Value = txtStockLevel.Text;
                            MedicationdataGridView.SelectedRows[0].Cells[5].Value = txtCost.Text;
                        }
                        catch
                        {
                            MessageBox.Show("Error with the data import into the gridview!");
                        }
                        
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show("Error while updating medication!: "+ex.Message);
                    }
                    connection.Close();
                }
            }
            else
            {
                MessageBox.Show("The ID must be entered!!!");
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            MedicationdataGridView.DataSource = null;
            MedicationdataGridView.Rows.Clear();
            txtID.Text = "";
            txtName.Text = "";
            txtDosage.Text = "";
            rbtnPTrue.Checked = false;
            rbtnPFalse.Checked = false;
            txtStockLevel.Text = "";
            txtCost.Text = "";
        }


    }
}
