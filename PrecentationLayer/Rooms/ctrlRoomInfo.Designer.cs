namespace PrecentationLayer.Rooms
{
    partial class ctrlRoomInfo
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
            this.lblRoomType = new PrecentationLayer.ctrlLabelInfo();
            this.lblDoubleBeds = new PrecentationLayer.ctrlLabelInfo();
            this.lblSingleBeds = new PrecentationLayer.ctrlLabelInfo();
            this.lblFess = new PrecentationLayer.ctrlLabelInfo();
            this.lblAllowChildren = new PrecentationLayer.ctrlLabelInfo();
            this.lblCapacity = new PrecentationLayer.ctrlLabelInfo();
            this.lblRoomID = new PrecentationLayer.ctrlLabelInfo();
            this.lblFloor = new PrecentationLayer.ctrlLabelInfo();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblFloor);
            this.groupBox1.Controls.Add(this.lblRoomType);
            this.groupBox1.Controls.Add(this.lblDoubleBeds);
            this.groupBox1.Controls.Add(this.lblSingleBeds);
            this.groupBox1.Controls.Add(this.lblFess);
            this.groupBox1.Controls.Add(this.lblAllowChildren);
            this.groupBox1.Controls.Add(this.lblCapacity);
            this.groupBox1.Controls.Add(this.lblRoomID);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(373, 335);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Room Info";
            // 
            // lblRoomType
            // 
            this.lblRoomType.Details = "Type";
            this.lblRoomType.Info = "Room Type";
            this.lblRoomType.Location = new System.Drawing.Point(3, 253);
            this.lblRoomType.Name = "lblRoomType";
            this.lblRoomType.Size = new System.Drawing.Size(334, 28);
            this.lblRoomType.TabIndex = 12;
            // 
            // lblDoubleBeds
            // 
            this.lblDoubleBeds.Details = "0";
            this.lblDoubleBeds.Info = "Double beds";
            this.lblDoubleBeds.Location = new System.Drawing.Point(3, 214);
            this.lblDoubleBeds.Name = "lblDoubleBeds";
            this.lblDoubleBeds.Size = new System.Drawing.Size(334, 28);
            this.lblDoubleBeds.TabIndex = 11;
            // 
            // lblSingleBeds
            // 
            this.lblSingleBeds.Details = "0";
            this.lblSingleBeds.Info = "Single beds";
            this.lblSingleBeds.Location = new System.Drawing.Point(3, 175);
            this.lblSingleBeds.Name = "lblSingleBeds";
            this.lblSingleBeds.Size = new System.Drawing.Size(334, 28);
            this.lblSingleBeds.TabIndex = 10;
            // 
            // lblFess
            // 
            this.lblFess.Details = "Details";
            this.lblFess.Info = "Fees";
            this.lblFess.Location = new System.Drawing.Point(3, 136);
            this.lblFess.Name = "lblFess";
            this.lblFess.Size = new System.Drawing.Size(334, 28);
            this.lblFess.TabIndex = 9;
            // 
            // lblAllowChildren
            // 
            this.lblAllowChildren.Details = "Details";
            this.lblAllowChildren.Info = "Children?";
            this.lblAllowChildren.Location = new System.Drawing.Point(3, 97);
            this.lblAllowChildren.Name = "lblAllowChildren";
            this.lblAllowChildren.Size = new System.Drawing.Size(334, 28);
            this.lblAllowChildren.TabIndex = 8;
            // 
            // lblCapacity
            // 
            this.lblCapacity.Details = "Details";
            this.lblCapacity.Info = "Capacity";
            this.lblCapacity.Location = new System.Drawing.Point(3, 58);
            this.lblCapacity.Name = "lblCapacity";
            this.lblCapacity.Size = new System.Drawing.Size(334, 28);
            this.lblCapacity.TabIndex = 7;
            // 
            // lblRoomID
            // 
            this.lblRoomID.Details = "Details";
            this.lblRoomID.Info = "Room ID";
            this.lblRoomID.Location = new System.Drawing.Point(3, 19);
            this.lblRoomID.Name = "lblRoomID";
            this.lblRoomID.Size = new System.Drawing.Size(334, 28);
            this.lblRoomID.TabIndex = 6;
            // 
            // lblFloor
            // 
            this.lblFloor.Details = "Type";
            this.lblFloor.Info = "Floor";
            this.lblFloor.Location = new System.Drawing.Point(6, 292);
            this.lblFloor.Name = "lblFloor";
            this.lblFloor.Size = new System.Drawing.Size(334, 28);
            this.lblFloor.TabIndex = 13;
            // 
            // ctrlRoomInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Name = "ctrlRoomInfo";
            this.Size = new System.Drawing.Size(373, 335);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private ctrlLabelInfo lblDoubleBeds;
        private ctrlLabelInfo lblSingleBeds;
        private ctrlLabelInfo lblFess;
        private ctrlLabelInfo lblAllowChildren;
        private ctrlLabelInfo lblCapacity;
        private ctrlLabelInfo lblRoomID;
        private ctrlLabelInfo lblRoomType;
        private ctrlLabelInfo lblFloor;
    }
}
