﻿namespace PrecentationLayer.Users
{
    partial class frmUpdateUser
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
            this.ctrlUpdateUser1 = new PrecentationLayer.Users.ctrlUpdateUser();
            this.SuspendLayout();
            // 
            // ctrlUpdateUser1
            // 
            this.ctrlUpdateUser1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ctrlUpdateUser1.Location = new System.Drawing.Point(12, 108);
            this.ctrlUpdateUser1.Name = "ctrlUpdateUser1";
            this.ctrlUpdateUser1.Size = new System.Drawing.Size(1360, 394);
            this.ctrlUpdateUser1.TabIndex = 3;
            // 
            // frmUpdateUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1360, 592);
            this.Controls.Add(this.ctrlUpdateUser1);
            this.Name = "frmUpdateUser";
            this.Padding = new System.Windows.Forms.Padding(30);
            this.Text = "frmUpdateUser";
            this.Controls.SetChildIndex(this.ctrlUpdateUser1, 0);
            this.ResumeLayout(false);

        }

        #endregion

        private ctrlUpdateUser ctrlUpdateUser1;
    }
}