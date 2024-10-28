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
    public partial class FormMayTinhCoBan : Form
    {
        public FormMayTinhCoBan()
        {
            InitializeComponent();
        }

        private void btncong_Click(object sender, EventArgs e)
        {
            float a = Convert.ToSingle(so1.Text);
            float b = Convert.ToSingle(so2.Text);
            float kq = a + b;
            ketqua.Text = kq.ToString();
        }

        private void btntru_Click(object sender, EventArgs e)
        {
            float a = Convert.ToSingle(so1.Text);
            float b = Convert.ToSingle(so2.Text);
            float kq = a - b;
            ketqua.Text = kq.ToString();
        }

        private void btnnhan_Click(object sender, EventArgs e)
        {
            float a = Convert.ToSingle(so1.Text);
            float b = Convert.ToSingle(so2.Text);
            float kq = a * b;
            ketqua.Text = kq.ToString();
        }

        private void btnchia_Click(object sender, EventArgs e)
        {
            float a = Convert.ToSingle(so1.Text);
            float b = Convert.ToSingle(so2.Text);
            float kq = a / b;
            ketqua.Text = kq.ToString();
        }
    }
}
