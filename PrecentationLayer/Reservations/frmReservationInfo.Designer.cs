namespace PrecentationLayer.Reservations
{
    partial class frmReservationInfo
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
            this.gbReservationInfo = new System.Windows.Forms.GroupBox();
            this.ctrlReservationInfo1 = new PrecentationLayer.Reservations.ctrlReservationInfo();
            this.gbReservationInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbReservationInfo
            // 
            this.gbReservationInfo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbReservationInfo.Controls.Add(this.ctrlReservationInfo1);
            this.gbReservationInfo.Location = new System.Drawing.Point(53, 78);
            this.gbReservationInfo.Name = "gbReservationInfo";
            this.gbReservationInfo.Size = new System.Drawing.Size(699, 387);
            this.gbReservationInfo.TabIndex = 3;
            this.gbReservationInfo.TabStop = false;
            this.gbReservationInfo.Text = "Reservation Info";
            // 
            // ctrlReservationInfo1
            // 
            this.ctrlReservationInfo1.Location = new System.Drawing.Point(57, 21);
            this.ctrlReservationInfo1.Name = "ctrlReservationInfo1";
            this.ctrlReservationInfo1.Reservation = null;
            this.ctrlReservationInfo1.Size = new System.Drawing.Size(574, 339);
            this.ctrlReservationInfo1.TabIndex = 4;
            this.ctrlReservationInfo1.OnClickCreatedByUserInfo += new System.Action<int>(this.ctrlReservationInfo1_OnClickCreatedByUserInfo);
            this.ctrlReservationInfo1.OnClickPersonInfo += new System.Action<int>(this.ctrlReservationInfo1_OnClickPersonInfo);
            this.ctrlReservationInfo1.OnClickRoomInfo += new System.Action<int>(this.ctrlReservationInfo1_OnClickRoomInfo);
            // 
            // frmReservationInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(838, 506);
            this.Controls.Add(this.gbReservationInfo);
            this.Name = "frmReservationInfo";
            this.Text = "frmReservationInfo";
            this.Controls.SetChildIndex(this.gbReservationInfo, 0);
            this.gbReservationInfo.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbReservationInfo;
        private ctrlReservationInfo ctrlReservationInfo1;
    }
}