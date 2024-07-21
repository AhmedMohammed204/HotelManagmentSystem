namespace PrecentationLayer.Lib
{
    partial class ctrlDataGridWithSearch
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
            this.pBottom = new System.Windows.Forms.Panel();
            this.pTop = new System.Windows.Forms.Panel();
            this.dgvData = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.cbFillters = new System.Windows.Forms.ComboBox();
            this.txtSearch = new PrecentationLayer.Lib.PrimaryTextBox();
            this.pBottom.SuspendLayout();
            this.pTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).BeginInit();
            this.SuspendLayout();
            // 
            // pBottom
            // 
            this.pBottom.Controls.Add(this.dgvData);
            this.pBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pBottom.Location = new System.Drawing.Point(0, 33);
            this.pBottom.Name = "pBottom";
            this.pBottom.Size = new System.Drawing.Size(606, 221);
            this.pBottom.TabIndex = 0;
            // 
            // pTop
            // 
            this.pTop.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pTop.Controls.Add(this.txtSearch);
            this.pTop.Controls.Add(this.cbFillters);
            this.pTop.Controls.Add(this.label1);
            this.pTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pTop.Location = new System.Drawing.Point(0, 0);
            this.pTop.Name = "pTop";
            this.pTop.Size = new System.Drawing.Size(606, 27);
            this.pTop.TabIndex = 1;
            // 
            // dgvData
            // 
            this.dgvData.AllowUserToAddRows = false;
            this.dgvData.AllowUserToDeleteRows = false;
            this.dgvData.AllowUserToOrderColumns = true;
            this.dgvData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvData.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvData.Location = new System.Drawing.Point(0, 0);
            this.dgvData.Name = "dgvData";
            this.dgvData.ReadOnly = true;
            this.dgvData.Size = new System.Drawing.Size(606, 221);
            this.dgvData.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Fillter By:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbFillters
            // 
            this.cbFillters.Dock = System.Windows.Forms.DockStyle.Left;
            this.cbFillters.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbFillters.FormattingEnabled = true;
            this.cbFillters.Location = new System.Drawing.Point(145, 0);
            this.cbFillters.Name = "cbFillters";
            this.cbFillters.Size = new System.Drawing.Size(135, 26);
            this.cbFillters.TabIndex = 1;
            // 
            // txtSearch
            // 
            this.txtSearch.Dock = System.Windows.Forms.DockStyle.Right;
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(353, 0);
            this.txtSearch.Mode = PrecentationLayer.Lib.PrimaryTextBox.enMode.Show;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.OnlyNumbers = false;
            this.txtSearch.Size = new System.Drawing.Size(251, 26);
            this.txtSearch.TabIndex = 2;
            this.txtSearch.Tag = "Hide";
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // ctrlDataGridWithSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pTop);
            this.Controls.Add(this.pBottom);
            this.Name = "ctrlDataGridWithSearch";
            this.Size = new System.Drawing.Size(606, 254);
            this.pBottom.ResumeLayout(false);
            this.pTop.ResumeLayout(false);
            this.pTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvData)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pBottom;
        private System.Windows.Forms.Panel pTop;
        private System.Windows.Forms.DataGridView dgvData;
        private PrimaryTextBox txtSearch;
        private System.Windows.Forms.ComboBox cbFillters;
        private System.Windows.Forms.Label label1;
    }
}
