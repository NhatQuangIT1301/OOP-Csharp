using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai02
{
    public partial class Form1 : Form
    {
        private static float tongtien = 0;
        public Form1()
        {
            InitializeComponent();
            this.KeyPreview = true;
            this.KeyDown += new KeyEventHandler(Form1_KeyDown);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cbKHUVUC.Items.Add("Khu vực 1");
            cbKHUVUC.Items.Add("Khu vực 2");
            cbKHUVUC.Items.Add("Khu vực 3");
            cbKHUVUC.SelectedIndex = 0;
            txtHOTEN.Focus();
        }

        private void cbKHUVUC_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cbKHUVUC.Text)
            {
                case "Khu vực 1":
                    txtDINHMUC.Text = "50";
                    break;
                case "Khu vực 2":
                    txtDINHMUC.Text = "100";
                    break;
                case "Khu vực 3":
                    txtDINHMUC.Text = "150";
                    break;
            }
        }

        private void btnTHOAT_Click(object sender, EventArgs e)
        {
            DialogResult xacnhan = MessageBox.Show("Bạn có chắc muốn thoát!", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            
            if (xacnhan == DialogResult.OK)
                this.Close();
        }

        private void btnTINHTIEN_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtHOTEN.Text) || string.IsNullOrEmpty(txtSOCU.Text) || string.IsNullOrEmpty(txtSOMOI.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string hoten = txtHOTEN.Text;
                string khuvuc = cbKHUVUC.Text;
                int dinhmuc = Convert.ToInt32(txtDINHMUC.Text);
                float socu, somoi, tieuthu, thanhtien;
                socu = Convert.ToSingle(txtSOCU.Text);
                somoi = Convert.ToSingle(txtSOMOI.Text);
                tieuthu = somoi - socu;
                thanhtien = 0;

                if (tieuthu <= dinhmuc)
                {
                    thanhtien = 500 * tieuthu;
                }
                else
                {
                    thanhtien = 1000 * tieuthu;
                }

                txtTIEUTHU.Text = Convert.ToString(tieuthu);
                txtTHANHTIEN.Text = Convert.ToString(thanhtien);

                ThongTinNguoiTieuDung ngdung = new ThongTinNguoiTieuDung(hoten, khuvuc, dinhmuc, tieuthu, thanhtien);
                ListViewItem item = new ListViewItem();
                item.Text = ngdung.HoTen;
                item.SubItems.Add(ngdung.KhuVuc);
                item.SubItems.Add(ngdung.DinhMuc.ToString());
                item.SubItems.Add(ngdung.TieuThu.ToString());
                item.SubItems.Add(ngdung.ThanhTien.ToString());
                lvTHONGTIN.Items.Add(item);

                tongtien += thanhtien;

                txtTONGTIEN.Text = Convert.ToString(tongtien);
            }
        }

        private void btnNHAPMOI_Click(object sender, EventArgs e)
        {
            lvTHONGTIN.Items.Clear();
            txtHOTEN.Clear();
            cbKHUVUC.SelectedIndex = 0;
            txtSOCU.Clear();
            txtSOMOI.Clear();
            txtTIEUTHU.Clear();
            txtTHANHTIEN.Clear();
            txtTONGTIEN.Clear();
            txtHOTEN.Focus();
        }

        private void btnXOA_Click(object sender, EventArgs e)
        {
            if (lvTHONGTIN.SelectedItems.Count > 0)
            {
                int i = lvTHONGTIN.SelectedItems[0].Index;
                float tienxoa = Convert.ToSingle(lvTHONGTIN.Items[i].SubItems[4].Text);
                tongtien = tongtien - tienxoa;
                lvTHONGTIN.Items.RemoveAt(i);
            }
            txtTONGTIEN.Text = Convert.ToString(tongtien);
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnTINHTIEN.PerformClick();
            }
        }
    }
}
