namespace PrecentationLayer.Users
{
    partial class frmAddNewUser
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
            this.ctrlPersonInfoWithFilters1 = new PrecentationLayer.People.ctrlPersonInfoWithFilters();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtConfirmPass = new PrecentationLayer.Lib.ctrlTextboxUpdateDetails();
            this.txtPassword = new PrecentationLayer.Lib.ctrlTextboxUpdateDetails();
            this.txtUsername = new PrecentationLayer.Lib.ctrlTextboxUpdateDetails();
            this.btnSave = new PrecentationLayer.PrimaryButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ctrlPersonInfoWithFilters1
            // 
            this.ctrlPersonInfoWithFilters1.AllowFilters = true;
            this.ctrlPersonInfoWithFilters1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ctrlPersonInfoWithFilters1.Location = new System.Drawing.Point(162, 93);
            this.ctrlPersonInfoWithFilters1.Name = "ctrlPersonInfoWithFilters1";
            this.ctrlPersonInfoWithFilters1.PersonID = null;
            this.ctrlPersonInfoWithFilters1.Size = new System.Drawing.Size(803, 392);
            this.ctrlPersonInfoWithFilters1.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.txtConfirmPass);
            this.groupBox1.Controls.Add(this.txtPassword);
            this.groupBox1.Controls.Add(this.txtUsername);
            this.groupBox1.Location = new System.Drawing.Point(58, 491);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(993, 165);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "User Info";
            // 
            // txtConfirmPass
            // 
            this.txtConfirmPass.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtConfirmPass.Details = null;
            this.txtConfirmPass.HideCharacters = true;
            this.txtConfirmPass.Info = "Confirm Pass";
            this.txtConfirmPass.Location = new System.Drawing.Point(496, 83);
            this.txtConfirmPass.Name = "txtConfirmPass";
            this.txtConfirmPass.OnlyNumbers = false;
            this.txtConfirmPass.Size = new System.Drawing.Size(461, 38);
            this.txtConfirmPass.TabIndex = 2;
            // 
            // txtPassword
            // 
            this.txtPassword.Details = null;
            this.txtPassword.HideCharacters = true;
            this.txtPassword.Info = "Password";
            this.txtPassword.Location = new System.Drawing.Point(15, 83);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.OnlyNumbers = false;
            this.txtPassword.Size = new System.Drawing.Size(461, 38);
            this.txtPassword.TabIndex = 1;
            // 
            // txtUsername
            // 
            this.txtUsername.Details = null;
            this.txtUsername.HideCharacters = false;
            this.txtUsername.Info = "Username";
            this.txtUsername.Location = new System.Drawing.Point(15, 19);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.OnlyNumbers = false;
            this.txtUsername.Size = new System.Drawing.Size(461, 38);
            this.txtUsername.TabIndex = 0;
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnSave.ForeColor = System.Drawing.Color.Black;
            this.btnSave.Location = new System.Drawing.Point(841, 662);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(210, 52);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // frmAddNewUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1132, 749);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.ctrlPersonInfoWithFilters1);
            this.Name = "frmAddNewUser";
            this.Text = "frmAddNewUser";
            this.Controls.SetChildIndex(this.ctrlPersonInfoWithFilters1, 0);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.Controls.SetChildIndex(this.btnSave, 0);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private People.ctrlPersonInfoWithFilters ctrlPersonInfoWithFilters1;
        private System.Windows.Forms.GroupBox groupBox1;
        private Lib.ctrlTextboxUpdateDetails txtConfirmPass;
        private Lib.ctrlTextboxUpdateDetails txtPassword;
        private Lib.ctrlTextboxUpdateDetails txtUsername;
        private PrimaryButton btnSave;
    }
}