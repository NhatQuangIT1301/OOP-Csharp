namespace Bai02
{
    partial class Form1
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
            this.txta = new System.Windows.Forms.TextBox();
            this.ketqua = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Tinhnghiem = new System.Windows.Forms.Button();
            this.txtb = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tham số a";
            // 
            // txta
            // 
            this.txta.Location = new System.Drawing.Point(134, 69);
            this.txta.Name = "txta";
            this.txta.Size = new System.Drawing.Size(126, 22);
            this.txta.TabIndex = 1;
            // 
            // ketqua
            // 
            this.ketqua.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ketqua.Location = new System.Drawing.Point(134, 276);
            this.ketqua.Name = "ketqua";
            this.ketqua.ReadOnly = true;
            this.ketqua.Size = new System.Drawing.Size(126, 22);
            this.ketqua.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(57, 279);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Nghiệm";
            // 
            // Tinhnghiem
            // 
            this.Tinhnghiem.Location = new System.Drawing.Point(60, 205);
            this.Tinhnghiem.Name = "Tinhnghiem";
            this.Tinhnghiem.Size = new System.Drawing.Size(200, 30);
            this.Tinhnghiem.TabIndex = 6;
            this.Tinhnghiem.Text = "Tính nghiệm";
            this.Tinhnghiem.UseVisualStyleBackColor = true;
            this.Tinhnghiem.Click += new System.EventHandler(this.Tinhnghiem_Click);
            // 
            // txtb
            // 
            this.txtb.Location = new System.Drawing.Point(134, 133);
            this.txtb.Name = "txtb";
            this.txtb.Size = new System.Drawing.Size(126, 22);
            this.txtb.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(57, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Tham số b";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(318, 350);
            this.Controls.Add(this.txtb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Tinhnghiem);
            this.Controls.Add(this.ketqua);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txta);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txta;
        private System.Windows.Forms.TextBox ketqua;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Tinhnghiem;
        private System.Windows.Forms.TextBox txtb;
        private System.Windows.Forms.Label label2;
    }
}

