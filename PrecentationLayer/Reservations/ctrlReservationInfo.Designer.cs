namespace PrecentationLayer.Reservations
{
    partial class ctrlReservationInfo
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
            this.lblReservationID = new PrecentationLayer.ctrlLabelInfo();
            this.lblStartDate = new PrecentationLayer.ctrlLabelInfo();
            this.lblEndDate = new PrecentationLayer.ctrlLabelInfo();
            this.lblPaidFees = new PrecentationLayer.ctrlLabelInfo();
            this.lblCreatedByUserInfo = new System.Windows.Forms.LinkLabel();
            this.lblPersonInfo = new System.Windows.Forms.LinkLabel();
            this.lblRoomInfo = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // lblReservationID
            // 
            this.lblReservationID.Details = "Details";
            this.lblReservationID.Info = "Reservation ID";
            this.lblReservationID.Location = new System.Drawing.Point(24, 41);
            this.lblReservationID.Name = "lblReservationID";
            this.lblReservationID.Size = new System.Drawing.Size(334, 53);
            this.lblReservationID.TabIndex = 0;
            // 
            // lblStartDate
            // 
            this.lblStartDate.Details = "Details";
            this.lblStartDate.Info = "Start Date";
            this.lblStartDate.Location = new System.Drawing.Point(24, 123);
            this.lblStartDate.Name = "lblStartDate";
            this.lblStartDate.Size = new System.Drawing.Size(334, 53);
            this.lblStartDate.TabIndex = 1;
            // 
            // lblEndDate
            // 
            this.lblEndDate.Details = "Details";
            this.lblEndDate.Info = "End Date";
            this.lblEndDate.Location = new System.Drawing.Point(24, 205);
            this.lblEndDate.Name = "lblEndDate";
            this.lblEndDate.Size = new System.Drawing.Size(334, 53);
            this.lblEndDate.TabIndex = 2;
            // 
            // lblPaidFees
            // 
            this.lblPaidFees.Details = "Details";
            this.lblPaidFees.Info = "Paid Fees";
            this.lblPaidFees.Location = new System.Drawing.Point(24, 287);
            this.lblPaidFees.Name = "lblPaidFees";
            this.lblPaidFees.Size = new System.Drawing.Size(334, 53);
            this.lblPaidFees.TabIndex = 3;
            // 
            // lblCreatedByUserInfo
            // 
            this.lblCreatedByUserInfo.AutoSize = true;
            this.lblCreatedByUserInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCreatedByUserInfo.Location = new System.Drawing.Point(406, 61);
            this.lblCreatedByUserInfo.Name = "lblCreatedByUserInfo";
            this.lblCreatedByUserInfo.Size = new System.Drawing.Size(150, 16);
            this.lblCreatedByUserInfo.TabIndex = 4;
            this.lblCreatedByUserInfo.TabStop = true;
            this.lblCreatedByUserInfo.Text = "Created By User Info";
            this.lblCreatedByUserInfo.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblCreatedByUserInfo_LinkClicked);
            // 
            // lblPersonInfo
            // 
            this.lblPersonInfo.AutoSize = true;
            this.lblPersonInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPersonInfo.Location = new System.Drawing.Point(408, 133);
            this.lblPersonInfo.Name = "lblPersonInfo";
            this.lblPersonInfo.Size = new System.Drawing.Size(85, 16);
            this.lblPersonInfo.TabIndex = 5;
            this.lblPersonInfo.TabStop = true;
            this.lblPersonInfo.Text = "Person Info";
            this.lblPersonInfo.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblPersonInfo_LinkClicked);
            // 
            // lblRoomInfo
            // 
            this.lblRoomInfo.AutoSize = true;
            this.lblRoomInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRoomInfo.Location = new System.Drawing.Point(406, 205);
            this.lblRoomInfo.Name = "lblRoomInfo";
            this.lblRoomInfo.Size = new System.Drawing.Size(77, 16);
            this.lblRoomInfo.TabIndex = 6;
            this.lblRoomInfo.TabStop = true;
            this.lblRoomInfo.Text = "Room Info";
            this.lblRoomInfo.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblRoomInfo_LinkClicked);
            // 
            // ctrlReservationInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblRoomInfo);
            this.Controls.Add(this.lblPersonInfo);
            this.Controls.Add(this.lblCreatedByUserInfo);
            this.Controls.Add(this.lblPaidFees);
            this.Controls.Add(this.lblEndDate);
            this.Controls.Add(this.lblStartDate);
            this.Controls.Add(this.lblReservationID);
            this.Name = "ctrlReservationInfo";
            this.Size = new System.Drawing.Size(574, 339);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ctrlLabelInfo lblReservationID;
        private ctrlLabelInfo lblStartDate;
        private ctrlLabelInfo lblEndDate;
        private ctrlLabelInfo lblPaidFees;
        private System.Windows.Forms.LinkLabel lblCreatedByUserInfo;
        private System.Windows.Forms.LinkLabel lblPersonInfo;
        private System.Windows.Forms.LinkLabel lblRoomInfo;
    }
}
