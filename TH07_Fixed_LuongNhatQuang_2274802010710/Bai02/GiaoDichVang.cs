using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai02
{
    internal class GiaoDichVang:ThongTinGiaoDich
    {
        private string loaiVang;

        public string LoaiVang { get => loaiVang; set => loaiVang = value; }

        public override void Nhap()
        {
            base.Nhap();
            Console.Write("Loai vang: ");
            loaiVang = Console.ReadLine();
        }

        public override void Xuat()
        {
            base.Xuat();
            Console.WriteLine($"\t{LoaiVang}");
        }

        public override float ThanhTien()
        {
            return soLuong * donGia;
        }
    }
}