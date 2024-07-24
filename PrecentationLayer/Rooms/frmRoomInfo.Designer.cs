namespace PrecentationLayer.Rooms
{
    partial class frmRoomInfo
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
            this.ctrlRoomInfo1 = new PrecentationLayer.Rooms.ctrlRoomInfo();
            this.SuspendLayout();
            // 
            // ctrlRoomInfo1
            // 
            this.ctrlRoomInfo1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ctrlRoomInfo1.Location = new System.Drawing.Point(214, 114);
            this.ctrlRoomInfo1.Name = "ctrlRoomInfo1";
            this.ctrlRoomInfo1.Room = null;
            this.ctrlRoomInfo1.Size = new System.Drawing.Size(373, 350);
            this.ctrlRoomInfo1.TabIndex = 3;
            // 
            // frmRoomInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 527);
            this.Controls.Add(this.ctrlRoomInfo1);
            this.Name = "frmRoomInfo";
            this.Text = "frmRoomInfo";
            this.Controls.SetChildIndex(this.ctrlRoomInfo1, 0);
            this.ResumeLayout(false);

        }

        #endregion

        private ctrlRoomInfo ctrlRoomInfo1;
    }
}