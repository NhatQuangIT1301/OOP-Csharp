using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai01
{
    internal class SachCacLoai
    {
        protected String nhaXuatBan;
        protected DateTime ngayNhap;
        protected float donGia;
        protected int soLuong;
        protected string maSach;

        public string MaSach { get => maSach; set => maSach = value; }
        public string NhaXuatBan { get => nhaXuatBan; set => nhaXuatBan = value; }
        public DateTime NgayNhap { get => ngayNhap; set => ngayNhap = value; }
        public float DonGia { get => donGia; set => donGia = value; }
        public int SoLuong { get => soLuong; set => soLuong = value; }

        public virtual void Nhap()
        {
            Console.Write("Ma sach: ");
            MaSach = Console.ReadLine();
            Console.Write("Ngay nhap: ");
            NgayNhap = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", null);
            Console.Write("Don gia: ");
            DonGia = Convert.ToSingle(Console.ReadLine());
            Console.Write("So luong: ");
            SoLuong = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nha xuat ban: ");
            NhaXuatBan = Console.ReadLine();
        }

        public virtual void Xuat()
        {
            Console.Write($"{MaSach}\t{NgayNhap.ToString("MMM dd,yyyy")}\t{DonGia}\t{SoLuong}\t{NhaXuatBan}");
        }

        public virtual float ThanhTien()
        {
            return 0;
        }
    }
}
