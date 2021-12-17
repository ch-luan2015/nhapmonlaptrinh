
    partial class MH_Khai_Bao_Xu_Ly
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
            this.MH_KhaiBao = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // MH_KhaiBao
            // 
            this.MH_KhaiBao.AutoSize = true;
            this.MH_KhaiBao.Location = new System.Drawing.Point(182, 32);
            this.MH_KhaiBao.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.MH_KhaiBao.Name = "MH_KhaiBao";
            this.MH_KhaiBao.Size = new System.Drawing.Size(194, 28);
            this.MH_KhaiBao.TabIndex = 0;
            this.MH_KhaiBao.Text = "Khai Báo Xử Lý";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(36, 120);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(128, 48);
            this.button1.TabIndex = 1;
            this.button1.Text = "Khai Báo Xử Lý";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // MH_Khai_Bao_Xu_Ly
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 371);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.MH_KhaiBao);
            this.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "MH_Khai_Bao_Xu_Ly";
            this.Text = "MH_Khai_Bao_Xu_Ly";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label MH_KhaiBao;
        private System.Windows.Forms.Button button1;
    }
