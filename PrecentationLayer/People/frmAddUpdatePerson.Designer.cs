namespace PrecentationLayer.People
{
    partial class frmAddUpdatePerson
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
            this.ctrlUpdatePersonInfo1 = new PrecentationLayer.People.ctrlAddUpdatePersonInfo();
            this.SuspendLayout();
            // 
            // ctrlUpdatePersonInfo1
            // 
            this.ctrlUpdatePersonInfo1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ctrlUpdatePersonInfo1.Location = new System.Drawing.Point(140, 162);
            this.ctrlUpdatePersonInfo1.Mode = PrecentationLayer.People.ctrlAddUpdatePersonInfo.enMode.AddNew;
            this.ctrlUpdatePersonInfo1.Name = "ctrlUpdatePersonInfo1";
            this.ctrlUpdatePersonInfo1.PersonInfo = null;
            this.ctrlUpdatePersonInfo1.Size = new System.Drawing.Size(991, 412);
            this.ctrlUpdatePersonInfo1.TabIndex = 3;
            this.ctrlUpdatePersonInfo1.OnModeChanged += new System.Action<string>(this.ctrlUpdatePersonInfo1_OnModeChanged);
            // 
            // frmAddUpdatePerson
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1284, 605);
            this.Controls.Add(this.ctrlUpdatePersonInfo1);
            this.Name = "frmAddUpdatePerson";
            this.Text = "frmUpdatePerson";
            this.Controls.SetChildIndex(this.ctrlUpdatePersonInfo1, 0);
            this.ResumeLayout(false);

        }

        #endregion

        private ctrlAddUpdatePersonInfo ctrlUpdatePersonInfo1;
    }
}