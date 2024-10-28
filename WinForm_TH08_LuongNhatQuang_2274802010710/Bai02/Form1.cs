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
        public Form1()
        {
            InitializeComponent();
        }

        private void Tinhnghiem_Click(object sender, EventArgs e)
        {
            float a = Convert.ToSingle(txta.Text);
            float b = Convert.ToSingle(txtb.Text);
            float kq = -b / a;
            ketqua.Text = kq.ToString();
        }
    }
}
