namespace PrecentationLayer.Reservations
{
    partial class frmAddUpdateReservation
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
            this.ctrlGetAvailableRoom1 = new PrecentationLayer.ctrlGetAvailableRoom();
            this.gbPeriod = new System.Windows.Forms.GroupBox();
            this.mcPeriod = new System.Windows.Forms.MonthCalendar();
            this.lblFees = new PrecentationLayer.ctrlLabelInfo();
            this.btnSave = new PrecentationLayer.PrimaryButton();
            this.lblRoomInfo = new System.Windows.Forms.LinkLabel();
            this.gbPeriod.SuspendLayout();
            this.SuspendLayout();
            // 
            // ctrlPersonInfoWithFilters1
            // 
            this.ctrlPersonInfoWithFilters1.AllowFilters = true;
            this.ctrlPersonInfoWithFilters1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ctrlPersonInfoWithFilters1.Location = new System.Drawing.Point(25, 126);
            this.ctrlPersonInfoWithFilters1.Name = "ctrlPersonInfoWithFilters1";
            this.ctrlPersonInfoWithFilters1.PersonID = null;
            this.ctrlPersonInfoWithFilters1.Size = new System.Drawing.Size(1003, 392);
            this.ctrlPersonInfoWithFilters1.TabIndex = 5;
            // 
            // ctrlGetAvailableRoom1
            // 
            this.ctrlGetAvailableRoom1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ctrlGetAvailableRoom1.Location = new System.Drawing.Point(741, 524);
            this.ctrlGetAvailableRoom1.Name = "ctrlGetAvailableRoom1";
            this.ctrlGetAvailableRoom1.Room = null;
            this.ctrlGetAvailableRoom1.Size = new System.Drawing.Size(287, 150);
            this.ctrlGetAvailableRoom1.TabIndex = 6;
            this.ctrlGetAvailableRoom1.OnRoomFound += new System.Action<int>(this.ctrlGetAvailableRoom1_OnRoomFound);
            this.ctrlGetAvailableRoom1.OnRoomInfoClicked += new System.Action<int>(this.ctrlGetAvailableRoom1_OnRoomInfoClicked);
            // 
            // gbPeriod
            // 
            this.gbPeriod.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.gbPeriod.Controls.Add(this.mcPeriod);
            this.gbPeriod.Location = new System.Drawing.Point(378, 524);
            this.gbPeriod.Name = "gbPeriod";
            this.gbPeriod.Size = new System.Drawing.Size(333, 187);
            this.gbPeriod.TabIndex = 8;
            this.gbPeriod.TabStop = false;
            this.gbPeriod.Text = "Period";
            // 
            // mcPeriod
            // 
            this.mcPeriod.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mcPeriod.Location = new System.Drawing.Point(3, 16);
            this.mcPeriod.Name = "mcPeriod";
            this.mcPeriod.TabIndex = 9;
            this.mcPeriod.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.mcPeriod_DateChanged);
            // 
            // lblFees
            // 
            this.lblFees.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblFees.Details = "????";
            this.lblFees.Info = "Fees";
            this.lblFees.Location = new System.Drawing.Point(65, 557);
            this.lblFees.Name = "lblFees";
            this.lblFees.Size = new System.Drawing.Size(334, 28);
            this.lblFees.TabIndex = 9;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnSave.ForeColor = System.Drawing.Color.Black;
            this.btnSave.Location = new System.Drawing.Point(87, 600);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(168, 67);
            this.btnSave.TabIndex = 10;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblRoomInfo
            // 
            this.lblRoomInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblRoomInfo.AutoSize = true;
            this.lblRoomInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRoomInfo.Location = new System.Drawing.Point(843, 600);
            this.lblRoomInfo.Name = "lblRoomInfo";
            this.lblRoomInfo.Size = new System.Drawing.Size(118, 25);
            this.lblRoomInfo.TabIndex = 11;
            this.lblRoomInfo.TabStop = true;
            this.lblRoomInfo.Text = "Room Info";
            this.lblRoomInfo.Visible = false;
            this.lblRoomInfo.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblRoomInfo_LinkClicked);
            // 
            // frmAddUpdateReservation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1053, 749);
            this.Controls.Add(this.lblRoomInfo);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lblFees);
            this.Controls.Add(this.gbPeriod);
            this.Controls.Add(this.ctrlGetAvailableRoom1);
            this.Controls.Add(this.ctrlPersonInfoWithFilters1);
            this.Name = "frmAddUpdateReservation";
            this.Padding = new System.Windows.Forms.Padding(25);
            this.Text = "frmAddUpdateReservation";
            this.Load += new System.EventHandler(this.frmAddUpdateReservation_Load);
            this.Controls.SetChildIndex(this.ctrlPersonInfoWithFilters1, 0);
            this.Controls.SetChildIndex(this.ctrlGetAvailableRoom1, 0);
            this.Controls.SetChildIndex(this.gbPeriod, 0);
            this.Controls.SetChildIndex(this.lblFees, 0);
            this.Controls.SetChildIndex(this.btnSave, 0);
            this.Controls.SetChildIndex(this.lblRoomInfo, 0);
            this.gbPeriod.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private People.ctrlPersonInfoWithFilters ctrlPersonInfoWithFilters1;
        private ctrlGetAvailableRoom ctrlGetAvailableRoom1;
        private System.Windows.Forms.GroupBox gbPeriod;
        private System.Windows.Forms.MonthCalendar mcPeriod;
        private ctrlLabelInfo lblFees;
        private PrimaryButton btnSave;
        private System.Windows.Forms.LinkLabel lblRoomInfo;
    }
}