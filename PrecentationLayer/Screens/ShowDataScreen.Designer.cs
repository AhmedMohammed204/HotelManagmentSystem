﻿namespace PrecentationLayer.Screens
{
    partial class ShowDataScreen
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
            this.ctrlDataGridWithSearch1 = new PrecentationLayer.Lib.ctrlDataGridWithSearch();
            this.SuspendLayout();
            // 
            // ctrlDataGridWithSearch1
            // 
            this.ctrlDataGridWithSearch1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ctrlDataGridWithSearch1.Location = new System.Drawing.Point(0, 176);
            this.ctrlDataGridWithSearch1.Name = "ctrlDataGridWithSearch1";
            this.ctrlDataGridWithSearch1.Size = new System.Drawing.Size(800, 274);
            this.ctrlDataGridWithSearch1.TabIndex = 2;
            // 
            // ShowDataScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ctrlDataGridWithSearch1);
            this.Name = "ShowDataScreen";
            this.Text = "ShowDataScreen";
            this.Controls.SetChildIndex(this.ctrlDataGridWithSearch1, 0);
            this.ResumeLayout(false);

        }

        #endregion

        private Lib.ctrlDataGridWithSearch ctrlDataGridWithSearch1;
    }
}