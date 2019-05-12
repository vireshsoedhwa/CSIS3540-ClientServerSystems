using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HospitalRegistration
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new MDIParentFrm());
            //Application.Run(new frmDoctorNurses());
            //Application.Run(new frmBillingReport());
           //Application.Run(new frmBilling());
            //Application.Run(new Diagnosis());
            Application.Run(new frmMain());
        }
    }
}
