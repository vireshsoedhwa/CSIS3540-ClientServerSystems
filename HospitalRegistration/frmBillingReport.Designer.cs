namespace HospitalRegistration
{
    partial class frmBillingReport
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.BillingBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.f_user33DataSet = new HospitalRegistration.f_user33DataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.BillingTableAdapter = new HospitalRegistration.f_user33DataSetTableAdapters.BillingTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.BillingBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.f_user33DataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // BillingBindingSource
            // 
            this.BillingBindingSource.DataMember = "Billing";
            this.BillingBindingSource.DataSource = this.f_user33DataSet;
            // 
            // f_user33DataSet
            // 
            this.f_user33DataSet.DataSetName = "f_user33DataSet";
            this.f_user33DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.BillingBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "HospitalRegistration.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(667, 655);
            this.reportViewer1.TabIndex = 0;
            // 
            // BillingTableAdapter
            // 
            this.BillingTableAdapter.ClearBeforeFill = true;
            // 
            // frmBillingReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(667, 655);
            this.Controls.Add(this.reportViewer1);
            this.Name = "frmBillingReport";
            this.Text = "Patient Billing / Receipt";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BillingBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.f_user33DataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource BillingBindingSource;
        private f_user33DataSet f_user33DataSet;
        private f_user33DataSetTableAdapters.BillingTableAdapter BillingTableAdapter;
    }
}