namespace PrecentationLayer.People
{
    partial class ctrlAddUpdatePersonInfo
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.dtpDateOfBirth = new System.Windows.Forms.DateTimePicker();
            this.cbIdType = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSave = new PrecentationLayer.PrimaryButton();
            this.txtIdNum = new PrecentationLayer.Lib.ctrlTextboxUpdateDetails();
            this.txtPhone = new PrecentationLayer.Lib.ctrlTextboxUpdateDetails();
            this.txtEmail = new PrecentationLayer.Lib.ctrlTextboxUpdateDetails();
            this.InfoPersonID = new PrecentationLayer.ctrlLabelInfo();
            this.txtLastName = new PrecentationLayer.Lib.ctrlTextboxUpdateDetails();
            this.txtFirstName = new PrecentationLayer.Lib.ctrlTextboxUpdateDetails();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 252);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 25);
            this.label1.TabIndex = 9;
            this.label1.Text = "Date of birth:";
            // 
            // dtpDateOfBirth
            // 
            this.dtpDateOfBirth.Location = new System.Drawing.Point(189, 257);
            this.dtpDateOfBirth.Name = "dtpDateOfBirth";
            this.dtpDateOfBirth.Size = new System.Drawing.Size(200, 20);
            this.dtpDateOfBirth.TabIndex = 10;
            // 
            // cbIdType
            // 
            this.cbIdType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbIdType.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbIdType.FormattingEnabled = true;
            this.cbIdType.Location = new System.Drawing.Point(682, 206);
            this.cbIdType.Name = "cbIdType";
            this.cbIdType.Size = new System.Drawing.Size(274, 33);
            this.cbIdType.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(490, 214);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 25);
            this.label2.TabIndex = 12;
            this.label2.Text = "Id Type:";
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.Black;
            this.btnSave.Location = new System.Drawing.Point(360, 332);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(275, 77);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "Save ✅";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtIdNum
            // 
            this.txtIdNum.Details = null;
            this.txtIdNum.Info = "Identification Number";
            this.txtIdNum.Location = new System.Drawing.Point(495, 125);
            this.txtIdNum.Name = "txtIdNum";
            this.txtIdNum.OnlyNumbers = false;
            this.txtIdNum.Size = new System.Drawing.Size(461, 57);
            this.txtIdNum.TabIndex = 5;
            // 
            // txtPhone
            // 
            this.txtPhone.Details = null;
            this.txtPhone.Info = "Phone";
            this.txtPhone.Location = new System.Drawing.Point(495, 68);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.OnlyNumbers = true;
            this.txtPhone.Size = new System.Drawing.Size(461, 38);
            this.txtPhone.TabIndex = 4;
            // 
            // txtEmail
            // 
            this.txtEmail.Details = null;
            this.txtEmail.Info = "Email";
            this.txtEmail.Location = new System.Drawing.Point(0, 189);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.OnlyNumbers = false;
            this.txtEmail.Size = new System.Drawing.Size(461, 38);
            this.txtEmail.TabIndex = 3;
            // 
            // InfoPersonID
            // 
            this.InfoPersonID.Details = "Details";
            this.InfoPersonID.Info = "Person ID";
            this.InfoPersonID.Location = new System.Drawing.Point(360, 3);
            this.InfoPersonID.Name = "InfoPersonID";
            this.InfoPersonID.Size = new System.Drawing.Size(334, 28);
            this.InfoPersonID.TabIndex = 2;
            // 
            // txtLastName
            // 
            this.txtLastName.Details = null;
            this.txtLastName.Info = "Last Name";
            this.txtLastName.Location = new System.Drawing.Point(3, 135);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.OnlyNumbers = false;
            this.txtLastName.Size = new System.Drawing.Size(461, 38);
            this.txtLastName.TabIndex = 1;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Details = null;
            this.txtFirstName.Info = "First Name";
            this.txtFirstName.Location = new System.Drawing.Point(3, 68);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.OnlyNumbers = false;
            this.txtFirstName.Size = new System.Drawing.Size(461, 38);
            this.txtFirstName.TabIndex = 0;
            // 
            // ctrlAddUpdatePersonInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbIdType);
            this.Controls.Add(this.dtpDateOfBirth);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtIdNum);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.InfoPersonID);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.txtFirstName);
            this.Name = "ctrlAddUpdatePersonInfo";
            this.Size = new System.Drawing.Size(999, 412);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Lib.ctrlTextboxUpdateDetails txtFirstName;
        private Lib.ctrlTextboxUpdateDetails txtLastName;
        private ctrlLabelInfo InfoPersonID;
        private Lib.ctrlTextboxUpdateDetails txtEmail;
        private Lib.ctrlTextboxUpdateDetails txtPhone;
        private Lib.ctrlTextboxUpdateDetails txtIdNum;
        private PrimaryButton btnSave;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpDateOfBirth;
        private System.Windows.Forms.ComboBox cbIdType;
        private System.Windows.Forms.Label label2;
    }
}
