namespace PrecentationLayer.Lib
{
    partial class ctrlPersonInfo
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
            this.IPhone = new PrecentationLayer.ctrlLabelInfo();
            this.IDateOfBirht = new PrecentationLayer.ctrlLabelInfo();
            this.IIdType = new PrecentationLayer.ctrlLabelInfo();
            this.IIdNum = new PrecentationLayer.ctrlLabelInfo();
            this.IEmail = new PrecentationLayer.ctrlLabelInfo();
            this.ILastName = new PrecentationLayer.ctrlLabelInfo();
            this.IFirstName = new PrecentationLayer.ctrlLabelInfo();
            this.IPersonID = new PrecentationLayer.ctrlLabelInfo();
            this.btnUpdate = new PrecentationLayer.PrimaryButton();
            this.SuspendLayout();
            // 
            // IPhone
            // 
            this.IPhone.Details = "Details";
            this.IPhone.Info = "Phone";
            this.IPhone.Location = new System.Drawing.Point(3, 179);
            this.IPhone.Name = "IPhone";
            this.IPhone.Size = new System.Drawing.Size(334, 28);
            this.IPhone.TabIndex = 7;
            // 
            // IDateOfBirht
            // 
            this.IDateOfBirht.Details = "Details";
            this.IDateOfBirht.Info = "Date of birth";
            this.IDateOfBirht.Location = new System.Drawing.Point(387, 139);
            this.IDateOfBirht.Name = "IDateOfBirht";
            this.IDateOfBirht.Size = new System.Drawing.Size(334, 52);
            this.IDateOfBirht.TabIndex = 6;
            // 
            // IIdType
            // 
            this.IIdType.Details = "Details";
            this.IIdType.Info = "Identification Type";
            this.IIdType.Location = new System.Drawing.Point(387, 71);
            this.IIdType.Name = "IIdType";
            this.IIdType.Size = new System.Drawing.Size(334, 52);
            this.IIdType.TabIndex = 5;
            // 
            // IIdNum
            // 
            this.IIdNum.Details = "Details";
            this.IIdNum.Info = "IdentificationNum";
            this.IIdNum.Location = new System.Drawing.Point(387, 3);
            this.IIdNum.Name = "IIdNum";
            this.IIdNum.Size = new System.Drawing.Size(334, 52);
            this.IIdNum.TabIndex = 4;
            // 
            // IEmail
            // 
            this.IEmail.Details = "Details";
            this.IEmail.Info = "Email";
            this.IEmail.Location = new System.Drawing.Point(3, 135);
            this.IEmail.Name = "IEmail";
            this.IEmail.Size = new System.Drawing.Size(334, 28);
            this.IEmail.TabIndex = 3;
            // 
            // ILastName
            // 
            this.ILastName.Details = "Details";
            this.ILastName.Info = "Last Name";
            this.ILastName.Location = new System.Drawing.Point(3, 91);
            this.ILastName.Name = "ILastName";
            this.ILastName.Size = new System.Drawing.Size(334, 28);
            this.ILastName.TabIndex = 2;
            // 
            // IFirstName
            // 
            this.IFirstName.Details = "Details";
            this.IFirstName.Info = "First Name";
            this.IFirstName.Location = new System.Drawing.Point(3, 47);
            this.IFirstName.Name = "IFirstName";
            this.IFirstName.Size = new System.Drawing.Size(334, 28);
            this.IFirstName.TabIndex = 1;
            // 
            // IPersonID
            // 
            this.IPersonID.Details = "Details";
            this.IPersonID.Info = "PersonID";
            this.IPersonID.Location = new System.Drawing.Point(3, 3);
            this.IPersonID.Name = "IPersonID";
            this.IPersonID.Size = new System.Drawing.Size(334, 28);
            this.IPersonID.TabIndex = 0;
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnUpdate.ForeColor = System.Drawing.Color.Black;
            this.btnUpdate.Location = new System.Drawing.Point(637, 196);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(140, 52);
            this.btnUpdate.TabIndex = 8;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // ctrlPersonInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.IPhone);
            this.Controls.Add(this.IDateOfBirht);
            this.Controls.Add(this.IIdType);
            this.Controls.Add(this.IIdNum);
            this.Controls.Add(this.IEmail);
            this.Controls.Add(this.ILastName);
            this.Controls.Add(this.IFirstName);
            this.Controls.Add(this.IPersonID);
            this.Name = "ctrlPersonInfo";
            this.Size = new System.Drawing.Size(780, 251);
            this.ResumeLayout(false);

        }

        #endregion

        private ctrlLabelInfo IPersonID;
        private ctrlLabelInfo IFirstName;
        private ctrlLabelInfo ILastName;
        private ctrlLabelInfo IEmail;
        private ctrlLabelInfo IIdNum;
        private ctrlLabelInfo IIdType;
        private ctrlLabelInfo IDateOfBirht;
        private ctrlLabelInfo IPhone;
        private PrimaryButton btnUpdate;
    }
}
