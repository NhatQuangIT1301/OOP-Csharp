using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai01
{
    internal class SachThamKhao:SachCacLoai
    {
        private float thue;

        public float Thue { get => thue; set => thue = value; }

        public override void Nhap()
        {
            base.Nhap();
            Console.Write("Thue (%): ");
            Thue = Convert.ToSingle(Console.ReadLine());
        }

        public override void Xuat()
        {
            base.Xuat();
            Console.WriteLine($"\t{Thue}%");
        }

        public override float ThanhTien()
        {
            return soLuong * donGia + (thue/100);
        }
    }
}
