namespace PrecentationLayer.Lib
{
    partial class ctrlUserInfo
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ctrlPersonInfo1 = new PrecentationLayer.Lib.ctrlPersonInfo();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.InfoIsActive = new PrecentationLayer.ctrlLabelInfo();
            this.InfoUsername = new PrecentationLayer.ctrlLabelInfo();
            this.btnUpdateUserInfo = new PrecentationLayer.PrimaryButton();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ctrlPersonInfo1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox1.Location = new System.Drawing.Point(0, 111);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(834, 291);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Person Info";
            // 
            // ctrlPersonInfo1
            // 
            this.ctrlPersonInfo1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ctrlPersonInfo1.Location = new System.Drawing.Point(3, 16);
            this.ctrlPersonInfo1.Name = "ctrlPersonInfo1";
            this.ctrlPersonInfo1.PersonInfo = null;
            this.ctrlPersonInfo1.Size = new System.Drawing.Size(828, 272);
            this.ctrlPersonInfo1.TabIndex = 0;
            this.ctrlPersonInfo1.OnClickUpdate += new System.Action<int>(this.ctrlPersonInfo1_OnClickUpdate);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnUpdateUserInfo);
            this.groupBox2.Controls.Add(this.InfoIsActive);
            this.groupBox2.Controls.Add(this.InfoUsername);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(834, 106);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "User Info";
            // 
            // InfoIsActive
            // 
            this.InfoIsActive.Details = "Details";
            this.InfoIsActive.Info = "Is Active";
            this.InfoIsActive.Location = new System.Drawing.Point(6, 53);
            this.InfoIsActive.Name = "InfoIsActive";
            this.InfoIsActive.Size = new System.Drawing.Size(334, 28);
            this.InfoIsActive.TabIndex = 1;
            // 
            // InfoUsername
            // 
            this.InfoUsername.Details = "Details";
            this.InfoUsername.Info = "Username";
            this.InfoUsername.Location = new System.Drawing.Point(6, 19);
            this.InfoUsername.Name = "InfoUsername";
            this.InfoUsername.Size = new System.Drawing.Size(334, 28);
            this.InfoUsername.TabIndex = 0;
            // 
            // btnUpdateUserInfo
            // 
            this.btnUpdateUserInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnUpdateUserInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateUserInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnUpdateUserInfo.ForeColor = System.Drawing.Color.Black;
            this.btnUpdateUserInfo.Location = new System.Drawing.Point(644, 29);
            this.btnUpdateUserInfo.Name = "btnUpdateUserInfo";
            this.btnUpdateUserInfo.Size = new System.Drawing.Size(140, 52);
            this.btnUpdateUserInfo.TabIndex = 2;
            this.btnUpdateUserInfo.Text = "Update";
            this.btnUpdateUserInfo.UseVisualStyleBackColor = false;
            this.btnUpdateUserInfo.Click += new System.EventHandler(this.btnUpdateUserInfo_Click);
            // 
            // ctrlUserInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "ctrlUserInfo";
            this.Size = new System.Drawing.Size(834, 402);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private ctrlLabelInfo InfoIsActive;
        private ctrlLabelInfo InfoUsername;
        private ctrlPersonInfo ctrlPersonInfo1;
        private PrimaryButton btnUpdateUserInfo;
    }
}
