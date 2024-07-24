namespace PrecentationLayer.People
{
    partial class ctrlPersonInfoWithFilters
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
            this.ctrlPersonInfo1 = new PrecentationLayer.Lib.ctrlPersonInfo();
            this.gbPersonInfo = new System.Windows.Forms.GroupBox();
            this.gbFilters = new System.Windows.Forms.GroupBox();
            this.txtPersonID = new PrecentationLayer.Lib.ctrlTextboxUpdateDetails();
            this.btnFind = new PrecentationLayer.PrimaryButton();
            this.gbPersonInfo.SuspendLayout();
            this.gbFilters.SuspendLayout();
            this.SuspendLayout();
            // 
            // ctrlPersonInfo1
            // 
            this.ctrlPersonInfo1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ctrlPersonInfo1.Location = new System.Drawing.Point(3, 16);
            this.ctrlPersonInfo1.Name = "ctrlPersonInfo1";
            this.ctrlPersonInfo1.PersonInfo = null;
            this.ctrlPersonInfo1.Size = new System.Drawing.Size(797, 260);
            this.ctrlPersonInfo1.TabIndex = 0;
            // 
            // gbPersonInfo
            // 
            this.gbPersonInfo.Controls.Add(this.ctrlPersonInfo1);
            this.gbPersonInfo.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gbPersonInfo.Location = new System.Drawing.Point(0, 113);
            this.gbPersonInfo.Name = "gbPersonInfo";
            this.gbPersonInfo.Size = new System.Drawing.Size(803, 279);
            this.gbPersonInfo.TabIndex = 1;
            this.gbPersonInfo.TabStop = false;
            this.gbPersonInfo.Text = "Person Info";
            // 
            // gbFilters
            // 
            this.gbFilters.Controls.Add(this.btnFind);
            this.gbFilters.Controls.Add(this.txtPersonID);
            this.gbFilters.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbFilters.Location = new System.Drawing.Point(0, 0);
            this.gbFilters.Name = "gbFilters";
            this.gbFilters.Size = new System.Drawing.Size(803, 107);
            this.gbFilters.TabIndex = 2;
            this.gbFilters.TabStop = false;
            this.gbFilters.Text = "Filters";
            // 
            // txtPersonID
            // 
            this.txtPersonID.Details = null;
            this.txtPersonID.Info = "PersonID";
            this.txtPersonID.Location = new System.Drawing.Point(6, 39);
            this.txtPersonID.Name = "txtPersonID";
            this.txtPersonID.OnlyNumbers = true;
            this.txtPersonID.Size = new System.Drawing.Size(461, 38);
            this.txtPersonID.TabIndex = 0;
            // 
            // btnFind
            // 
            this.btnFind.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnFind.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnFind.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFind.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnFind.ForeColor = System.Drawing.Color.Black;
            this.btnFind.Location = new System.Drawing.Point(688, 39);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(109, 38);
            this.btnFind.TabIndex = 1;
            this.btnFind.Text = "Find";
            this.btnFind.UseVisualStyleBackColor = false;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // ctrlPersonInfoWithFilters
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gbFilters);
            this.Controls.Add(this.gbPersonInfo);
            this.Name = "ctrlPersonInfoWithFilters";
            this.Size = new System.Drawing.Size(803, 392);
            this.gbPersonInfo.ResumeLayout(false);
            this.gbFilters.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Lib.ctrlPersonInfo ctrlPersonInfo1;
        private System.Windows.Forms.GroupBox gbPersonInfo;
        private System.Windows.Forms.GroupBox gbFilters;
        private PrimaryButton btnFind;
        private Lib.ctrlTextboxUpdateDetails txtPersonID;
    }
}
