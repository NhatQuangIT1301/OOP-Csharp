using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            QuanLyGiaoDich arrGiaoDich = new QuanLyGiaoDich();
            arrGiaoDich.NhapTTGiaoDich();
            arrGiaoDich.XuatLichSu_GiaoDich();
            arrGiaoDich.Sum_SL_TungLoai();
            arrGiaoDich.Tinh_TB_TTien();
            arrGiaoDich.Xuat_TTGD_Hon1ty();
        }
    }
}