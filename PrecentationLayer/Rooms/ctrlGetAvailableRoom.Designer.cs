namespace PrecentationLayer
{
    partial class ctrlGetAvailableRoom
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
            this.gbAvailableRooms = new System.Windows.Forms.GroupBox();
            this.lblRoomInfo = new System.Windows.Forms.LinkLabel();
            this.btnFind = new PrecentationLayer.PrimaryButton();
            this.cbChildren = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Capacity = new System.Windows.Forms.NumericUpDown();
            this.gbAvailableRooms.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Capacity)).BeginInit();
            this.SuspendLayout();
            // 
            // gbAvailableRooms
            // 
            this.gbAvailableRooms.Controls.Add(this.lblRoomInfo);
            this.gbAvailableRooms.Controls.Add(this.btnFind);
            this.gbAvailableRooms.Controls.Add(this.cbChildren);
            this.gbAvailableRooms.Controls.Add(this.label1);
            this.gbAvailableRooms.Controls.Add(this.Capacity);
            this.gbAvailableRooms.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbAvailableRooms.Location = new System.Drawing.Point(0, 0);
            this.gbAvailableRooms.Name = "gbAvailableRooms";
            this.gbAvailableRooms.Size = new System.Drawing.Size(287, 150);
            this.gbAvailableRooms.TabIndex = 0;
            this.gbAvailableRooms.TabStop = false;
            this.gbAvailableRooms.Text = "Get Available Room";
            // 
            // lblRoomInfo
            // 
            this.lblRoomInfo.AutoSize = true;
            this.lblRoomInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRoomInfo.Location = new System.Drawing.Point(2, 114);
            this.lblRoomInfo.Name = "lblRoomInfo";
            this.lblRoomInfo.Size = new System.Drawing.Size(118, 25);
            this.lblRoomInfo.TabIndex = 12;
            this.lblRoomInfo.TabStop = true;
            this.lblRoomInfo.Text = "Room Info";
            this.lblRoomInfo.Visible = false;
            this.lblRoomInfo.Click += new System.EventHandler(this.lblRoomInfo_LinkClicked);
            // 
            // btnFind
            // 
            this.btnFind.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFind.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnFind.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFind.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnFind.ForeColor = System.Drawing.Color.Black;
            this.btnFind.Location = new System.Drawing.Point(143, 87);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(140, 52);
            this.btnFind.TabIndex = 11;
            this.btnFind.Text = "Find";
            this.btnFind.UseVisualStyleBackColor = false;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // cbChildren
            // 
            this.cbChildren.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbChildren.AutoSize = true;
            this.cbChildren.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbChildren.Location = new System.Drawing.Point(118, 53);
            this.cbChildren.Name = "cbChildren";
            this.cbChildren.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cbChildren.Size = new System.Drawing.Size(165, 28);
            this.cbChildren.TabIndex = 10;
            this.cbChildren.Text = "Allow Children";
            this.cbChildren.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(146, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 24);
            this.label1.TabIndex = 9;
            this.label1.Text = "People:";
            // 
            // Capacity
            // 
            this.Capacity.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Capacity.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Capacity.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Capacity.Location = new System.Drawing.Point(234, 12);
            this.Capacity.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.Capacity.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Capacity.Name = "Capacity";
            this.Capacity.Size = new System.Drawing.Size(51, 25);
            this.Capacity.TabIndex = 8;
            this.Capacity.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // ctrlGetAvailableRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gbAvailableRooms);
            this.Name = "ctrlGetAvailableRoom";
            this.Size = new System.Drawing.Size(287, 150);
            this.gbAvailableRooms.ResumeLayout(false);
            this.gbAvailableRooms.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Capacity)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbAvailableRooms;
        private System.Windows.Forms.LinkLabel lblRoomInfo;
        private PrimaryButton btnFind;
        private System.Windows.Forms.CheckBox cbChildren;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown Capacity;
    }
}
