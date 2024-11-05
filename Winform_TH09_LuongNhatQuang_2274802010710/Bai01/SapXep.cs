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
    public partial class SapXep : Form
    {
        private Form form1;
        private string kieuSapXep;
        public SapXep()
        {
            InitializeComponent();
        }

        public SapXep(Form Form1)
        {
            InitializeComponent();
            form1 = Form1;
        }

        public string KieuSapXep { get => kieuSapXep; set => kieuSapXep = value; }

        private void SapXep_Load(object sender, EventArgs e)
        {
            cbSapXep.Items.Add("Sắp Xếp Tăng Dần");
            cbSapXep.Items.Add("Sắp Xếp Giảm Dần");
            cbSapXep.SelectedIndex = 0;
        }

        private void btnSapXep_Click(object sender, EventArgs e)
        {
            kieuSapXep = cbSapXep.Text;
            form1.Show();
            this.Close();
            cbSapXep.Items.Clear();
        }
    }
}
