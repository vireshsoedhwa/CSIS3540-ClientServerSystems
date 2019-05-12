namespace Medication
{
    partial class frmMedication
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
            this.med_Cost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.med_Prescribed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.med_Dosage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.med_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.med_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.med_StockLevel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtCost = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtStockLevel = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDosage = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.MedicationdataGridView = new System.Windows.Forms.DataGridView();
            this.txtID = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lstResult = new System.Windows.Forms.ListBox();
            this.grpboxGB = new System.Windows.Forms.GroupBox();
            this.rbtnPFalse = new System.Windows.Forms.RadioButton();
            this.rbtnPTrue = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.MedicationdataGridView)).BeginInit();
            this.grpboxGB.SuspendLayout();
            this.SuspendLayout();
            // 
            // med_Cost
            // 
            this.med_Cost.HeaderText = "Cost";
            this.med_Cost.Name = "med_Cost";
            // 
            // med_Prescribed
            // 
            this.med_Prescribed.HeaderText = "Prescribed";
            this.med_Prescribed.Name = "med_Prescribed";
            // 
            // med_Dosage
            // 
            this.med_Dosage.HeaderText = "Dosage";
            this.med_Dosage.Name = "med_Dosage";
            // 
            // med_Name
            // 
            this.med_Name.HeaderText = "Medication Name";
            this.med_Name.Name = "med_Name";
            // 
            // med_ID
            // 
            this.med_ID.HeaderText = "Medication ID";
            this.med_ID.Name = "med_ID";
            // 
            // med_StockLevel
            // 
            this.med_StockLevel.HeaderText = "Stock Level";
            this.med_StockLevel.Name = "med_StockLevel";
            // 
            // txtCost
            // 
            this.txtCost.Location = new System.Drawing.Point(294, 317);
            this.txtCost.Name = "txtCost";
            this.txtCost.Size = new System.Drawing.Size(100, 20);
            this.txtCost.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(224, 320);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(28, 13);
            this.label7.TabIndex = 46;
            this.label7.Text = "Cost";
            // 
            // txtStockLevel
            // 
            this.txtStockLevel.Location = new System.Drawing.Point(294, 291);
            this.txtStockLevel.Name = "txtStockLevel";
            this.txtStockLevel.Size = new System.Drawing.Size(100, 20);
            this.txtStockLevel.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(224, 294);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 13);
            this.label6.TabIndex = 47;
            this.label6.Text = "Stock Level";
            // 
            // txtDosage
            // 
            this.txtDosage.Location = new System.Drawing.Point(107, 343);
            this.txtDosage.Name = "txtDosage";
            this.txtDosage.Size = new System.Drawing.Size(100, 20);
            this.txtDosage.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 346);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 45;
            this.label3.Text = "Dosage";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(107, 317);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 20);
            this.txtName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 320);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 13);
            this.label2.TabIndex = 44;
            this.label2.Text = "Medication Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 294);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 43;
            this.label1.Text = "Medication ID";
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(502, 385);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 9;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(369, 385);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 8;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(227, 385);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 7;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // MedicationdataGridView
            // 
            this.MedicationdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MedicationdataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.med_ID,
            this.med_Name,
            this.med_Dosage,
            this.med_Prescribed,
            this.med_StockLevel,
            this.med_Cost});
            this.MedicationdataGridView.Location = new System.Drawing.Point(12, 12);
            this.MedicationdataGridView.Name = "MedicationdataGridView";
            this.MedicationdataGridView.Size = new System.Drawing.Size(645, 259);
            this.MedicationdataGridView.TabIndex = 10;
            this.MedicationdataGridView.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.MedicationdataGridView_RowHeaderMouseDoubleClick);
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(107, 291);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(100, 20);
            this.txtID.TabIndex = 0;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(84, 385);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 6;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // lstResult
            // 
            this.lstResult.FormattingEnabled = true;
            this.lstResult.Location = new System.Drawing.Point(502, 291);
            this.lstResult.Name = "lstResult";
            this.lstResult.Size = new System.Drawing.Size(155, 69);
            this.lstResult.TabIndex = 60;
            // 
            // grpboxGB
            // 
            this.grpboxGB.Controls.Add(this.rbtnPFalse);
            this.grpboxGB.Controls.Add(this.rbtnPTrue);
            this.grpboxGB.Location = new System.Drawing.Point(413, 291);
            this.grpboxGB.Name = "grpboxGB";
            this.grpboxGB.Size = new System.Drawing.Size(71, 72);
            this.grpboxGB.TabIndex = 61;
            this.grpboxGB.TabStop = false;
            this.grpboxGB.Text = "Prescribed";
            // 
            // rbtnPFalse
            // 
            this.rbtnPFalse.AutoSize = true;
            this.rbtnPFalse.Location = new System.Drawing.Point(6, 42);
            this.rbtnPFalse.Name = "rbtnPFalse";
            this.rbtnPFalse.Size = new System.Drawing.Size(50, 17);
            this.rbtnPFalse.TabIndex = 17;
            this.rbtnPFalse.TabStop = true;
            this.rbtnPFalse.Text = "False";
            this.rbtnPFalse.UseVisualStyleBackColor = true;
            // 
            // rbtnPTrue
            // 
            this.rbtnPTrue.AutoSize = true;
            this.rbtnPTrue.Location = new System.Drawing.Point(6, 19);
            this.rbtnPTrue.Name = "rbtnPTrue";
            this.rbtnPTrue.Size = new System.Drawing.Size(47, 17);
            this.rbtnPTrue.TabIndex = 16;
            this.rbtnPTrue.TabStop = true;
            this.rbtnPTrue.Text = "True";
            this.rbtnPTrue.UseVisualStyleBackColor = true;
            // 
            // Medication
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(670, 429);
            this.Controls.Add(this.grpboxGB);
            this.Controls.Add(this.lstResult);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtCost);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtStockLevel);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtDosage);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.MedicationdataGridView);
            this.Controls.Add(this.txtID);
            this.Name = "Medication";
            this.Text = "Medication";
            this.Load += new System.EventHandler(this.Medication_Load);
            ((System.ComponentModel.ISupportInitialize)(this.MedicationdataGridView)).EndInit();
            this.grpboxGB.ResumeLayout(false);
            this.grpboxGB.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridViewTextBoxColumn med_Cost;
        private System.Windows.Forms.DataGridViewTextBoxColumn med_Prescribed;
        private System.Windows.Forms.DataGridViewTextBoxColumn med_Dosage;
        private System.Windows.Forms.DataGridViewTextBoxColumn med_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn med_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn med_StockLevel;
        private System.Windows.Forms.TextBox txtCost;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtStockLevel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtDosage;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridView MedicationdataGridView;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.ListBox lstResult;
        private System.Windows.Forms.GroupBox grpboxGB;
        private System.Windows.Forms.RadioButton rbtnPFalse;
        private System.Windows.Forms.RadioButton rbtnPTrue;
    }
}

