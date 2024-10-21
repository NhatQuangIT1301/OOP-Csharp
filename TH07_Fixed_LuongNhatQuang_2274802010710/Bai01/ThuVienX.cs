using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai01
{
    internal class ThuVienX
    {
        private SachCacLoai[] arrSach;

        public void NhapTTSach()
        {
            int n, loai;
            Console.Write("So luong sach can them: ");
            n = Convert.ToInt32(Console.ReadLine());
            arrSach = new SachCacLoai[n];

            for (int i = 0; i < arrSach.Length; i++)
            {
                Console.Write("Sach tham khao (0) hay sach giao khoa (1): ");
                loai = Convert.ToInt32(Console.ReadLine());
                if (loai == 0)
                {
                    arrSach[i] = new SachThamKhao();
                }
                else if (loai == 1)
                {
                    arrSach[i] = new SachGiaoKhoa();
                }
                else { Console.WriteLine("Khong hop le!"); }
                arrSach[i].Nhap();
            }
        }

        public void XuatTTSach()
        {
            Console.WriteLine("-----Sach tham khao-----");
            for (int i = 0;i < arrSach.Length; i++)
            {
                if (arrSach[i] is SachThamKhao)
                {
                    arrSach[i].Xuat();
                }
            }

            Console.WriteLine("-----Sach giao khoa-----");
            for (int i = 0; i < arrSach.Length; i++)
            {
                if (arrSach[i] is SachGiaoKhoa)
                {
                    arrSach[i].Xuat();
                }
            }
        }

        public void Sum_TTien_TungLoai()
        {
            float sumSTK = 0.0f, sumSGK = 0.0f;
            for (int i = 0; i < arrSach.Length ; i++)
            {
                if (arrSach[i] is SachThamKhao)
                {
                    sumSTK += arrSach[i].ThanhTien();
                }
            }
            Console.WriteLine($"Tong thanh tien cua loai SACH THAM KHAO la: {sumSTK}");
            for (int i = 0; i < arrSach.Length; i++)
            {
                if (arrSach[i] is SachGiaoKhoa)
                {
                    sumSGK += arrSach[i].ThanhTien();
                }
            }
            Console.WriteLine($"Tong thanh tien cua loai SACH GIAO KHOA la: {sumSGK}");
        }

        public float Tinh_TBCong()
        {
            float sumDG = 0.0f;
            int sluong = 0;
            foreach (SachCacLoai s in arrSach)
            {
                if (s is SachThamKhao)
                {
                    sumDG += s.DonGia;
                    sluong++;
                }
            }

            return sumDG / sluong;
        }

        public void Tim_TenNXB()
        {
            Console.WriteLine("-*-*-Tim sach-*-*-");
            string tenNXB;
            Console.Write("Ten nha xuat ban: ");
            tenNXB = Console.ReadLine();

            for (int i = 0; i < arrSach.Length; i++)
            {
                if (tenNXB == arrSach[i].NhaXuatBan && arrSach[i] is SachGiaoKhoa)
                {
                    arrSach[i].Xuat();
                }
            }
        }
    }
}
