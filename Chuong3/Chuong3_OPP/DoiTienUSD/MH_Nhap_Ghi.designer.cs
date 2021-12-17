
    partial class MH_Nhap_Ghi
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
            this.TH_kq = new System.Windows.Forms.Label();
            this.TH_NhapGhi = new System.Windows.Forms.TextBox();
            this.TH_DongY = new System.Windows.Forms.Button();
            this.TH_kqFile = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TH_kq
            // 
            this.TH_kq.AutoSize = true;
            this.TH_kq.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TH_kq.Location = new System.Drawing.Point(181, 57);
            this.TH_kq.Name = "TH_kq";
            this.TH_kq.Size = new System.Drawing.Size(228, 29);
            this.TH_kq.TabIndex = 0;
            this.TH_kq.Text = "Thông báo nhập tên";
            // 
            // TH_NhapGhi
            // 
            this.TH_NhapGhi.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TH_NhapGhi.Location = new System.Drawing.Point(186, 109);
            this.TH_NhapGhi.Name = "TH_NhapGhi";
            this.TH_NhapGhi.Size = new System.Drawing.Size(223, 34);
            this.TH_NhapGhi.TabIndex = 1;
            // 
            // TH_DongY
            // 
            this.TH_DongY.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TH_DongY.Location = new System.Drawing.Point(234, 186);
            this.TH_DongY.Name = "TH_DongY";
            this.TH_DongY.Size = new System.Drawing.Size(112, 56);
            this.TH_DongY.TabIndex = 2;
            this.TH_DongY.Text = "Đồng ý";
            this.TH_DongY.UseVisualStyleBackColor = true;
            // 
            // TH_kqFile
            // 
            this.TH_kqFile.AutoSize = true;
            this.TH_kqFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TH_kqFile.Location = new System.Drawing.Point(205, 308);
            this.TH_kqFile.Name = "TH_kqFile";
            this.TH_kqFile.Size = new System.Drawing.Size(204, 29);
            this.TH_kqFile.TabIndex = 3;
            this.TH_kqFile.Text = "Kết quả đọc từ file";
            // 
            // MH_Nhap_Ghi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(623, 473);
            this.Controls.Add(this.TH_kqFile);
            this.Controls.Add(this.TH_DongY);
            this.Controls.Add(this.TH_NhapGhi);
            this.Controls.Add(this.TH_kq);
            this.Name = "MH_Nhap_Ghi";
            this.Text = "MH_Nhap_Ghi";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TH_kq;
        private System.Windows.Forms.TextBox TH_NhapGhi;
        private System.Windows.Forms.Button TH_DongY;
        private System.Windows.Forms.Label TH_kqFile;
    }
