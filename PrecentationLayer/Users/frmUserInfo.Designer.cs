namespace PrecentationLayer.Users
{
    partial class frmUserInfo
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
            this.ctrlUserInfo1 = new PrecentationLayer.Lib.ctrlUserInfo();
            this.SuspendLayout();
            // 
            // ctrlUserInfo1
            // 
            this.ctrlUserInfo1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ctrlUserInfo1.Location = new System.Drawing.Point(81, 156);
            this.ctrlUserInfo1.Name = "ctrlUserInfo1";
            this.ctrlUserInfo1.Size = new System.Drawing.Size(834, 402);
            this.ctrlUserInfo1.TabIndex = 3;
            this.ctrlUserInfo1.UserInfo = null;
            this.ctrlUserInfo1.OnClickUpdate += new System.Action<int>(this.ctrlUserInfo1_OnClickUpdate);
            this.ctrlUserInfo1.OnClickUpdateUserInfo += new System.Action<int>(this.ctrlUserInfo1_OnClickUpdateUserInfo);
            // 
            // frmUserInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(975, 570);
            this.Controls.Add(this.ctrlUserInfo1);
            this.Name = "frmUserInfo";
            this.Text = "frmUserInfo";
            this.Controls.SetChildIndex(this.ctrlUserInfo1, 0);
            this.ResumeLayout(false);

        }

        #endregion

        private Lib.ctrlUserInfo ctrlUserInfo1;
    }
}