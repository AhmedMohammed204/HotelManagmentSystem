namespace PrecentationLayer.Screens
{
    partial class SubTitledScreen
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
            this.primaryButton1 = new PrecentationLayer.PrimaryButton();
            this.SuspendLayout();
            // 
            // primaryButton1
            // 
            this.primaryButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.primaryButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.primaryButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.primaryButton1.ForeColor = System.Drawing.Color.Black;
            this.primaryButton1.Location = new System.Drawing.Point(12, 12);
            this.primaryButton1.Name = "primaryButton1";
            this.primaryButton1.Size = new System.Drawing.Size(76, 52);
            this.primaryButton1.TabIndex = 2;
            this.primaryButton1.Text = "Close X";
            this.primaryButton1.UseVisualStyleBackColor = false;
            this.primaryButton1.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // SubTitledScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.primaryButton1);
            this.Name = "SubTitledScreen";
            this.Text = "SubTitledScreen";
            this.Controls.SetChildIndex(this.primaryButton1, 0);
            this.ResumeLayout(false);

        }

        #endregion

        private PrimaryButton primaryButton1;
    }
}