namespace PatientRegistration
{
    partial class frmPatientRegistration
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
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.PatientdataGridView = new System.Windows.Forms.DataGridView();
            this.pa_Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pa_FirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pa_LastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pa_Gender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pa_BirthDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pa_PhoneNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pa_Emergency_Contact = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pa_Emergency_ContactNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pa_BloodType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pa_Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pa_Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pa_Ins_Number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pa_Ins_Company = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pa_Nationality = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pa_GovBenefits = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pa_GovBenefitsID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pa_Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpboxGender = new System.Windows.Forms.GroupBox();
            this.rbtnFemale = new System.Windows.Forms.RadioButton();
            this.rbtnMale = new System.Windows.Forms.RadioButton();
            this.txtECN = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtEC = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtLName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtFName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lstResult = new System.Windows.Forms.ListBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtBloodType = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtInsNumber = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtInsCompany = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.txtNationality = new System.Windows.Forms.TextBox();
            this.txtGB_Id = new System.Windows.Forms.TextBox();
            this.grpboxGB = new System.Windows.Forms.GroupBox();
            this.rbtnGBNo = new System.Windows.Forms.RadioButton();
            this.rbtnGBYes = new System.Windows.Forms.RadioButton();
            this.grpboxStatus = new System.Windows.Forms.GroupBox();
            this.rbtnInactive = new System.Windows.Forms.RadioButton();
            this.rbtnActive = new System.Windows.Forms.RadioButton();
            this.btnClear = new System.Windows.Forms.Button();
            this.bdPicker = new System.Windows.Forms.DateTimePicker();
            this.lblStatus = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PatientdataGridView)).BeginInit();
            this.grpboxGender.SuspendLayout();
            this.grpboxGB.SuspendLayout();
            this.grpboxStatus.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(38, 383);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(256, 47);
            this.btnSearch.TabIndex = 20;
            this.btnSearch.Text = "Search ID, FirstName And/Or LastName";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(435, 383);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 47);
            this.btnUpdate.TabIndex = 22;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(354, 383);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 47);
            this.btnAdd.TabIndex = 21;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // PatientdataGridView
            // 
            this.PatientdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PatientdataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.pa_Id,
            this.pa_FirstName,
            this.pa_LastName,
            this.pa_Gender,
            this.pa_BirthDate,
            this.pa_PhoneNumber,
            this.pa_Emergency_Contact,
            this.pa_Emergency_ContactNumber,
            this.pa_BloodType,
            this.pa_Address,
            this.pa_Email,
            this.pa_Ins_Number,
            this.pa_Ins_Company,
            this.pa_Nationality,
            this.pa_GovBenefits,
            this.pa_GovBenefitsID,
            this.pa_Status});
            this.PatientdataGridView.Location = new System.Drawing.Point(12, 12);
            this.PatientdataGridView.Name = "PatientdataGridView";
            this.PatientdataGridView.Size = new System.Drawing.Size(896, 120);
            this.PatientdataGridView.TabIndex = 24;
            this.PatientdataGridView.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.PatientdataGridView_RowHeaderMouseDoubleClick);
            // 
            // pa_Id
            // 
            this.pa_Id.HeaderText = "Patient ID";
            this.pa_Id.Name = "pa_Id";
            // 
            // pa_FirstName
            // 
            this.pa_FirstName.HeaderText = "First Name";
            this.pa_FirstName.Name = "pa_FirstName";
            // 
            // pa_LastName
            // 
            this.pa_LastName.HeaderText = "Last Name";
            this.pa_LastName.Name = "pa_LastName";
            // 
            // pa_Gender
            // 
            this.pa_Gender.HeaderText = "Gender";
            this.pa_Gender.Name = "pa_Gender";
            // 
            // pa_BirthDate
            // 
            this.pa_BirthDate.HeaderText = "BirthDate";
            this.pa_BirthDate.Name = "pa_BirthDate";
            // 
            // pa_PhoneNumber
            // 
            this.pa_PhoneNumber.HeaderText = "Phone Number";
            this.pa_PhoneNumber.Name = "pa_PhoneNumber";
            // 
            // pa_Emergency_Contact
            // 
            this.pa_Emergency_Contact.HeaderText = "Emergency Contact";
            this.pa_Emergency_Contact.Name = "pa_Emergency_Contact";
            // 
            // pa_Emergency_ContactNumber
            // 
            this.pa_Emergency_ContactNumber.HeaderText = "Emergency Contact Number";
            this.pa_Emergency_ContactNumber.Name = "pa_Emergency_ContactNumber";
            // 
            // pa_BloodType
            // 
            this.pa_BloodType.HeaderText = "Blood Type";
            this.pa_BloodType.Name = "pa_BloodType";
            // 
            // pa_Address
            // 
            this.pa_Address.HeaderText = "Address";
            this.pa_Address.Name = "pa_Address";
            // 
            // pa_Email
            // 
            this.pa_Email.HeaderText = "Email";
            this.pa_Email.Name = "pa_Email";
            // 
            // pa_Ins_Number
            // 
            this.pa_Ins_Number.HeaderText = "Insurance Number";
            this.pa_Ins_Number.Name = "pa_Ins_Number";
            // 
            // pa_Ins_Company
            // 
            this.pa_Ins_Company.HeaderText = "Insurance Company";
            this.pa_Ins_Company.Name = "pa_Ins_Company";
            // 
            // pa_Nationality
            // 
            this.pa_Nationality.HeaderText = "Nationality";
            this.pa_Nationality.Name = "pa_Nationality";
            // 
            // pa_GovBenefits
            // 
            this.pa_GovBenefits.HeaderText = "Government Benefits";
            this.pa_GovBenefits.Name = "pa_GovBenefits";
            // 
            // pa_GovBenefitsID
            // 
            this.pa_GovBenefitsID.HeaderText = "Government Benefits ID";
            this.pa_GovBenefitsID.Name = "pa_GovBenefitsID";
            // 
            // pa_Status
            // 
            this.pa_Status.HeaderText = "Status";
            this.pa_Status.Name = "pa_Status";
            // 
            // grpboxGender
            // 
            this.grpboxGender.Controls.Add(this.rbtnFemale);
            this.grpboxGender.Controls.Add(this.rbtnMale);
            this.grpboxGender.Location = new System.Drawing.Point(607, 147);
            this.grpboxGender.Name = "grpboxGender";
            this.grpboxGender.Size = new System.Drawing.Size(134, 68);
            this.grpboxGender.TabIndex = 19;
            this.grpboxGender.TabStop = false;
            this.grpboxGender.Text = "Gender";
            // 
            // rbtnFemale
            // 
            this.rbtnFemale.AutoSize = true;
            this.rbtnFemale.Location = new System.Drawing.Point(34, 42);
            this.rbtnFemale.Name = "rbtnFemale";
            this.rbtnFemale.Size = new System.Drawing.Size(59, 17);
            this.rbtnFemale.TabIndex = 15;
            this.rbtnFemale.TabStop = true;
            this.rbtnFemale.Text = "Female";
            this.rbtnFemale.UseVisualStyleBackColor = true;
            // 
            // rbtnMale
            // 
            this.rbtnMale.AutoSize = true;
            this.rbtnMale.Location = new System.Drawing.Point(34, 19);
            this.rbtnMale.Name = "rbtnMale";
            this.rbtnMale.Size = new System.Drawing.Size(48, 17);
            this.rbtnMale.TabIndex = 14;
            this.rbtnMale.TabStop = true;
            this.rbtnMale.Text = "Male";
            this.rbtnMale.UseVisualStyleBackColor = true;
            // 
            // txtECN
            // 
            this.txtECN.Location = new System.Drawing.Point(181, 303);
            this.txtECN.Name = "txtECN";
            this.txtECN.Size = new System.Drawing.Size(100, 20);
            this.txtECN.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(35, 306);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(140, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "Emergency Contact Number";
            // 
            // txtEC
            // 
            this.txtEC.Location = new System.Drawing.Point(181, 277);
            this.txtEC.Name = "txtEC";
            this.txtEC.Size = new System.Drawing.Size(100, 20);
            this.txtEC.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(34, 280);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Emergency Contact";
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(181, 251);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(100, 20);
            this.txtPhone.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(34, 254);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Phone Number";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(35, 228);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Birthdate";
            // 
            // txtLName
            // 
            this.txtLName.Location = new System.Drawing.Point(181, 199);
            this.txtLName.Name = "txtLName";
            this.txtLName.Size = new System.Drawing.Size(100, 20);
            this.txtLName.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 202);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Last Name";
            // 
            // txtFName
            // 
            this.txtFName.Location = new System.Drawing.Point(181, 173);
            this.txtFName.Name = "txtFName";
            this.txtFName.Size = new System.Drawing.Size(100, 20);
            this.txtFName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 176);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "First Name";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(181, 147);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(100, 20);
            this.txtID.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 150);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Patient ID";
            // 
            // lstResult
            // 
            this.lstResult.FormattingEnabled = true;
            this.lstResult.Location = new System.Drawing.Point(808, 143);
            this.lstResult.Name = "lstResult";
            this.lstResult.Size = new System.Drawing.Size(74, 69);
            this.lstResult.TabIndex = 24;
            this.lstResult.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(309, 150);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 13);
            this.label8.TabIndex = 8;
            this.label8.Text = "Blood Type";
            // 
            // txtBloodType
            // 
            this.txtBloodType.Location = new System.Drawing.Point(435, 147);
            this.txtBloodType.Name = "txtBloodType";
            this.txtBloodType.Size = new System.Drawing.Size(129, 20);
            this.txtBloodType.TabIndex = 7;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(309, 176);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(45, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "Address";
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(435, 173);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(129, 20);
            this.txtAddress.TabIndex = 8;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(309, 202);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(32, 13);
            this.label10.TabIndex = 9;
            this.label10.Text = "Email";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(435, 199);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(129, 20);
            this.txtEmail.TabIndex = 9;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(309, 228);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(94, 13);
            this.label11.TabIndex = 9;
            this.label11.Text = "Insurance Number";
            // 
            // txtInsNumber
            // 
            this.txtInsNumber.Location = new System.Drawing.Point(435, 225);
            this.txtInsNumber.Name = "txtInsNumber";
            this.txtInsNumber.Size = new System.Drawing.Size(129, 20);
            this.txtInsNumber.TabIndex = 10;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(309, 254);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(101, 13);
            this.label12.TabIndex = 9;
            this.label12.Text = "Insurance Company";
            // 
            // txtInsCompany
            // 
            this.txtInsCompany.Location = new System.Drawing.Point(435, 251);
            this.txtInsCompany.Name = "txtInsCompany";
            this.txtInsCompany.Size = new System.Drawing.Size(129, 20);
            this.txtInsCompany.TabIndex = 11;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(309, 280);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(56, 13);
            this.label13.TabIndex = 9;
            this.label13.Text = "Nationality";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(309, 306);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(120, 13);
            this.label14.TabIndex = 9;
            this.label14.Text = "Government Benefits ID";
            // 
            // txtNationality
            // 
            this.txtNationality.Location = new System.Drawing.Point(435, 277);
            this.txtNationality.Name = "txtNationality";
            this.txtNationality.Size = new System.Drawing.Size(129, 20);
            this.txtNationality.TabIndex = 12;
            // 
            // txtGB_Id
            // 
            this.txtGB_Id.Location = new System.Drawing.Point(435, 303);
            this.txtGB_Id.Name = "txtGB_Id";
            this.txtGB_Id.Size = new System.Drawing.Size(129, 20);
            this.txtGB_Id.TabIndex = 13;
            // 
            // grpboxGB
            // 
            this.grpboxGB.Controls.Add(this.rbtnGBNo);
            this.grpboxGB.Controls.Add(this.rbtnGBYes);
            this.grpboxGB.Location = new System.Drawing.Point(607, 221);
            this.grpboxGB.Name = "grpboxGB";
            this.grpboxGB.Size = new System.Drawing.Size(134, 46);
            this.grpboxGB.TabIndex = 19;
            this.grpboxGB.TabStop = false;
            this.grpboxGB.Text = "Government Benefits";
            // 
            // rbtnGBNo
            // 
            this.rbtnGBNo.AutoSize = true;
            this.rbtnGBNo.Location = new System.Drawing.Point(76, 19);
            this.rbtnGBNo.Name = "rbtnGBNo";
            this.rbtnGBNo.Size = new System.Drawing.Size(39, 17);
            this.rbtnGBNo.TabIndex = 17;
            this.rbtnGBNo.TabStop = true;
            this.rbtnGBNo.Text = "No";
            this.rbtnGBNo.UseVisualStyleBackColor = true;
            // 
            // rbtnGBYes
            // 
            this.rbtnGBYes.AutoSize = true;
            this.rbtnGBYes.Location = new System.Drawing.Point(6, 19);
            this.rbtnGBYes.Name = "rbtnGBYes";
            this.rbtnGBYes.Size = new System.Drawing.Size(43, 17);
            this.rbtnGBYes.TabIndex = 16;
            this.rbtnGBYes.TabStop = true;
            this.rbtnGBYes.Text = "Yes";
            this.rbtnGBYes.UseVisualStyleBackColor = true;
            // 
            // grpboxStatus
            // 
            this.grpboxStatus.Controls.Add(this.rbtnInactive);
            this.grpboxStatus.Controls.Add(this.rbtnActive);
            this.grpboxStatus.Location = new System.Drawing.Point(607, 273);
            this.grpboxStatus.Name = "grpboxStatus";
            this.grpboxStatus.Size = new System.Drawing.Size(134, 50);
            this.grpboxStatus.TabIndex = 19;
            this.grpboxStatus.TabStop = false;
            this.grpboxStatus.Text = "Status";
            // 
            // rbtnInactive
            // 
            this.rbtnInactive.AutoSize = true;
            this.rbtnInactive.Location = new System.Drawing.Point(67, 19);
            this.rbtnInactive.Name = "rbtnInactive";
            this.rbtnInactive.Size = new System.Drawing.Size(63, 17);
            this.rbtnInactive.TabIndex = 19;
            this.rbtnInactive.TabStop = true;
            this.rbtnInactive.Text = "Inactive";
            this.rbtnInactive.UseVisualStyleBackColor = true;
            // 
            // rbtnActive
            // 
            this.rbtnActive.AutoSize = true;
            this.rbtnActive.Location = new System.Drawing.Point(6, 19);
            this.rbtnActive.Name = "rbtnActive";
            this.rbtnActive.Size = new System.Drawing.Size(55, 17);
            this.rbtnActive.TabIndex = 18;
            this.rbtnActive.TabStop = true;
            this.rbtnActive.Text = "Active";
            this.rbtnActive.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(525, 383);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 47);
            this.btnClear.TabIndex = 23;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // bdPicker
            // 
            this.bdPicker.CustomFormat = "yyyy/MM/dd";
            this.bdPicker.Location = new System.Drawing.Point(181, 225);
            this.bdPicker.Name = "bdPicker";
            this.bdPicker.Size = new System.Drawing.Size(100, 20);
            this.bdPicker.TabIndex = 3;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblStatus.Location = new System.Drawing.Point(43, 350);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(51, 19);
            this.lblStatus.TabIndex = 25;
            this.lblStatus.Text = "Note:";
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(750, 383);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 47);
            this.btnExit.TabIndex = 26;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // frmPatientRegistration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(921, 454);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.bdPicker);
            this.Controls.Add(this.lstResult);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.PatientdataGridView);
            this.Controls.Add(this.grpboxStatus);
            this.Controls.Add(this.grpboxGB);
            this.Controls.Add(this.grpboxGender);
            this.Controls.Add(this.txtGB_Id);
            this.Controls.Add(this.txtNationality);
            this.Controls.Add(this.txtInsCompany);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtInsNumber);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtECN);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtEC);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtBloodType);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtLName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtFName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.label1);
            this.Name = "frmPatientRegistration";
            this.Text = "Patient Registration";
            this.Load += new System.EventHandler(this.frmPatientRegistration_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PatientdataGridView)).EndInit();
            this.grpboxGender.ResumeLayout(false);
            this.grpboxGender.PerformLayout();
            this.grpboxGB.ResumeLayout(false);
            this.grpboxGB.PerformLayout();
            this.grpboxStatus.ResumeLayout(false);
            this.grpboxStatus.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridView PatientdataGridView;
        private System.Windows.Forms.GroupBox grpboxGender;
        private System.Windows.Forms.RadioButton rbtnFemale;
        private System.Windows.Forms.RadioButton rbtnMale;
        private System.Windows.Forms.TextBox txtECN;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtEC;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtLName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtFName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lstResult;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtBloodType;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtInsNumber;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtInsCompany;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtNationality;
        private System.Windows.Forms.TextBox txtGB_Id;
        private System.Windows.Forms.GroupBox grpboxGB;
        private System.Windows.Forms.RadioButton rbtnGBNo;
        private System.Windows.Forms.RadioButton rbtnGBYes;
        private System.Windows.Forms.GroupBox grpboxStatus;
        private System.Windows.Forms.RadioButton rbtnInactive;
        private System.Windows.Forms.RadioButton rbtnActive;
        private System.Windows.Forms.DataGridViewTextBoxColumn pa_Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn pa_FirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn pa_LastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn pa_Gender;
        private System.Windows.Forms.DataGridViewTextBoxColumn pa_BirthDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn pa_PhoneNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn pa_Emergency_Contact;
        private System.Windows.Forms.DataGridViewTextBoxColumn pa_Emergency_ContactNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn pa_BloodType;
        private System.Windows.Forms.DataGridViewTextBoxColumn pa_Address;
        private System.Windows.Forms.DataGridViewTextBoxColumn pa_Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn pa_Ins_Number;
        private System.Windows.Forms.DataGridViewTextBoxColumn pa_Ins_Company;
        private System.Windows.Forms.DataGridViewTextBoxColumn pa_Nationality;
        private System.Windows.Forms.DataGridViewTextBoxColumn pa_GovBenefits;
        private System.Windows.Forms.DataGridViewTextBoxColumn pa_GovBenefitsID;
        private System.Windows.Forms.DataGridViewTextBoxColumn pa_Status;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.DateTimePicker bdPicker;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Button btnExit;
    }
}

