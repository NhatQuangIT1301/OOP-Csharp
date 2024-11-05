using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai01
{
    public partial class Form1 : Form
    {
        private TimKiem timKiem;
        private SapXep sapXep;
        public Form1()
        {
            InitializeComponent();
            timKiem = new TimKiem(this);
            sapXep = new SapXep(this);
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaNV.Text))
            {
                MessageBox.Show("Vui lòng nhập mã nhân viên!","Thông báo", MessageBoxButtons.OK,MessageBoxIcon.Error);
                txtMaNV.Focus();
                return;
            }
            if (string.IsNullOrEmpty(txtTenNV.Text))
            {
                MessageBox.Show("Vui lòng nhập tên nhân viên!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTenNV.Focus();
                return;
            }
            if (string.IsNullOrEmpty(txtHSL.Text))
            {
                MessageBox.Show("Vui lòng nhập hệ số lương!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtHSL.Focus();
                return;
            }
            cNhanVien nv = new cNhanVien(txtMaNV.Text.Trim(), txtTenNV.Text.Trim(), cbPB.Text, dtNgaySinh.Value, Convert.ToSingle(txtHSL.Text.Trim()), rdbNam.Checked);

            ListViewItem item = new ListViewItem();
            item.Text = nv.MaNV;
            item.SubItems.Add(nv.HoTenNV);
            item.SubItems.Add(nv.GioiTinh==true?"Nam":"Nữ");
            item.SubItems.Add(nv.NgaySinh.ToString("dd/MM/yyyy"));
            item.SubItems.Add(nv.HeSoLuong.ToString());
            item.SubItems.Add(nv.PhongBan);
            ListViewItems.Items.Add(item);

            txtMaNV.Clear();
            txtTenNV.Clear();
            txtHSL.Clear();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cbPB.Items.Add("Tiếp tân");
            cbPB.Items.Add("Kế toán");
            cbPB.Items.Add("Nhân sự");
            cbPB.Items.Add("Kinh doanh");
            cbPB.SelectedIndex = 0;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult dlrs = MessageBox.Show("Bạn có muốn thoát?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dlrs == DialogResult.OK)
                this.Close();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (ListViewItems.SelectedItems.Count > 0)
            {
                int i = ListViewItems.SelectedItems[0].Index;
                ListViewItems.Items.RemoveAt(i);
            }
        }

        private void ListViewItems_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ListViewItems.SelectedItems.Count > 0)
            {
                ListViewItem item = ListViewItems.SelectedItems[0];
                txtMaNV.Text = item.Text;
                txtTenNV.Text = item.SubItems[1].Text;
                if (item.SubItems[2].Text == "Nam")
                    rdbNam.Checked = true;
                else
                    rdbNu.Checked = true;
                dtNgaySinh.Value = DateTime.ParseExact(item.SubItems[3].Text, "dd/MM/yyyy", CultureInfo.InvariantCulture);
                txtHSL.Text = item.SubItems[4].Text;
                cbPB.Text = item.SubItems[5].Text;
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaNV.Text))
            {
                MessageBox.Show("Vui lòng nhập mã nhân viên cần sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMaNV.Focus();
                return;
            }
            if (string.IsNullOrEmpty(txtTenNV.Text))
            {
                MessageBox.Show("Vui lòng nhập tên nhân viên cần sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTenNV.Focus();
                return;
            }
            if (string.IsNullOrEmpty(txtHSL.Text))
            {
                MessageBox.Show("Vui lòng nhập hệ số lương cần sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtHSL.Focus();
                return;
            }
            cNhanVien nv = new cNhanVien(txtMaNV.Text.Trim(), txtTenNV.Text.Trim(), cbPB.Text, dtNgaySinh.Value, Convert.ToSingle(txtHSL.Text.Trim()), rdbNam.Checked);
            if (ListViewItems.SelectedItems.Count > 0)
            {
                ListViewItem item = ListViewItems.SelectedItems[0];
                item.Text = nv.MaNV;
                item.SubItems[1].Text = nv.HoTenNV;
                item.SubItems[2].Text = (nv.GioiTinh == true ? "Nam" : "Nữ");
                item.SubItems[3].Text = (nv.NgaySinh.ToString("dd/MM/yyyy"));
                item.SubItems[4].Text = (nv.HeSoLuong.ToString());
                item.SubItems[5].Text = (nv.PhongBan);
            }
            else
            {
                MessageBox.Show("Vui lòng chọn thông tin cần sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            this.Hide();
            timKiem.ShowDialog();
            if (timKiem.TieuChi == "Tìm Kiếm Theo Mã")
            {
                ListViewItem item = ListViewItems.FindItemWithText(timKiem.KetQua);
                if (item != null)
                {
                    item.Selected = true;
                    item.EnsureVisible();
                }
                else
                {
                    MessageBox.Show("Không tìm thấy mã nhân viên: " + timKiem.KetQua, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else if (timKiem.TieuChi == "Tìm Kiếm Theo Tên")
            {
                string tenNV = timKiem.KetQua; 
                ListViewItem item = null;
                foreach (ListViewItem i in ListViewItems.Items)
                {
                    if (i.SubItems[1].Text == tenNV)
                    {
                        item = i;
                        break;
                    }
                }
                if (item != null)
                {
                    item.Selected = true;
                    item.EnsureVisible();
                }
                else
                {
                    MessageBox.Show("Không tìm thấy tên nhân viên: " + tenNV, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnSX_Click(object sender, EventArgs e)
        {
            this.Hide();
            sapXep.ShowDialog();

            if (sapXep.KieuSapXep == "Sắp Xếp Tăng Dần")
            {
                for (int i = 0; i < ListViewItems.Items.Count; i++)
                {
                    for (int j = ListViewItems.Items.Count - 1; j > i; j--)
                    {
                        float hsl_j1 = float.Parse(ListViewItems.Items[j-1].SubItems[4].Text);
                        float hsl_j = float.Parse(ListViewItems.Items[j].SubItems[4].Text);

                        if (hsl_j1 > hsl_j)
                        {
                            ListViewItem temp = (ListViewItem)ListViewItems.Items[j-1].Clone();
                            ListViewItems.Items[j-1] = (ListViewItem)ListViewItems.Items[j].Clone();
                            ListViewItems.Items[j] = temp;
                        }
                    }
                }
            }
            else if (sapXep.KieuSapXep == "Sắp Xếp Giảm Dần")
            {
                for (int i = 0; i < ListViewItems.Items.Count; i++)
                {
                    for (int j = ListViewItems.Items.Count - 1; j > i; j--)
                    {
                        float hsl_j1 = float.Parse(ListViewItems.Items[j - 1].SubItems[4].Text);
                        float hsl_j = float.Parse(ListViewItems.Items[j].SubItems[4].Text);

                        if (hsl_j1 < hsl_j)
                        {
                            ListViewItem temp = (ListViewItem)ListViewItems.Items[j - 1].Clone();
                            ListViewItems.Items[j - 1] = (ListViewItem)ListViewItems.Items[j].Clone();
                            ListViewItems.Items[j] = temp;
                        }
                    }
                }
            }
        }
    }
}
