using Medication;
using PatientRegistration;
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
    public partial class frmMain : Form
    {   
        //set Global Variables
        string userId;
        string firstName;
        string lastName;
        string userType;
        


        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            
            //load Login Form First
            frmLogin LoginForm = new frmLogin();
            LoginForm.ShowDialog(this);

            //if login is successful
            userId = LoginForm.v_userId;
            firstName = LoginForm.v_firstName;
            lastName = LoginForm.v_lastName;
            userType = LoginForm.v_userType;

            this.Text = "Hospital Registration : Welcome (" + userType + ") " + firstName + " " + lastName;

           // pictureBox1.Left = this.Size.Width/3;
           // pictureBox1.Top = this.Size.Height/3;

           


        }

        //exit button
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {   
            //closes the application
            Application.Exit();
        }

        //when closing the form
        private void frmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        //when clicking the about button
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAbout fAbout = new frmAbout();
            fAbout.ShowDialog();
        }

        //when resizing the form
        private void frmMain_Resize(object sender, EventArgs e)
        {
            int left, top;
            left = (this.Width - pictureBox1.ClientRectangle.Width) / 2;
            top = (this.Height - pictureBox1.ClientRectangle.Height) / 2;
            pictureBox1.Location = new Point(this.Location.X + left, this.Location.Y + top);
        }


        /*
        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void printToolStripButton_Click(object sender, EventArgs e)
        {
            
        }

        private void usersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        

        private void patientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        

        private void medicineToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        

        private void medicationToolStripButton_Click(object sender, EventArgs e)
        {
           
        }

        private void newToolStripButton_Click(object sender, EventArgs e)
        {
            
        }

        private void diagnosisToolStripButton_Click(object sender, EventArgs e)
        {
            

        }

        private void usersStripButton1_Click(object sender, EventArgs e)
        {
            
        }

        private void doctorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void reportsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }
        */


        /// Methods
        /// ------------------------------------
        //Patient
        private void displayPatient()
        {

            //if log on as a System Admin, prevent access the patient registration form
            //if (userType == "System Admin")
            //{
            //    MessageBox.Show("You Are Not Allowed To Access This Information", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    return;
            //}
            //show patient registration
            frmPatientRegistration PatientRegistration = new frmPatientRegistration();
            PatientRegistration.ShowDialog();

        }

        //Medication
        private void displayMedication()
        {
            //if log on as a System Admin, prevent access the medication form
            //if (userType == "System Admin")
            //{
            //    MessageBox.Show("You Are Not Allowed To Access This Information", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    return;
            //}

            //medication
            frmMedication fMed = new frmMedication();
            fMed.ShowDialog();
        
        }

        //Diagnosis
        private void displayDiagnosis()
        {
            //if log on as a nurse, prevent access the diagnosis form
            if (userType == "Nurse" || userType == "System Admin")
            //if (userType == "Nurse")
            {
                MessageBox.Show("You Are Not Allowed To Access This Information", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                //load diagnosis form
                frmDiagnosis frmD = new frmDiagnosis(int.Parse(userId.ToString()), firstName, lastName);
                frmD.ShowDialog();

            }
        }

        //Users
        private void displayUsers()
        {

            //update user's personal info. If System Admin, shows everything.
            frmDoctorNurses frmDocNur = new frmDoctorNurses(userId, userType);
            frmDocNur.ShowDialog();
        }

        //Reports
        private void displayReport()
        {

            //System Admin are not permitted to access this form
            //if (userType == "System Admin")
            //{
            //    MessageBox.Show("You Are Not Allowed To Access This Information", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    return;
            //}

            //Print Billing / Receipt
            frmBilling fb = new frmBilling();
            fb.ShowDialog();

        }

        private void patientButton_Click(object sender, EventArgs e)
        {
            displayPatient();
        }

        private void medicationButton_Click(object sender, EventArgs e)
        {
            displayMedication();
        }

        private void diagnosisButton_Click(object sender, EventArgs e)
        {
            displayDiagnosis();
        }

        private void usersButton_Click(object sender, EventArgs e)
        {
            displayUsers();
        }

        private void printButton_Click(object sender, EventArgs e)
        {
            displayReport();
        }

        private void patientMenuItem_Click(object sender, EventArgs e)
        {
            displayPatient();
        }

        private void medicineMenuItem_Click(object sender, EventArgs e)
        {
            displayMedication();
        }

        private void diagnosisMenuItem_Click(object sender, EventArgs e)
        {
            displayDiagnosis();
        }

        private void usersMenuItem_Click(object sender, EventArgs e)
        {
            displayUsers();
        }

        private void reportsMenuItem_Click(object sender, EventArgs e)
        {
            displayReport();
        }




        






    }
}
