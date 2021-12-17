
    partial class MH_Doc_Xuat_File
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
            this.TH_HoTen = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TH_HoTen
            // 
            this.TH_HoTen.Location = new System.Drawing.Point(14, 29);
            this.TH_HoTen.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.TH_HoTen.Name = "TH_HoTen";
            this.TH_HoTen.Size = new System.Drawing.Size(466, 378);
            this.TH_HoTen.TabIndex = 0;
            this.TH_HoTen.Text = "Họ Tên";
            this.TH_HoTen.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MH_Doc_Xuat_File
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.ClientSize = new System.Drawing.Size(494, 459);
            this.Controls.Add(this.TH_HoTen);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "MH_Doc_Xuat_File";
            this.Text = "MH_Doc_Xuat_File";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label TH_HoTen;
    }
