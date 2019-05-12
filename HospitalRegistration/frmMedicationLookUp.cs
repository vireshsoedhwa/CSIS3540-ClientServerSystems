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
    public partial class frmMedicationLookUp : Form
    {
        //Set Global Form Variables
        //-----------------------------------
        //get the data and pass the value to Diagnosis Form
        private string medicationCode;
        private string medicationName;
        private string medicationQty;
        private string medicationPrice;
        private string medicationSubTotal;
        private decimal medicationTotal;

        public string v_medName
        {
            get { return medicationName; }
            set { medicationName = value; }

        }

        public string v_medCode
        {
            get { return medicationCode; }
            set { medicationCode = value; }

        }

        public string v_medQty
        {
            get { return medicationQty; }
            set { medicationQty = value; }

        }

        public string v_medPrice
        {
            get { return medicationPrice; }
            set { medicationPrice = value; }

        }

        public string v_medSubTotal
        {
            get { return medicationSubTotal; }
            set { medicationSubTotal = value; }

        }

        public decimal v_Total
        {
            get { return medicationTotal; }
            set { medicationTotal = value; }

        }

        //----------------------------------- End


        //MySQL Parameters
        MySqlConnection connection;

        //Set For Medication Class
        List<Medication> med_obj;
        Medication med;

        public frmMedicationLookUp()
        {
            InitializeComponent();
        }

        private void frmMedicationLookUp_Load(object sender, EventArgs e)
        {
            //Settings for List View Medicines / Items Ordered
            lstViewMedicines.View = View.Details;
            lstViewMedicines.GridLines = true;
            lstViewMedicines.FullRowSelect = true;

            lstViewItemsOrdered.View = View.Details;
            lstViewItemsOrdered.GridLines = true;
            lstViewItemsOrdered.FullRowSelect = true;
            
            //Add items in the listview Medicines
            string[] arr = new string[5];
            

            //Read Server Parameters
            XmlTextReader readerServerParams = new XmlTextReader("data.xml");
            string connectionString = "";
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

            //Connect to Server
            connection = new MySqlConnection(connectionString);


            if (connection != null)
            {
                connection.Open();
                string query = "SELECT med_ID, Ucase(med_Name), med_Dosage, med_StockLevel, med_Cost FROM f_user33.Medication order by med_Name ASC Limit 0,1000";

                MySqlCommand cmd = new MySqlCommand(query, connection);
                //MySqlDataAdapter mcmd = new MySqlDataAdapter();
                MySqlDataReader reader;

               // mcmd.SelectCommand = cmd;
                /*mcmd contains the data
                 * mcmd.fill "transfer data to dataset */

                //DataSet ds = new DataSet();
                //mcmd.Fill(ds);
                //dataGridView1.DataSource = ds.Tables[0];

                //execute query
                reader = cmd.ExecuteReader();
                
                //set array for data holder
                string[] data = new string[5];

                //set listview item
                ListViewItem item;

                //set the medication List
                med_obj = new List<Medication>();
                

                //clear items
                lstViewMedicines.Items.Clear();

                //populate data
                while (reader.Read())
                {
                    data[0] = reader.GetString(0);
                    data[1] = reader.GetString(1);
                    data[2] = reader.GetString(2);
                    data[3] = reader.GetString(3);
                    data[4] = reader.GetString(4);
                    
                    
                    item = new ListViewItem(data);
                    this.lstViewMedicines.Items.Add(item);

                    //load them up in Medication Class for fast searching
                    med = new Medication(data[0], data[1], data[2], data[3], data[4]);
                    med_obj.Add(med);
                }

                //close connection
                reader.Close();
                connection.Close();

            }


            //If the user wants to update ordered medications 
            //Load back to "Items Ordered" ListView Control
            if (v_medName != "" || v_medName.Length > 0)
            {
                
                //set the variable and split them into arrays
                string[] stringSeparators = new string[] { "," };
                string[] str_med_id = v_medCode.Split(stringSeparators, StringSplitOptions.None);
                string[] str_med_name = v_medName.Split(stringSeparators, StringSplitOptions.None);
                string[] str_med_qty = v_medQty.Split(stringSeparators, StringSplitOptions.None);
                string[] str_med_price = v_medPrice.Split(stringSeparators, StringSplitOptions.None);
                string[] str_med_subtotal = v_medSubTotal.Split(stringSeparators, StringSplitOptions.None);
                
                //Clear the List View First
                lstViewItemsOrdered.Items.Clear();

                //set array for data holder
                string[] data = new string[5];

                //set listview item
                ListViewItem item_ordered;

                //load the data
                for (int i = 0; i < str_med_id.Length; i++)
                {
                    data[0] = str_med_id[i];
                    data[1] = str_med_name[i];
                    data[2] = str_med_qty[i];
                    data[3] = str_med_price[i];
                    data[4] = str_med_subtotal[i];

                    //insert them into ListView
                    item_ordered = new ListViewItem(data);
                    this.lstViewItemsOrdered.Items.Add(item_ordered);
                }

                //set the total 
                lblTotalCost.Text = v_Total.ToString();
            
            }

        }

        

        private void lstViewMedicines_SelectedIndexChanged(object sender, EventArgs e)
        {   
            //check if uses selected an item
            if (lstViewMedicines.SelectedItems.Count == 0)
                return;

            ListViewItem item = lstViewMedicines.SelectedItems[0];
            
            //fill the text boxes
            txtMedCode.Text = item.SubItems[0].Text;
            txtMedName.Text = item.SubItems[1].Text;
            txtDosage.Text=  item.SubItems[2].Text;
            txtStock.Text = item.SubItems[3].Text;
            txtPrice.Text = item.SubItems[4].Text;
            txtItemNeed.Text = "";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // Validation Check: check if ordering more than the stock
            if (txtItemNeed.Text.Trim()=="" || int.Parse(txtItemNeed.Text) == 0)
            {
                MessageBox.Show("Please Enter A Quantity", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
                
            }
            else if (int.Parse(txtStock.Text) < int.Parse(txtItemNeed.Text))
            {
                MessageBox.Show("Trying to order an item that is larger than the stock", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }

            
            decimal calcSubTotal = calculateSubTotals();

            //check if medicine name is already exists
            if (calcSubTotal == 0M && lstViewItemsOrdered.Items.Count > 1)
                return;


            //set array for data holder
            string[] data = new string[5];
            decimal subTotal =  decimal.Parse(txtItemNeed.Text) * decimal.Parse(txtPrice.Text);

            //set listview item
            data[0] = txtMedCode.Text;
            data[1] = txtMedName.Text;
            data[2] = txtItemNeed.Text;
            data[3] = txtPrice.Text;
            data[4] = (subTotal).ToString();
            
            
            //Display Total Cost
            lblTotalCost.Text =  (subTotal + calcSubTotal).ToString();

            //add to listview
            ListViewItem itemToAdd = new ListViewItem(data);
            this.lstViewItemsOrdered.Items.Add(itemToAdd);


            //Clear Fields After Add Event
            clearFields();
        }


        //Calculate sub Totals and Totals
        private decimal calculateSubTotals()
        {
            //check if medicine name is already exists
            int listCount = this.lstViewItemsOrdered.Items.Count;

            decimal total = 0;

            foreach (ListViewItem item in lstViewItemsOrdered.Items)
            {
                if (string.Compare(txtMedName.Text.Trim().ToUpper(), item.SubItems[1].Text.Trim().ToUpper(), true) == 0)
                {
                    MessageBox.Show("Medicine Name Is Already In The List", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return 0; //medicine already exists
                }

                total += total + decimal.Parse(item.SubItems[4].Text);

            }

            return total;
        
        } //end calculate

        //clear medication fields
        private void clearFields()
        {
            txtMedCode.Text = "";
            txtMedName.Text = "";
            txtDosage.Text = "";
            txtStock.Text = "";
            txtPrice.Text = "";
            txtItemNeed.Text = "";

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            lstViewItemsOrdered.Items.Clear();
            clearFields();
            lblTotalCost.Text = "0.0";
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
           
            ListView.SelectedListViewItemCollection lstRemove = this.lstViewItemsOrdered.SelectedItems;

            if (lstRemove.Count>0)
            {
                    //remove the selected item                   
                    for (int i = 0; i < lstViewItemsOrdered.SelectedItems.Count; i++)
                    {
                        var confirmation = MessageBox.Show("Do You Want To Remove " + lstViewItemsOrdered.SelectedItems[0].SubItems[1].Text + " ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (confirmation == DialogResult.Yes)
                            lstViewItemsOrdered.Items.RemoveAt(i);
                    }

                    lblTotalCost.Text = calculateSubTotals().ToString();
            }
            else
                MessageBox.Show("You Did Not Make A Selection To Remove", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            //v_medName = textBox1.Text;

            int listCount = this.lstViewItemsOrdered.Items.Count;

            string mdCode="";
            string mdName="";
            string mdQty = "";
            string mdPrice = "";
            string mdSubTotal = "";
            
            foreach (ListViewItem item in lstViewItemsOrdered.Items)
            {   
                //Concatenate all the values with "," delimeter
                mdCode += item.SubItems[0].Text + ",";
                mdName += item.SubItems[1].Text + ",";
                mdQty += item.SubItems[2].Text + ",";
                mdPrice += item.SubItems[3].Text + ",";
                mdSubTotal += item.SubItems[4].Text + ",";
            }

            //if no code is selected
            if (mdCode.Length > 0)
             {
                v_medCode = mdCode.Substring(0, mdCode.Length - 1);
                v_medName = mdName.Substring(0, mdName.Length - 1);
                v_medQty = mdQty.Substring(0, mdQty.Length - 1);
                v_medPrice = mdPrice.Substring(0, mdPrice.Length - 1);
                v_medSubTotal = mdSubTotal.Substring(0, mdSubTotal.Length - 1);

                medicationTotal = decimal.Parse(lblTotalCost.Text);
           }
           else
           {
                v_medCode = "";
                v_medName = "";
                v_medQty = "";
                v_medPrice = "";
                v_medSubTotal = "";

                medicationTotal = 0;
           }

            this.Close();
        }

       
        private void cboMedicineChar_SelectedIndexChanged(object sender, EventArgs e)
        {
            IEnumerable<Medication> data;

            //Search Medication Name using LINQ (For faster searching so that it does not need to re-connect to server)
            if (cboMedicineChar.Text.Trim() == "All")
            {
                            data = from ex in med_obj
                                orderby ex.name
                                select ex;
            }
            else
            {
                                data = from ex in med_obj
                                 where ex.name.StartsWith(cboMedicineChar.Text.Trim())
                                 orderby ex.name
                                 select ex;
            }

            List<Medication> result = data.ToList<Medication>();

            if (result.Count > 0)
            {
                //set array for data holder
                string[] getData = new string[5];

                //set listview item
                ListViewItem item;

                //clear items
                lstViewMedicines.Items.Clear();

                //populate the data
                foreach (var v in result)
                {
                    getData[0] = v.getID();
                    getData[1] = v.getName();
                    getData[2] = v.getDosage();
                    getData[3] = v.getStock();
                    getData[4] = v.getCost();

                    //add to list
                    item = new ListViewItem(getData);
                    this.lstViewMedicines.Items.Add(item);
                }
                    
            }
            else
                MessageBox.Show("Yield Empty Result", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

    }
}
