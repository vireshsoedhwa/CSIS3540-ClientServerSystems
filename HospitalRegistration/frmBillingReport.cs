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
    public partial class frmBillingReport : Form
    {
        int diagnosis_id;

        public frmBillingReport(int p_diagnosis_id)
        {
            diagnosis_id = p_diagnosis_id;
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'f_user33DataSet.Billing' table. You can move, or remove it, as needed.
            this.BillingTableAdapter.Fill(this.f_user33DataSet.Billing,diagnosis_id);
            //this.BillingTableAdapter.Fill(this.f_user33DataSet.Billing, 1);
            this.reportViewer1.RefreshReport();
        }
    }
}
