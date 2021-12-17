namespace ChuyenDoiTienTe
{
    partial class MH_Chinh
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
            this.label1 = new System.Windows.Forms.Label();
            this.Button_MH_CapNhatTyGia = new System.Windows.Forms.Button();
            this.Button_MH_BanNgoaiTe = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(125, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(592, 36);
            this.label1.TabIndex = 12;
            this.label1.Text = "Chương Trình Cập Nhật Tỷ Giá Ngoại Tệ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Button_MH_CapNhatTyGia
            // 
            this.Button_MH_CapNhatTyGia.BackColor = System.Drawing.SystemColors.HotTrack;
            this.Button_MH_CapNhatTyGia.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Button_MH_CapNhatTyGia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_MH_CapNhatTyGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_MH_CapNhatTyGia.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Button_MH_CapNhatTyGia.Location = new System.Drawing.Point(306, 178);
            this.Button_MH_CapNhatTyGia.Name = "Button_MH_CapNhatTyGia";
            this.Button_MH_CapNhatTyGia.Size = new System.Drawing.Size(204, 66);
            this.Button_MH_CapNhatTyGia.TabIndex = 11;
            this.Button_MH_CapNhatTyGia.Text = "Cập Nhật Tỷ Giá";
            this.Button_MH_CapNhatTyGia.UseVisualStyleBackColor = false;
            // 
            // Button_MH_BanNgoaiTe
            // 
            this.Button_MH_BanNgoaiTe.BackColor = System.Drawing.SystemColors.HotTrack;
            this.Button_MH_BanNgoaiTe.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Button_MH_BanNgoaiTe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_MH_BanNgoaiTe.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_MH_BanNgoaiTe.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Button_MH_BanNgoaiTe.Location = new System.Drawing.Point(306, 301);
            this.Button_MH_BanNgoaiTe.Name = "Button_MH_BanNgoaiTe";
            this.Button_MH_BanNgoaiTe.Size = new System.Drawing.Size(204, 66);
            this.Button_MH_BanNgoaiTe.TabIndex = 13;
            this.Button_MH_BanNgoaiTe.Text = "Bán Ngoại Tệ";
            this.Button_MH_BanNgoaiTe.UseVisualStyleBackColor = false;
            // 
            // MH_Chinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Button_MH_BanNgoaiTe);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Button_MH_CapNhatTyGia);
            this.Name = "MH_Chinh";
            this.Text = "MBBank";
            this.ResumeLayout(false);
            this.PerformLayout();

        }



        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Button_MH_CapNhatTyGia;
        private System.Windows.Forms.Button Button_MH_BanNgoaiTe;
    }
}

