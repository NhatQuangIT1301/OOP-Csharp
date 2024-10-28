using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai04
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTinh_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtDiemToan.Text) || string.IsNullOrEmpty(txtDiemLy.Text) || string.IsNullOrEmpty(txtDiemHoa.Text) || string.IsNullOrEmpty(txtHoTen.Text))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin!");
            }
            else
            {
                string thongbao = "";
                float toan = Convert.ToSingle(txtDiemToan.Text);
                float ly = Convert.ToSingle(txtDiemLy.Text);
                float hoa = Convert.ToSingle(txtDiemHoa.Text);

                float DTB = (toan + ly + hoa) / 3;

                if (9 <= DTB && DTB <= 10)
                    thongbao = "Xuất Sắc";
                else if (8 <= DTB && DTB < 9)
                    thongbao = "Giỏi";
                else if (7 <= DTB && DTB < 8)
                    thongbao = "Khá";
                else if (6 <= DTB && DTB < 7)
                    thongbao = "Trung Bình Khá";
                else if (5 <= DTB && DTB < 6)
                    thongbao = "Trung Bình";
                else if (2 <= DTB && DTB < 5)
                    thongbao = "Yếu";
                else if (0 <= DTB && DTB < 2)
                    thongbao = "Kém";
                else
                    thongbao = "Điểm nhập không hợp lệ!";

                txtDiemTrungBinh.Text = DTB.ToString();
                lblXepLoai.Text = thongbao;
            }
        }
    }
}
