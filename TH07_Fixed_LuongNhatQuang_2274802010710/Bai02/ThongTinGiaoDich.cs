using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai02
{
    internal class ThongTinGiaoDich
    {
        protected string maGiaoDich;
        protected DateTime ngayGiaoDich;
        protected float donGia;
        protected int soLuong;

        public string MaGiaoDich { get => maGiaoDich; set => maGiaoDich = value; }
        public DateTime NgayGiaoDich { get => ngayGiaoDich; set => ngayGiaoDich = value; }
        public float DonGia { get => donGia; set => donGia = value; }
        public int SoLuong { get => soLuong; set => soLuong = value; }

        public virtual void Nhap()
        {
            Console.Write("Ma giao dich: ");
            maGiaoDich = Console.ReadLine();
            Console.Write("Ngay giao dich: ");
            ngayGiaoDich = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", null);
            Console.Write("Don gia: ");
            donGia = Convert.ToSingle(Console.ReadLine());
            Console.Write("So luong: ");
            soLuong = Convert.ToInt32(Console.ReadLine());
        }

        public virtual void Xuat()
        {
            Console.Write($"{MaGiaoDich}\t{NgayGiaoDich.ToString("MMM dd,yyyy")}\t{DonGia}\t{SoLuong}");
        }

        public virtual float ThanhTien()
        {
            return 0;
        }
    }
}