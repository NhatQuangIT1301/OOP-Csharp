using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai03
{
    public partial class Form1 : Form
    {
        int i = -1;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            value.Focus();
        }

        private void add_Click(object sender, EventArgs e)
        {
            lbDanhSach.Items.Add(value.Text);
            value.Text = "";
            value.Focus();
        }

        private void delete_Click(object sender, EventArgs e)
        {
            lbDanhSach.Items.Remove(value.Text);
            value.Text = "";
            value.Focus();
        }

        private void fix_Click(object sender, EventArgs e)
        {
            lbDanhSach.Items[i] = value.Text;
        }

        private void solve_Click(object sender, EventArgs e)
        {
            int n = lbDanhSach.Items.Count;
            object[] arr = new object[n];
            lbDanhSach.Items.CopyTo(arr, 0);

            int sum = 0;
            for (int i = 0; i < n; i++)
            {
                sum += Convert.ToInt32(arr[i].ToString());
            }
            ketqua.Text = ((float)sum / arr.Length).ToString();
        }

        private void lbDanhSach_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbDanhSach.SelectedItem != null)
            {
                value.Text = lbDanhSach.SelectedItem.ToString();
                i = lbDanhSach.SelectedIndex;
            }
        }
    }
}
