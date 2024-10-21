using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai02
{
    internal class GiaoDichTienTe:ThongTinGiaoDich
    {
        private float tiGia;
        private string loaiTienTe;

        public float TiGia { get => tiGia; set => tiGia = value; }
        public string LoaiTienTe { get => loaiTienTe; set => loaiTienTe = value; }

        public override void Nhap()
        {
            base.Nhap();
            Console.Write("Loai tien te (VN/USD/EURO): ");
            loaiTienTe = Console.ReadLine();
            loaiTienTe = loaiTienTe.ToUpper();
            if (loaiTienTe == "USD" || loaiTienTe == "EURO")
            {
                Console.Write("Ti gia: ");
                tiGia = Convert.ToSingle(Console.ReadLine());
            }
            else if (loaiTienTe == "VN") 
            { 
                tiGia = 1; 
            }
            else { Console.WriteLine("Loai tien te khong hop le!"); }
        }

        public override void Xuat()
        {
            base.Xuat();
            Console.WriteLine($"\t{tiGia}\t{loaiTienTe}");
        }

        public override float ThanhTien()
        {
            float thanhtien = 0;
            if (loaiTienTe == "VN")
            {
                thanhtien = soLuong * donGia;
            }
            else if (loaiTienTe == "USD" || loaiTienTe == "EURO")
            {
                thanhtien = soLuong * donGia * tiGia;
            }
            else
            {
                Console.WriteLine("Loai tien te khong hop le!");
            }
            return thanhtien;
        }
    }
}