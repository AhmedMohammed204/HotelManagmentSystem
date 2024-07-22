namespace PrecentationLayer.Users
{
    partial class ctrlUpdateUser
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
            this.ctrlUserInfo1 = new PrecentationLayer.Lib.ctrlUserInfo();
            this.gbNewData = new System.Windows.Forms.GroupBox();
            this.txtUsername = new PrecentationLayer.Lib.ctrlTextboxUpdateDetails();
            this.txtPassword = new PrecentationLayer.Lib.ctrlTextboxUpdateDetails();
            this.txtConfirmPassword = new PrecentationLayer.Lib.ctrlTextboxUpdateDetails();
            this.btnSave = new PrecentationLayer.PrimaryButton();
            this.gbNewData.SuspendLayout();
            this.SuspendLayout();
            // 
            // ctrlUserInfo1
            // 
            this.ctrlUserInfo1.Dock = System.Windows.Forms.DockStyle.Left;
            this.ctrlUserInfo1.Location = new System.Drawing.Point(0, 0);
            this.ctrlUserInfo1.Name = "ctrlUserInfo1";
            this.ctrlUserInfo1.Size = new System.Drawing.Size(834, 394);
            this.ctrlUserInfo1.TabIndex = 0;
            this.ctrlUserInfo1.UserInfo = null;
            // 
            // gbNewData
            // 
            this.gbNewData.Controls.Add(this.btnSave);
            this.gbNewData.Controls.Add(this.txtConfirmPassword);
            this.gbNewData.Controls.Add(this.txtPassword);
            this.gbNewData.Controls.Add(this.txtUsername);
            this.gbNewData.Dock = System.Windows.Forms.DockStyle.Right;
            this.gbNewData.Location = new System.Drawing.Point(840, 0);
            this.gbNewData.Name = "gbNewData";
            this.gbNewData.Size = new System.Drawing.Size(476, 394);
            this.gbNewData.TabIndex = 1;
            this.gbNewData.TabStop = false;
            this.gbNewData.Text = "New User Info";
            // 
            // txtUsername
            // 
            this.txtUsername.Details = null;
            this.txtUsername.Info = "New Username";
            this.txtUsername.Location = new System.Drawing.Point(22, 39);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.OnlyNumbers = false;
            this.txtUsername.Size = new System.Drawing.Size(436, 50);
            this.txtUsername.TabIndex = 0;
            // 
            // txtPassword
            // 
            this.txtPassword.Details = null;
            this.txtPassword.Info = "New Password";
            this.txtPassword.Location = new System.Drawing.Point(22, 139);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.OnlyNumbers = false;
            this.txtPassword.Size = new System.Drawing.Size(436, 50);
            this.txtPassword.TabIndex = 1;
            // 
            // txtConfirmPassword
            // 
            this.txtConfirmPassword.Details = null;
            this.txtConfirmPassword.Info = "Confirm Password";
            this.txtConfirmPassword.Location = new System.Drawing.Point(22, 238);
            this.txtConfirmPassword.Name = "txtConfirmPassword";
            this.txtConfirmPassword.OnlyNumbers = false;
            this.txtConfirmPassword.Size = new System.Drawing.Size(436, 50);
            this.txtConfirmPassword.TabIndex = 2;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnSave.ForeColor = System.Drawing.Color.Black;
            this.btnSave.Location = new System.Drawing.Point(38, 315);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(140, 52);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // ctrlUpdateUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gbNewData);
            this.Controls.Add(this.ctrlUserInfo1);
            this.Name = "ctrlUpdateUser";
            this.Size = new System.Drawing.Size(1316, 394);
            this.gbNewData.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Lib.ctrlUserInfo ctrlUserInfo1;
        private System.Windows.Forms.GroupBox gbNewData;
        private Lib.ctrlTextboxUpdateDetails txtConfirmPassword;
        private Lib.ctrlTextboxUpdateDetails txtPassword;
        private Lib.ctrlTextboxUpdateDetails txtUsername;
        private PrimaryButton btnSave;
    }
}
