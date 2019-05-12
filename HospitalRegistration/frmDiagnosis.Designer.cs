namespace HospitalRegistration
{
    partial class frmDiagnosis
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
            this.diag_datagrid = new System.Windows.Forms.DataGridView();
            this.col_dia_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_dr_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_paID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_paFirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_paLastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_dia_Subject = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Treatmentdiscription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiagnosisTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AllergicHistory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PatientHeight = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PatientWeight = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Bloodtype = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BloodPressure = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BodyTemp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DrFirstname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Drlastname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ExtensiveStay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MedicationName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MedicationPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Consultationfee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiagnosisCost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.detail_paID = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.detail_paLast = new System.Windows.Forms.TextBox();
            this.detail_paFirst = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.detail_drLast = new System.Windows.Forms.TextBox();
            this.detail_drFirst = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.detail_drID = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.detail_Subject = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.detail_tretDesc = new System.Windows.Forms.RichTextBox();
            this.detail_allergicHist = new System.Windows.Forms.TextBox();
            this.detail_bloodType = new System.Windows.Forms.TextBox();
            this.detail_weight = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.detail_height = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.detail_bloodPressure = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.detail_bodyTemp = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.diagnosisdate = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.btnCleardiagnosis = new System.Windows.Forms.Button();
            this.detail_diaID = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.btnAddNew = new System.Windows.Forms.Button();
            this.btnUpdatediagnosis = new System.Windows.Forms.Button();
            this.txtMedicationNames = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.txtMedicationCost = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.txtConsultationFee = new System.Windows.Forms.TextBox();
            this.lblConsultationFee = new System.Windows.Forms.Label();
            this.txtTotalDiagcost = new System.Windows.Forms.TextBox();
            this.label25 = new System.Windows.Forms.Label();
            this.btnMedicationLookup = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnDiaSrc = new System.Windows.Forms.Button();
            this.txtPaLast = new System.Windows.Forms.TextBox();
            this.txtPaFirst = new System.Windows.Forms.TextBox();
            this.txtPaID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.detail_diatitle = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.detail_extensivestay = new System.Windows.Forms.CheckBox();
            this.btnsavenewrecord = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.diag_datagrid)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // diag_datagrid
            // 
            this.diag_datagrid.AllowUserToAddRows = false;
            this.diag_datagrid.AllowUserToDeleteRows = false;
            this.diag_datagrid.AllowUserToResizeColumns = false;
            this.diag_datagrid.AllowUserToResizeRows = false;
            this.diag_datagrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.diag_datagrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_dia_ID,
            this.col_dr_ID,
            this.col_paID,
            this.col_paFirstName,
            this.col_paLastName,
            this.col_dia_Subject,
            this.Treatmentdiscription,
            this.DiagnosisTitle,
            this.AllergicHistory,
            this.col_date,
            this.PatientHeight,
            this.PatientWeight,
            this.Bloodtype,
            this.BloodPressure,
            this.BodyTemp,
            this.DrFirstname,
            this.Drlastname,
            this.ExtensiveStay,
            this.MedicationName,
            this.MedicationPrice,
            this.Consultationfee,
            this.DiagnosisCost});
            this.diag_datagrid.Location = new System.Drawing.Point(6, 12);
            this.diag_datagrid.MultiSelect = false;
            this.diag_datagrid.Name = "diag_datagrid";
            this.diag_datagrid.Size = new System.Drawing.Size(716, 189);
            this.diag_datagrid.TabIndex = 0;
            this.diag_datagrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.diag_datagrid_CellClick);
            // 
            // col_dia_ID
            // 
            this.col_dia_ID.HeaderText = "Diagnosis ID";
            this.col_dia_ID.Name = "col_dia_ID";
            this.col_dia_ID.Width = 130;
            // 
            // col_dr_ID
            // 
            this.col_dr_ID.HeaderText = "Doctor ID";
            this.col_dr_ID.Name = "col_dr_ID";
            this.col_dr_ID.Width = 120;
            // 
            // col_paID
            // 
            this.col_paID.HeaderText = "Patient ID";
            this.col_paID.Name = "col_paID";
            this.col_paID.Width = 120;
            // 
            // col_paFirstName
            // 
            this.col_paFirstName.HeaderText = "Patient First Name";
            this.col_paFirstName.Name = "col_paFirstName";
            this.col_paFirstName.Width = 180;
            // 
            // col_paLastName
            // 
            this.col_paLastName.HeaderText = "Patient Last Name";
            this.col_paLastName.Name = "col_paLastName";
            this.col_paLastName.Width = 180;
            // 
            // col_dia_Subject
            // 
            this.col_dia_Subject.HeaderText = "Subject";
            this.col_dia_Subject.Name = "col_dia_Subject";
            this.col_dia_Subject.Width = 180;
            // 
            // Treatmentdiscription
            // 
            this.Treatmentdiscription.HeaderText = "Treatmentdiscription";
            this.Treatmentdiscription.Name = "Treatmentdiscription";
            this.Treatmentdiscription.Visible = false;
            // 
            // DiagnosisTitle
            // 
            this.DiagnosisTitle.HeaderText = "DiagnosisTitle";
            this.DiagnosisTitle.Name = "DiagnosisTitle";
            this.DiagnosisTitle.Visible = false;
            // 
            // AllergicHistory
            // 
            this.AllergicHistory.HeaderText = "AllergicHistory";
            this.AllergicHistory.Name = "AllergicHistory";
            this.AllergicHistory.Visible = false;
            // 
            // col_date
            // 
            this.col_date.FillWeight = 70F;
            this.col_date.HeaderText = "Date";
            this.col_date.Name = "col_date";
            this.col_date.Visible = false;
            this.col_date.Width = 70;
            // 
            // PatientHeight
            // 
            this.PatientHeight.HeaderText = "PatientHeight";
            this.PatientHeight.Name = "PatientHeight";
            this.PatientHeight.Visible = false;
            // 
            // PatientWeight
            // 
            this.PatientWeight.HeaderText = "PatientWeight";
            this.PatientWeight.Name = "PatientWeight";
            this.PatientWeight.Visible = false;
            // 
            // Bloodtype
            // 
            this.Bloodtype.HeaderText = "Bloodtype";
            this.Bloodtype.Name = "Bloodtype";
            this.Bloodtype.Visible = false;
            // 
            // BloodPressure
            // 
            this.BloodPressure.HeaderText = "BloodPressure";
            this.BloodPressure.Name = "BloodPressure";
            this.BloodPressure.Visible = false;
            // 
            // BodyTemp
            // 
            this.BodyTemp.HeaderText = "BodyTemp";
            this.BodyTemp.Name = "BodyTemp";
            this.BodyTemp.Visible = false;
            // 
            // DrFirstname
            // 
            this.DrFirstname.HeaderText = "DrFirstname";
            this.DrFirstname.Name = "DrFirstname";
            this.DrFirstname.Visible = false;
            // 
            // Drlastname
            // 
            this.Drlastname.HeaderText = "Drlastname";
            this.Drlastname.Name = "Drlastname";
            this.Drlastname.Visible = false;
            // 
            // ExtensiveStay
            // 
            this.ExtensiveStay.HeaderText = "Extensive Stay";
            this.ExtensiveStay.Name = "ExtensiveStay";
            this.ExtensiveStay.Visible = false;
            // 
            // MedicationName
            // 
            this.MedicationName.HeaderText = "Medication Name";
            this.MedicationName.Name = "MedicationName";
            this.MedicationName.Visible = false;
            // 
            // MedicationPrice
            // 
            this.MedicationPrice.HeaderText = "Medication Price";
            this.MedicationPrice.Name = "MedicationPrice";
            this.MedicationPrice.Visible = false;
            // 
            // Consultationfee
            // 
            this.Consultationfee.HeaderText = "Consultation Fee";
            this.Consultationfee.Name = "Consultationfee";
            this.Consultationfee.Visible = false;
            // 
            // DiagnosisCost
            // 
            this.DiagnosisCost.HeaderText = "Diagnosis Cost";
            this.DiagnosisCost.Name = "DiagnosisCost";
            this.DiagnosisCost.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 338);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Record Details:";
            // 
            // detail_paID
            // 
            this.detail_paID.Location = new System.Drawing.Point(111, 361);
            this.detail_paID.Name = "detail_paID";
            this.detail_paID.ReadOnly = true;
            this.detail_paID.Size = new System.Drawing.Size(166, 20);
            this.detail_paID.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(54, 364);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 14);
            this.label5.TabIndex = 9;
            this.label5.Text = "Patient ID";
            // 
            // detail_paLast
            // 
            this.detail_paLast.Location = new System.Drawing.Point(111, 413);
            this.detail_paLast.Name = "detail_paLast";
            this.detail_paLast.ReadOnly = true;
            this.detail_paLast.Size = new System.Drawing.Size(166, 20);
            this.detail_paLast.TabIndex = 14;
            // 
            // detail_paFirst
            // 
            this.detail_paFirst.Location = new System.Drawing.Point(111, 387);
            this.detail_paFirst.Name = "detail_paFirst";
            this.detail_paFirst.ReadOnly = true;
            this.detail_paFirst.Size = new System.Drawing.Size(166, 20);
            this.detail_paFirst.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 416);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 14);
            this.label6.TabIndex = 12;
            this.label6.Text = "Patient Last Name";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(12, 390);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 14);
            this.label7.TabIndex = 11;
            this.label7.Text = "Patient First Name";
            // 
            // detail_drLast
            // 
            this.detail_drLast.Location = new System.Drawing.Point(111, 624);
            this.detail_drLast.Name = "detail_drLast";
            this.detail_drLast.ReadOnly = true;
            this.detail_drLast.Size = new System.Drawing.Size(166, 20);
            this.detail_drLast.TabIndex = 21;
            // 
            // detail_drFirst
            // 
            this.detail_drFirst.Location = new System.Drawing.Point(111, 598);
            this.detail_drFirst.Name = "detail_drFirst";
            this.detail_drFirst.ReadOnly = true;
            this.detail_drFirst.Size = new System.Drawing.Size(166, 20);
            this.detail_drFirst.TabIndex = 20;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(12, 627);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(93, 14);
            this.label9.TabIndex = 19;
            this.label9.Text = "Doctor Last Name";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(12, 601);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(93, 14);
            this.label10.TabIndex = 18;
            this.label10.Text = "Doctor First Name";
            // 
            // detail_drID
            // 
            this.detail_drID.Location = new System.Drawing.Point(111, 572);
            this.detail_drID.Name = "detail_drID";
            this.detail_drID.ReadOnly = true;
            this.detail_drID.Size = new System.Drawing.Size(166, 20);
            this.detail_drID.TabIndex = 17;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(54, 575);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(51, 14);
            this.label11.TabIndex = 16;
            this.label11.Text = "Doctor ID";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(346, 417);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(80, 14);
            this.label12.TabIndex = 25;
            this.label12.Text = "Allergic History\r\n";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(314, 443);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(112, 14);
            this.label13.TabIndex = 24;
            this.label13.Text = "Treatment Description\r\n";
            // 
            // detail_Subject
            // 
            this.detail_Subject.Location = new System.Drawing.Point(432, 388);
            this.detail_Subject.Name = "detail_Subject";
            this.detail_Subject.Size = new System.Drawing.Size(292, 20);
            this.detail_Subject.TabIndex = 23;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(333, 387);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(93, 14);
            this.label14.TabIndex = 22;
            this.label14.Text = "Daignosis Subject";
            // 
            // detail_tretDesc
            // 
            this.detail_tretDesc.Location = new System.Drawing.Point(431, 442);
            this.detail_tretDesc.Name = "detail_tretDesc";
            this.detail_tretDesc.Size = new System.Drawing.Size(292, 92);
            this.detail_tretDesc.TabIndex = 26;
            this.detail_tretDesc.Text = "";
            // 
            // detail_allergicHist
            // 
            this.detail_allergicHist.Location = new System.Drawing.Point(431, 413);
            this.detail_allergicHist.Name = "detail_allergicHist";
            this.detail_allergicHist.Size = new System.Drawing.Size(292, 20);
            this.detail_allergicHist.TabIndex = 27;
            // 
            // detail_bloodType
            // 
            this.detail_bloodType.Location = new System.Drawing.Point(111, 491);
            this.detail_bloodType.Name = "detail_bloodType";
            this.detail_bloodType.Size = new System.Drawing.Size(166, 20);
            this.detail_bloodType.TabIndex = 33;
            // 
            // detail_weight
            // 
            this.detail_weight.Location = new System.Drawing.Point(111, 465);
            this.detail_weight.Name = "detail_weight";
            this.detail_weight.Size = new System.Drawing.Size(166, 20);
            this.detail_weight.TabIndex = 32;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(45, 494);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(60, 14);
            this.label15.TabIndex = 31;
            this.label15.Text = "Blood Type";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(65, 468);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(40, 14);
            this.label16.TabIndex = 30;
            this.label16.Text = "Weight";
            // 
            // detail_height
            // 
            this.detail_height.Location = new System.Drawing.Point(111, 439);
            this.detail_height.Name = "detail_height";
            this.detail_height.Size = new System.Drawing.Size(166, 20);
            this.detail_height.TabIndex = 29;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(68, 442);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(37, 14);
            this.label17.TabIndex = 28;
            this.label17.Text = "Height";
            // 
            // detail_bloodPressure
            // 
            this.detail_bloodPressure.Location = new System.Drawing.Point(111, 517);
            this.detail_bloodPressure.Name = "detail_bloodPressure";
            this.detail_bloodPressure.Size = new System.Drawing.Size(166, 20);
            this.detail_bloodPressure.TabIndex = 35;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(24, 520);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(81, 14);
            this.label18.TabIndex = 34;
            this.label18.Text = "Blood Pressure";
            // 
            // detail_bodyTemp
            // 
            this.detail_bodyTemp.Location = new System.Drawing.Point(111, 543);
            this.detail_bodyTemp.Name = "detail_bodyTemp";
            this.detail_bodyTemp.Size = new System.Drawing.Size(166, 20);
            this.detail_bodyTemp.TabIndex = 37;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(16, 546);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(89, 14);
            this.label19.TabIndex = 36;
            this.label19.Text = "Body Temperture";
            // 
            // diagnosisdate
            // 
            this.diagnosisdate.Location = new System.Drawing.Point(111, 651);
            this.diagnosisdate.Name = "diagnosisdate";
            this.diagnosisdate.ReadOnly = true;
            this.diagnosisdate.Size = new System.Drawing.Size(166, 20);
            this.diagnosisdate.TabIndex = 39;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(76, 653);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(29, 14);
            this.label20.TabIndex = 38;
            this.label20.Text = "Date";
            // 
            // btnCleardiagnosis
            // 
            this.btnCleardiagnosis.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCleardiagnosis.Location = new System.Drawing.Point(155, 702);
            this.btnCleardiagnosis.Name = "btnCleardiagnosis";
            this.btnCleardiagnosis.Size = new System.Drawing.Size(132, 75);
            this.btnCleardiagnosis.TabIndex = 40;
            this.btnCleardiagnosis.Text = "Clear";
            this.btnCleardiagnosis.UseVisualStyleBackColor = true;
            this.btnCleardiagnosis.Click += new System.EventHandler(this.btnCleardiagnosis_Click);
            // 
            // detail_diaID
            // 
            this.detail_diaID.Location = new System.Drawing.Point(432, 334);
            this.detail_diaID.Name = "detail_diaID";
            this.detail_diaID.ReadOnly = true;
            this.detail_diaID.Size = new System.Drawing.Size(292, 20);
            this.detail_diaID.TabIndex = 42;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(361, 338);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(66, 14);
            this.label21.TabIndex = 41;
            this.label21.Text = "Diagnosis ID";
            // 
            // btnAddNew
            // 
            this.btnAddNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddNew.Location = new System.Drawing.Point(293, 702);
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.Size = new System.Drawing.Size(132, 75);
            this.btnAddNew.TabIndex = 43;
            this.btnAddNew.Text = "Add New Record";
            this.btnAddNew.UseVisualStyleBackColor = true;
            this.btnAddNew.Click += new System.EventHandler(this.btnAddNew_Click);
            // 
            // btnUpdatediagnosis
            // 
            this.btnUpdatediagnosis.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdatediagnosis.Location = new System.Drawing.Point(17, 702);
            this.btnUpdatediagnosis.Name = "btnUpdatediagnosis";
            this.btnUpdatediagnosis.Size = new System.Drawing.Size(132, 75);
            this.btnUpdatediagnosis.TabIndex = 44;
            this.btnUpdatediagnosis.Text = "Update";
            this.btnUpdatediagnosis.UseVisualStyleBackColor = true;
            this.btnUpdatediagnosis.Click += new System.EventHandler(this.btnUpdatediagnosis_Click);
            // 
            // txtMedicationNames
            // 
            this.txtMedicationNames.Enabled = false;
            this.txtMedicationNames.Location = new System.Drawing.Point(431, 575);
            this.txtMedicationNames.Name = "txtMedicationNames";
            this.txtMedicationNames.Size = new System.Drawing.Size(219, 20);
            this.txtMedicationNames.TabIndex = 48;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(338, 575);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(88, 14);
            this.label22.TabIndex = 47;
            this.label22.Text = "Medication Name";
            // 
            // txtMedicationCost
            // 
            this.txtMedicationCost.Enabled = false;
            this.txtMedicationCost.Location = new System.Drawing.Point(431, 601);
            this.txtMedicationCost.Name = "txtMedicationCost";
            this.txtMedicationCost.Size = new System.Drawing.Size(219, 20);
            this.txtMedicationCost.TabIndex = 46;
            this.txtMedicationCost.Text = "0.00";
            this.txtMedicationCost.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.Location = new System.Drawing.Point(340, 605);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(86, 14);
            this.label23.TabIndex = 45;
            this.label23.Text = "Medication Cost:";
            // 
            // txtConsultationFee
            // 
            this.txtConsultationFee.Location = new System.Drawing.Point(431, 627);
            this.txtConsultationFee.Name = "txtConsultationFee";
            this.txtConsultationFee.Size = new System.Drawing.Size(219, 20);
            this.txtConsultationFee.TabIndex = 52;
            this.txtConsultationFee.Text = "0.00";
            this.txtConsultationFee.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtConsultationFee.TextChanged += new System.EventHandler(this.txtConsultationFee_TextChanged);
            // 
            // lblConsultationFee
            // 
            this.lblConsultationFee.AutoSize = true;
            this.lblConsultationFee.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConsultationFee.Location = new System.Drawing.Point(339, 631);
            this.lblConsultationFee.Name = "lblConsultationFee";
            this.lblConsultationFee.Size = new System.Drawing.Size(87, 14);
            this.lblConsultationFee.TabIndex = 51;
            this.lblConsultationFee.Text = "Consultation Fee";
            // 
            // txtTotalDiagcost
            // 
            this.txtTotalDiagcost.Location = new System.Drawing.Point(431, 653);
            this.txtTotalDiagcost.Name = "txtTotalDiagcost";
            this.txtTotalDiagcost.Size = new System.Drawing.Size(219, 20);
            this.txtTotalDiagcost.TabIndex = 50;
            this.txtTotalDiagcost.Text = "0.00";
            this.txtTotalDiagcost.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtTotalDiagcost.MouseClick += new System.Windows.Forms.MouseEventHandler(this.calctotalcost);
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.Location = new System.Drawing.Point(369, 657);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(57, 14);
            this.label25.TabIndex = 49;
            this.label25.Text = "Total Cost:";
            // 
            // btnMedicationLookup
            // 
            this.btnMedicationLookup.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMedicationLookup.Location = new System.Drawing.Point(656, 575);
            this.btnMedicationLookup.Name = "btnMedicationLookup";
            this.btnMedicationLookup.Size = new System.Drawing.Size(67, 20);
            this.btnMedicationLookup.TabIndex = 54;
            this.btnMedicationLookup.Text = "•••";
            this.btnMedicationLookup.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnMedicationLookup.UseVisualStyleBackColor = true;
            this.btnMedicationLookup.Click += new System.EventHandler(this.btnMedicationLookup_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnDiaSrc);
            this.groupBox1.Controls.Add(this.txtPaLast);
            this.groupBox1.Controls.Add(this.txtPaFirst);
            this.groupBox1.Controls.Add(this.txtPaID);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 216);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(711, 107);
            this.groupBox1.TabIndex = 55;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search Records:";
            // 
            // btnDiaSrc
            // 
            this.btnDiaSrc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDiaSrc.Location = new System.Drawing.Point(436, 20);
            this.btnDiaSrc.Name = "btnDiaSrc";
            this.btnDiaSrc.Size = new System.Drawing.Size(249, 75);
            this.btnDiaSrc.TabIndex = 14;
            this.btnDiaSrc.Text = "Search";
            this.btnDiaSrc.UseVisualStyleBackColor = true;
            this.btnDiaSrc.Click += new System.EventHandler(this.btnDiaSrc_Click);
            // 
            // txtPaLast
            // 
            this.txtPaLast.Location = new System.Drawing.Point(120, 75);
            this.txtPaLast.Name = "txtPaLast";
            this.txtPaLast.Size = new System.Drawing.Size(248, 21);
            this.txtPaLast.TabIndex = 13;
            // 
            // txtPaFirst
            // 
            this.txtPaFirst.Location = new System.Drawing.Point(120, 46);
            this.txtPaFirst.Name = "txtPaFirst";
            this.txtPaFirst.Size = new System.Drawing.Size(248, 21);
            this.txtPaFirst.TabIndex = 12;
            // 
            // txtPaID
            // 
            this.txtPaID.Location = new System.Drawing.Point(120, 20);
            this.txtPaID.Name = "txtPaID";
            this.txtPaID.Size = new System.Drawing.Size(248, 21);
            this.txtPaID.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(21, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 14);
            this.label3.TabIndex = 10;
            this.label3.Text = "Patient Last Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(21, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 14);
            this.label2.TabIndex = 9;
            this.label2.Text = "Patient First Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 14);
            this.label1.TabIndex = 8;
            this.label1.Text = "Patient ID";
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(591, 702);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(132, 75);
            this.btnExit.TabIndex = 56;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // detail_diatitle
            // 
            this.detail_diatitle.Location = new System.Drawing.Point(432, 358);
            this.detail_diatitle.Name = "detail_diatitle";
            this.detail_diatitle.Size = new System.Drawing.Size(292, 20);
            this.detail_diatitle.TabIndex = 57;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(351, 364);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 14);
            this.label8.TabIndex = 58;
            this.label8.Text = "Diagnosis Title";
            // 
            // detail_extensivestay
            // 
            this.detail_extensivestay.AutoSize = true;
            this.detail_extensivestay.Location = new System.Drawing.Point(432, 546);
            this.detail_extensivestay.Margin = new System.Windows.Forms.Padding(2);
            this.detail_extensivestay.Name = "detail_extensivestay";
            this.detail_extensivestay.Size = new System.Drawing.Size(96, 17);
            this.detail_extensivestay.TabIndex = 59;
            this.detail_extensivestay.Text = "Extensive Stay";
            this.detail_extensivestay.UseVisualStyleBackColor = true;
            // 
            // btnsavenewrecord
            // 
            this.btnsavenewrecord.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsavenewrecord.Location = new System.Drawing.Point(432, 702);
            this.btnsavenewrecord.Name = "btnsavenewrecord";
            this.btnsavenewrecord.Size = new System.Drawing.Size(132, 75);
            this.btnsavenewrecord.TabIndex = 60;
            this.btnsavenewrecord.Text = "Save New Record";
            this.btnsavenewrecord.UseVisualStyleBackColor = true;
            this.btnsavenewrecord.Visible = false;
            this.btnsavenewrecord.Click += new System.EventHandler(this.Savenewrecord_Click);
            // 
            // frmDiagnosis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(751, 789);
            this.Controls.Add(this.btnsavenewrecord);
            this.Controls.Add(this.detail_extensivestay);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.detail_diatitle);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnMedicationLookup);
            this.Controls.Add(this.txtConsultationFee);
            this.Controls.Add(this.lblConsultationFee);
            this.Controls.Add(this.txtTotalDiagcost);
            this.Controls.Add(this.label25);
            this.Controls.Add(this.txtMedicationNames);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.txtMedicationCost);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.btnUpdatediagnosis);
            this.Controls.Add(this.btnAddNew);
            this.Controls.Add(this.detail_diaID);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.btnCleardiagnosis);
            this.Controls.Add(this.diagnosisdate);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.detail_bodyTemp);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.detail_bloodPressure);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.detail_bloodType);
            this.Controls.Add(this.detail_weight);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.detail_height);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.detail_allergicHist);
            this.Controls.Add(this.detail_tretDesc);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.detail_Subject);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.detail_drLast);
            this.Controls.Add(this.detail_drFirst);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.detail_drID);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.detail_paLast);
            this.Controls.Add(this.detail_paFirst);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.detail_paID);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.diag_datagrid);
            this.Name = "frmDiagnosis";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Diagnosis";
            this.Load += new System.EventHandler(this.frmDiagnosis_Load);
            ((System.ComponentModel.ISupportInitialize)(this.diag_datagrid)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView diag_datagrid;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox detail_paID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox detail_paLast;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox detail_drLast;
        private System.Windows.Forms.TextBox detail_drFirst;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox detail_drID;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox detail_Subject;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.RichTextBox detail_tretDesc;
        private System.Windows.Forms.TextBox detail_allergicHist;
        private System.Windows.Forms.TextBox detail_bloodType;
        private System.Windows.Forms.TextBox detail_weight;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox detail_height;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox detail_bloodPressure;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox detail_bodyTemp;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox diagnosisdate;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Button btnCleardiagnosis;
        private System.Windows.Forms.TextBox detail_diaID;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Button btnAddNew;
        private System.Windows.Forms.Button btnUpdatediagnosis;
        private System.Windows.Forms.TextBox txtMedicationNames;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox txtMedicationCost;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.TextBox txtConsultationFee;
        private System.Windows.Forms.Label lblConsultationFee;
        private System.Windows.Forms.TextBox txtTotalDiagcost;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Button btnMedicationLookup;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnDiaSrc;
        private System.Windows.Forms.TextBox txtPaLast;
        private System.Windows.Forms.TextBox txtPaFirst;
        private System.Windows.Forms.TextBox txtPaID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.TextBox detail_diatitle;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckBox detail_extensivestay;
        private System.Windows.Forms.TextBox detail_paFirst;
        private System.Windows.Forms.Button btnsavenewrecord;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_dia_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_dr_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_paID;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_paFirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_paLastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_dia_Subject;
        private System.Windows.Forms.DataGridViewTextBoxColumn Treatmentdiscription;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiagnosisTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn AllergicHistory;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_date;
        private System.Windows.Forms.DataGridViewTextBoxColumn PatientHeight;
        private System.Windows.Forms.DataGridViewTextBoxColumn PatientWeight;
        private System.Windows.Forms.DataGridViewTextBoxColumn Bloodtype;
        private System.Windows.Forms.DataGridViewTextBoxColumn BloodPressure;
        private System.Windows.Forms.DataGridViewTextBoxColumn BodyTemp;
        private System.Windows.Forms.DataGridViewTextBoxColumn DrFirstname;
        private System.Windows.Forms.DataGridViewTextBoxColumn Drlastname;
        private System.Windows.Forms.DataGridViewTextBoxColumn ExtensiveStay;
        private System.Windows.Forms.DataGridViewTextBoxColumn MedicationName;
        private System.Windows.Forms.DataGridViewTextBoxColumn MedicationPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn Consultationfee;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiagnosisCost;
    }
}