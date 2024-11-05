namespace Bai01
{
    partial class SapXep
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
            this.btnSapXep = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cbSapXep = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnSapXep
            // 
            this.btnSapXep.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSapXep.Location = new System.Drawing.Point(33, 146);
            this.btnSapXep.Name = "btnSapXep";
            this.btnSapXep.Size = new System.Drawing.Size(449, 39);
            this.btnSapXep.TabIndex = 0;
            this.btnSapXep.Text = "OK";
            this.btnSapXep.UseVisualStyleBackColor = true;
            this.btnSapXep.Click += new System.EventHandler(this.btnSapXep_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(29, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Chọn lựa kiểu sắp xếp";
            // 
            // cbSapXep
            // 
            this.cbSapXep.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSapXep.FormattingEnabled = true;
            this.cbSapXep.Location = new System.Drawing.Point(250, 64);
            this.cbSapXep.Name = "cbSapXep";
            this.cbSapXep.Size = new System.Drawing.Size(232, 28);
            this.cbSapXep.TabIndex = 2;
            // 
            // SapXep
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(511, 254);
            this.Controls.Add(this.cbSapXep);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSapXep);
            this.Name = "SapXep";
            this.Text = "Sắp Xếp Theo Hệ Số Lương";
            this.Load += new System.EventHandler(this.SapXep_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSapXep;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbSapXep;
    }
}