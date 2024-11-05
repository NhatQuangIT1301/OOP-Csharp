using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai01
{
    public partial class TimKiem : Form
    {
        private Form form1;

        private string ketQua, tieuChi;

        public TimKiem()
        {
            InitializeComponent();
        }

        public TimKiem(Form Form1)
        {
            InitializeComponent();
            form1 = Form1;
        }

        public string KetQua { get => ketQua; set => ketQua = value; }
        public string TieuChi { get => tieuChi; set => tieuChi = value; }

        private void btnTim_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtDuLieu.Text))
                MessageBox.Show("Vui lòng điền thông tin cần tìm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else {
                ketQua = txtDuLieu.Text;
                tieuChi = cbTieuChi.Text;
                form1.Show();
                this.Close();
                cbTieuChi.Items.Clear();
            }
        }

        private void TimKiem_Load(object sender, EventArgs e)
        {
            cbTieuChi.Items.Add("Tìm Kiếm Theo Mã");
            cbTieuChi.Items.Add("Tìm Kiếm Theo Tên");
            cbTieuChi.SelectedIndex = 0;
        }
    }
}
