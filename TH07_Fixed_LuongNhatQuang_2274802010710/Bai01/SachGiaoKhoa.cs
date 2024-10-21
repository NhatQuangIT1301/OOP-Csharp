using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai01
{
    internal class SachGiaoKhoa:SachCacLoai
    {
        private string tinhTrang;

        public double 

        public string TinhTrang { get => tinhTrang; set => tinhTrang = value; }

        public override void Nhap()
        {
            base.Nhap();
            Console.Write("Tinh trang sach: ");
            tinhTrang = Console.ReadLine();
            tinhTrang = tinhTrang.ToLower();
        }

        public override void Xuat()
        {
            base.Xuat();
            Console.WriteLine($"\t{TinhTrang}");
        }

        public override float ThanhTien()
        {
            float ThanhTien = 0;
            if ( tinhTrang == "moi" )
            {
                ThanhTien = soLuong * donGia;
            }
            else if ( tinhTrang == "cu")
            {
                ThanhTien = soLuong * donGia * 0.5f;
            }
            else
            {
                Console.WriteLine("Thong tin khong hop le!");
                //Nhap();
            }
            return ThanhTien;
        }
    }
}
