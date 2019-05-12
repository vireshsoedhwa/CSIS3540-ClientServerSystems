using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HospitalRegistration
{
    public partial class Diagnosis : Form
    {
        public Diagnosis()
        {
            InitializeComponent();
        }

        private void btnMedicationLookUp_Click(object sender, EventArgs e)
        {
            frmMedicationLookUp frmML = new frmMedicationLookUp();

            frmML.v_medCode = this.lblMedCode.Text;
            frmML.v_medName = txtMedicationNames.Text;
            frmML.v_medQty = lblQty.Text;
            frmML.v_medPrice = lblPrice.Text;
            frmML.v_medSubTotal = lblSubTotal.Text;
            frmML.v_Total = decimal.Parse(txtMedicationCost.Text);

            frmML.ShowDialog();

            lblMedCode.Text = frmML.v_medCode;
            txtMedicationNames.Text = frmML.v_medName;
            lblQty.Text = frmML.v_medQty;
            lblPrice.Text = frmML.v_medPrice;
            lblSubTotal.Text = frmML.v_medSubTotal;
            txtMedicationCost.Text = frmML.v_Total.ToString();
        }

        
        private void Diagnosis_Activated_1(object sender, EventArgs e)
        {
            label5.Text = "Activated";
            this.Enabled = true;
        }

        private void Diagnosis_Deactivate(object sender, EventArgs e)
        {
            label5.Text = "DeActivated";
            this.Enabled = false;

        }

        private void Diagnosis_Load(object sender, EventArgs e)
        {

        }
    }
}
