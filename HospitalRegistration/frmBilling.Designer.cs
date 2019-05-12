namespace HospitalRegistration
{
    partial class frmBilling
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.grpBxRange = new System.Windows.Forms.GroupBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.datePckrTo = new System.Windows.Forms.DateTimePicker();
            this.datePckrFrom = new System.Windows.Forms.DateTimePicker();
            this.grpBxSearch = new System.Windows.Forms.GroupBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dgvPatientNames = new System.Windows.Forms.DataGridView();
            this.patient_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bdate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvDiagnosis = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subject = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.doctorName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.medIDS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.medNames = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.medQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.medPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.medSubTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.medCost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.consultationFee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblPatientNamesResults = new System.Windows.Forms.Label();
            this.lblDiagnosisResults = new System.Windows.Forms.Label();
            this.grpBxRange.SuspendLayout();
            this.grpBxSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPatientNames)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDiagnosis)).BeginInit();
            this.SuspendLayout();
            // 
            // grpBxRange
            // 
            this.grpBxRange.Controls.Add(this.btnSubmit);
            this.grpBxRange.Controls.Add(this.label2);
            this.grpBxRange.Controls.Add(this.label1);
            this.grpBxRange.Controls.Add(this.datePckrTo);
            this.grpBxRange.Controls.Add(this.datePckrFrom);
            this.grpBxRange.Location = new System.Drawing.Point(38, 12);
            this.grpBxRange.Name = "grpBxRange";
            this.grpBxRange.Size = new System.Drawing.Size(445, 78);
            this.grpBxRange.TabIndex = 2;
            this.grpBxRange.TabStop = false;
            this.grpBxRange.Text = "Search Date Range";
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(337, 47);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 6;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(171, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "To:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "From:";
            // 
            // datePckrTo
            // 
            this.datePckrTo.CustomFormat = "yyyy-MM-dd";
            this.datePckrTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.datePckrTo.Location = new System.Drawing.Point(174, 47);
            this.datePckrTo.Name = "datePckrTo";
            this.datePckrTo.Size = new System.Drawing.Size(142, 20);
            this.datePckrTo.TabIndex = 3;
            // 
            // datePckrFrom
            // 
            this.datePckrFrom.CustomFormat = "yyyy-MM-dd";
            this.datePckrFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.datePckrFrom.Location = new System.Drawing.Point(23, 47);
            this.datePckrFrom.Name = "datePckrFrom";
            this.datePckrFrom.Size = new System.Drawing.Size(144, 20);
            this.datePckrFrom.TabIndex = 2;
            // 
            // grpBxSearch
            // 
            this.grpBxSearch.Controls.Add(this.btnSearch);
            this.grpBxSearch.Controls.Add(this.txtLastName);
            this.grpBxSearch.Controls.Add(this.txtFirstName);
            this.grpBxSearch.Controls.Add(this.label3);
            this.grpBxSearch.Controls.Add(this.label4);
            this.grpBxSearch.Location = new System.Drawing.Point(38, 111);
            this.grpBxSearch.Name = "grpBxSearch";
            this.grpBxSearch.Size = new System.Drawing.Size(445, 77);
            this.grpBxSearch.TabIndex = 3;
            this.grpBxSearch.TabStop = false;
            this.grpBxSearch.Text = "Search Name";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(337, 44);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 8;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(174, 47);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(142, 20);
            this.txtLastName.TabIndex = 7;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(23, 47);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(144, 20);
            this.txtFirstName.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(171, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Last Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "First Name";
            // 
            // dgvPatientNames
            // 
            this.dgvPatientNames.AllowUserToAddRows = false;
            this.dgvPatientNames.AllowUserToDeleteRows = false;
            this.dgvPatientNames.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPatientNames.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.patient_id,
            this.firstname,
            this.lastname,
            this.bdate});
            this.dgvPatientNames.Location = new System.Drawing.Point(40, 217);
            this.dgvPatientNames.MultiSelect = false;
            this.dgvPatientNames.Name = "dgvPatientNames";
            this.dgvPatientNames.Size = new System.Drawing.Size(444, 170);
            this.dgvPatientNames.TabIndex = 4;
            this.dgvPatientNames.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPatientNames_CellClick);
            // 
            // patient_id
            // 
            this.patient_id.HeaderText = "patient_id";
            this.patient_id.Name = "patient_id";
            this.patient_id.Visible = false;
            // 
            // firstname
            // 
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstname.DefaultCellStyle = dataGridViewCellStyle1;
            this.firstname.DividerWidth = 1;
            this.firstname.HeaderText = "First Name";
            this.firstname.Name = "firstname";
            this.firstname.Width = 150;
            // 
            // lastname
            // 
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastname.DefaultCellStyle = dataGridViewCellStyle2;
            this.lastname.DividerWidth = 1;
            this.lastname.HeaderText = "Last Name";
            this.lastname.Name = "lastname";
            this.lastname.Width = 150;
            // 
            // bdate
            // 
            this.bdate.HeaderText = "Birth Date";
            this.bdate.Name = "bdate";
            // 
            // dgvDiagnosis
            // 
            this.dgvDiagnosis.AllowUserToAddRows = false;
            this.dgvDiagnosis.AllowUserToDeleteRows = false;
            this.dgvDiagnosis.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDiagnosis.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.title,
            this.subject,
            this.doctorName,
            this.medIDS,
            this.medNames,
            this.medQty,
            this.medPrice,
            this.medSubTotal,
            this.medCost,
            this.consultationFee,
            this.total,
            this.date});
            this.dgvDiagnosis.Location = new System.Drawing.Point(39, 437);
            this.dgvDiagnosis.MultiSelect = false;
            this.dgvDiagnosis.Name = "dgvDiagnosis";
            this.dgvDiagnosis.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDiagnosis.Size = new System.Drawing.Size(444, 109);
            this.dgvDiagnosis.TabIndex = 5;
            // 
            // id
            // 
            this.id.HeaderText = "dia_id";
            this.id.Name = "id";
            this.id.Visible = false;
            // 
            // title
            // 
            this.title.HeaderText = "Main";
            this.title.Name = "title";
            // 
            // subject
            // 
            this.subject.HeaderText = "Subject";
            this.subject.Name = "subject";
            this.subject.Width = 150;
            // 
            // doctorName
            // 
            this.doctorName.HeaderText = "Doctor Name";
            this.doctorName.Name = "doctorName";
            // 
            // medIDS
            // 
            this.medIDS.HeaderText = "medIDS";
            this.medIDS.Name = "medIDS";
            this.medIDS.Visible = false;
            // 
            // medNames
            // 
            this.medNames.HeaderText = "medNames";
            this.medNames.Name = "medNames";
            this.medNames.Visible = false;
            // 
            // medQty
            // 
            this.medQty.HeaderText = "medQty";
            this.medQty.Name = "medQty";
            this.medQty.Visible = false;
            // 
            // medPrice
            // 
            this.medPrice.HeaderText = "medPrice";
            this.medPrice.Name = "medPrice";
            this.medPrice.Visible = false;
            // 
            // medSubTotal
            // 
            this.medSubTotal.HeaderText = "medSubTotal";
            this.medSubTotal.Name = "medSubTotal";
            this.medSubTotal.Visible = false;
            // 
            // medCost
            // 
            this.medCost.HeaderText = "medCost";
            this.medCost.Name = "medCost";
            this.medCost.Visible = false;
            // 
            // consultationFee
            // 
            this.consultationFee.HeaderText = "consultationFee";
            this.consultationFee.Name = "consultationFee";
            this.consultationFee.Visible = false;
            // 
            // total
            // 
            this.total.HeaderText = "total";
            this.total.Name = "total";
            this.total.Visible = false;
            // 
            // date
            // 
            this.date.HeaderText = "Date";
            this.date.Name = "date";
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(69, 586);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(154, 32);
            this.btnPrint.TabIndex = 6;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(248, 586);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 32);
            this.btnClear.TabIndex = 7;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(329, 586);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 32);
            this.btnExit.TabIndex = 8;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(39, 201);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Patient Names";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(35, 421);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Diagnosis";
            // 
            // lblPatientNamesResults
            // 
            this.lblPatientNamesResults.AutoSize = true;
            this.lblPatientNamesResults.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPatientNamesResults.ForeColor = System.Drawing.Color.Teal;
            this.lblPatientNamesResults.Location = new System.Drawing.Point(39, 390);
            this.lblPatientNamesResults.Name = "lblPatientNamesResults";
            this.lblPatientNamesResults.Size = new System.Drawing.Size(45, 16);
            this.lblPatientNamesResults.TabIndex = 11;
            this.lblPatientNamesResults.Text = "Results:";
            // 
            // lblDiagnosisResults
            // 
            this.lblDiagnosisResults.AutoSize = true;
            this.lblDiagnosisResults.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiagnosisResults.ForeColor = System.Drawing.Color.Teal;
            this.lblDiagnosisResults.Location = new System.Drawing.Point(37, 549);
            this.lblDiagnosisResults.Name = "lblDiagnosisResults";
            this.lblDiagnosisResults.Size = new System.Drawing.Size(45, 16);
            this.lblDiagnosisResults.TabIndex = 12;
            this.lblDiagnosisResults.Text = "Results:";
            // 
            // frmBilling
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 630);
            this.Controls.Add(this.lblDiagnosisResults);
            this.Controls.Add(this.lblPatientNamesResults);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.dgvDiagnosis);
            this.Controls.Add(this.dgvPatientNames);
            this.Controls.Add(this.grpBxSearch);
            this.Controls.Add(this.grpBxRange);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmBilling";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Billing";
            this.Load += new System.EventHandler(this.frmBilling_Load);
            this.grpBxRange.ResumeLayout(false);
            this.grpBxRange.PerformLayout();
            this.grpBxSearch.ResumeLayout(false);
            this.grpBxSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPatientNames)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDiagnosis)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpBxRange;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker datePckrTo;
        private System.Windows.Forms.DateTimePicker datePckrFrom;
        private System.Windows.Forms.GroupBox grpBxSearch;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridView dgvPatientNames;
        private System.Windows.Forms.DataGridView dgvDiagnosis;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblPatientNamesResults;
        private System.Windows.Forms.Label lblDiagnosisResults;
        private System.Windows.Forms.DataGridViewTextBoxColumn patient_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstname;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastname;
        private System.Windows.Forms.DataGridViewTextBoxColumn bdate;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn title;
        private System.Windows.Forms.DataGridViewTextBoxColumn subject;
        private System.Windows.Forms.DataGridViewTextBoxColumn doctorName;
        private System.Windows.Forms.DataGridViewTextBoxColumn medIDS;
        private System.Windows.Forms.DataGridViewTextBoxColumn medNames;
        private System.Windows.Forms.DataGridViewTextBoxColumn medQty;
        private System.Windows.Forms.DataGridViewTextBoxColumn medPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn medSubTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn medCost;
        private System.Windows.Forms.DataGridViewTextBoxColumn consultationFee;
        private System.Windows.Forms.DataGridViewTextBoxColumn total;
        private System.Windows.Forms.DataGridViewTextBoxColumn date;

    }
}