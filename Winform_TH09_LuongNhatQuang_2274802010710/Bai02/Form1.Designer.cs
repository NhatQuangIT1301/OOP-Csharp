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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lvTHONGTIN = new System.Windows.Forms.ListView();
            this.HoTen = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.KhuVuc = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DinhMuc = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TieuThu = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ThanhTien = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cbKHUVUC = new System.Windows.Forms.ComboBox();
            this.txtHOTEN = new System.Windows.Forms.TextBox();
            this.txtDINHMUC = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSOCU = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSOMOI = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTIEUTHU = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtTHANHTIEN = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtTONGTIEN = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnTINHTIEN = new System.Windows.Forms.Button();
            this.btnNHAPMOI = new System.Windows.Forms.Button();
            this.btnTHOAT = new System.Windows.Forms.Button();
            this.btnXOA = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(90, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(321, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "BÁO CÁO TIÊU THỤ ĐIỆN";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "HỌ TÊN KH:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label3.Location = new System.Drawing.Point(12, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 22);
            this.label3.TabIndex = 2;
            this.label3.Text = "KHU VỰC:";
            // 
            // lvTHONGTIN
            // 
            this.lvTHONGTIN.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.HoTen,
            this.KhuVuc,
            this.DinhMuc,
            this.TieuThu,
            this.ThanhTien});
            this.lvTHONGTIN.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvTHONGTIN.FullRowSelect = true;
            this.lvTHONGTIN.GridLines = true;
            this.lvTHONGTIN.HideSelection = false;
            this.lvTHONGTIN.Location = new System.Drawing.Point(536, 19);
            this.lvTHONGTIN.Name = "lvTHONGTIN";
            this.lvTHONGTIN.Size = new System.Drawing.Size(687, 499);
            this.lvTHONGTIN.TabIndex = 3;
            this.lvTHONGTIN.UseCompatibleStateImageBehavior = false;
            this.lvTHONGTIN.View = System.Windows.Forms.View.Details;
            // 
            // HoTen
            // 
            this.HoTen.Text = "Họ tên";
            this.HoTen.Width = 150;
            // 
            // KhuVuc
            // 
            this.KhuVuc.Text = "Khu vực";
            this.KhuVuc.Width = 130;
            // 
            // DinhMuc
            // 
            this.DinhMuc.Text = "Định mức";
            this.DinhMuc.Width = 130;
            // 
            // TieuThu
            // 
            this.TieuThu.Text = "Tiêu thụ";
            this.TieuThu.Width = 130;
            // 
            // ThanhTien
            // 
            this.ThanhTien.Text = "Thành tiền";
            this.ThanhTien.Width = 140;
            // 
            // cbKHUVUC
            // 
            this.cbKHUVUC.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbKHUVUC.FormattingEnabled = true;
            this.cbKHUVUC.Location = new System.Drawing.Point(175, 148);
            this.cbKHUVUC.Name = "cbKHUVUC";
            this.cbKHUVUC.Size = new System.Drawing.Size(334, 28);
            this.cbKHUVUC.TabIndex = 4;
            this.cbKHUVUC.SelectedIndexChanged += new System.EventHandler(this.cbKHUVUC_SelectedIndexChanged);
            // 
            // txtHOTEN
            // 
            this.txtHOTEN.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHOTEN.Location = new System.Drawing.Point(175, 97);
            this.txtHOTEN.Name = "txtHOTEN";
            this.txtHOTEN.Size = new System.Drawing.Size(334, 27);
            this.txtHOTEN.TabIndex = 5;
            // 
            // txtDINHMUC
            // 
            this.txtDINHMUC.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDINHMUC.Location = new System.Drawing.Point(175, 203);
            this.txtDINHMUC.Name = "txtDINHMUC";
            this.txtDINHMUC.ReadOnly = true;
            this.txtDINHMUC.Size = new System.Drawing.Size(334, 27);
            this.txtDINHMUC.TabIndex = 7;
            this.txtDINHMUC.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 204);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 22);
            this.label4.TabIndex = 6;
            this.label4.Text = "ĐỊNH MỨC:";
            // 
            // txtSOCU
            // 
            this.txtSOCU.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSOCU.Location = new System.Drawing.Point(175, 268);
            this.txtSOCU.Name = "txtSOCU";
            this.txtSOCU.Size = new System.Drawing.Size(334, 27);
            this.txtSOCU.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 269);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 22);
            this.label5.TabIndex = 8;
            this.label5.Text = "SỐ CŨ:";
            // 
            // txtSOMOI
            // 
            this.txtSOMOI.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSOMOI.Location = new System.Drawing.Point(175, 329);
            this.txtSOMOI.Name = "txtSOMOI";
            this.txtSOMOI.Size = new System.Drawing.Size(334, 27);
            this.txtSOMOI.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 330);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 22);
            this.label6.TabIndex = 10;
            this.label6.Text = "SỐ MỚI:";
            // 
            // txtTIEUTHU
            // 
            this.txtTIEUTHU.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTIEUTHU.Location = new System.Drawing.Point(175, 399);
            this.txtTIEUTHU.Name = "txtTIEUTHU";
            this.txtTIEUTHU.ReadOnly = true;
            this.txtTIEUTHU.Size = new System.Drawing.Size(334, 27);
            this.txtTIEUTHU.TabIndex = 13;
            this.txtTIEUTHU.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(12, 400);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(108, 22);
            this.label7.TabIndex = 12;
            this.label7.Text = "TIÊU THỤ:";
            // 
            // txtTHANHTIEN
            // 
            this.txtTHANHTIEN.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTHANHTIEN.Location = new System.Drawing.Point(175, 463);
            this.txtTHANHTIEN.Name = "txtTHANHTIEN";
            this.txtTHANHTIEN.ReadOnly = true;
            this.txtTHANHTIEN.Size = new System.Drawing.Size(334, 27);
            this.txtTHANHTIEN.TabIndex = 15;
            this.txtTHANHTIEN.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(12, 464);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(135, 22);
            this.label8.TabIndex = 14;
            this.label8.Text = "THÀNH TIỀN:";
            // 
            // txtTONGTIEN
            // 
            this.txtTONGTIEN.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTONGTIEN.Location = new System.Drawing.Point(685, 544);
            this.txtTONGTIEN.Name = "txtTONGTIEN";
            this.txtTONGTIEN.ReadOnly = true;
            this.txtTONGTIEN.Size = new System.Drawing.Size(334, 27);
            this.txtTONGTIEN.TabIndex = 17;
            this.txtTONGTIEN.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(532, 545);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(124, 22);
            this.label9.TabIndex = 16;
            this.label9.Text = "TÔNG TIỀN:";
            // 
            // btnTINHTIEN
            // 
            this.btnTINHTIEN.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTINHTIEN.Location = new System.Drawing.Point(16, 535);
            this.btnTINHTIEN.Name = "btnTINHTIEN";
            this.btnTINHTIEN.Size = new System.Drawing.Size(151, 36);
            this.btnTINHTIEN.TabIndex = 18;
            this.btnTINHTIEN.Text = "TÍNH TIỀN";
            this.btnTINHTIEN.UseVisualStyleBackColor = true;
            this.btnTINHTIEN.Click += new System.EventHandler(this.btnTINHTIEN_Click);
            // 
            // btnNHAPMOI
            // 
            this.btnNHAPMOI.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNHAPMOI.Location = new System.Drawing.Point(188, 535);
            this.btnNHAPMOI.Name = "btnNHAPMOI";
            this.btnNHAPMOI.Size = new System.Drawing.Size(151, 36);
            this.btnNHAPMOI.TabIndex = 19;
            this.btnNHAPMOI.Text = "NHẬP MỚI";
            this.btnNHAPMOI.UseVisualStyleBackColor = true;
            this.btnNHAPMOI.Click += new System.EventHandler(this.btnNHAPMOI_Click);
            // 
            // btnTHOAT
            // 
            this.btnTHOAT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTHOAT.Location = new System.Drawing.Point(358, 535);
            this.btnTHOAT.Name = "btnTHOAT";
            this.btnTHOAT.Size = new System.Drawing.Size(151, 36);
            this.btnTHOAT.TabIndex = 20;
            this.btnTHOAT.Text = "THOÁT";
            this.btnTHOAT.UseVisualStyleBackColor = true;
            this.btnTHOAT.Click += new System.EventHandler(this.btnTHOAT_Click);
            // 
            // btnXOA
            // 
            this.btnXOA.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXOA.Location = new System.Drawing.Point(1072, 540);
            this.btnXOA.Name = "btnXOA";
            this.btnXOA.Size = new System.Drawing.Size(151, 36);
            this.btnXOA.TabIndex = 21;
            this.btnXOA.Text = "XOÁ";
            this.btnXOA.UseVisualStyleBackColor = true;
            this.btnXOA.Click += new System.EventHandler(this.btnXOA_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1246, 594);
            this.Controls.Add(this.btnXOA);
            this.Controls.Add(this.btnTHOAT);
            this.Controls.Add(this.btnNHAPMOI);
            this.Controls.Add(this.btnTINHTIEN);
            this.Controls.Add(this.txtTONGTIEN);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtTHANHTIEN);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtTIEUTHU);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtSOMOI);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtSOCU);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtDINHMUC);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtHOTEN);
            this.Controls.Add(this.cbKHUVUC);
            this.Controls.Add(this.lvTHONGTIN);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Tính tiền điện";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListView lvTHONGTIN;
        private System.Windows.Forms.ComboBox cbKHUVUC;
        private System.Windows.Forms.TextBox txtHOTEN;
        private System.Windows.Forms.TextBox txtDINHMUC;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSOCU;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSOMOI;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtTIEUTHU;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtTHANHTIEN;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtTONGTIEN;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnTINHTIEN;
        private System.Windows.Forms.Button btnNHAPMOI;
        private System.Windows.Forms.Button btnTHOAT;
        private System.Windows.Forms.Button btnXOA;
        private System.Windows.Forms.ColumnHeader HoTen;
        private System.Windows.Forms.ColumnHeader KhuVuc;
        private System.Windows.Forms.ColumnHeader DinhMuc;
        private System.Windows.Forms.ColumnHeader TieuThu;
        private System.Windows.Forms.ColumnHeader ThanhTien;
    }
}

