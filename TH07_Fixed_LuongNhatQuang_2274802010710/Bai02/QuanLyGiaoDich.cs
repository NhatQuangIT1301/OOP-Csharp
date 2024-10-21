using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai02
{
    internal class QuanLyGiaoDich
    {
        private ThongTinGiaoDich[] LichSuGD;

        public void NhapTTGiaoDich()
        {
            int n, loai;
            Console.Write("So luong giao dich can thuc hien: ");
            n = Convert.ToInt32(Console.ReadLine());
            LichSuGD = new ThongTinGiaoDich[n];

            for (int i = 0; i < LichSuGD.Length; i++)
            {
                Console.Write("Giao dich vang (0) hay giao dich tien te (1): ");
                loai = Convert.ToInt32(Console.ReadLine());
                if (loai == 0)
                {
                    LichSuGD[i] = new GiaoDichVang();
                }
                else if (loai == 1)
                {
                    LichSuGD[i] = new GiaoDichTienTe();
                }
                else { Console.WriteLine("Khong hop le!"); }
                LichSuGD[i].Nhap();
            }
        }

        public void XuatLichSu_GiaoDich()
        {
            Console.WriteLine("-----Lich su giao dich vang-----");
            for (int i = 0; i < LichSuGD.Length; i++)
            {
                if (LichSuGD[i] is GiaoDichVang)
                {
                    LichSuGD[i].Xuat();
                }
            }

            Console.WriteLine("-----Lich su giao dich tien te-----");
            for (int i = 0; i < LichSuGD.Length; i++)
            {
                if (LichSuGD[i] is GiaoDichTienTe)
                {
                    LichSuGD[i].Xuat();
                }
            }
        }

        public void Sum_SL_TungLoai()
        {
            Console.WriteLine("-----Tong so luong cua cac loai giao dich-----");
            float sumGDV = 0.0f, sumGDTT = 0.0f;
            for (int i = 0; i < LichSuGD.Length; i++)
            {
                if (LichSuGD[i] is GiaoDichVang)
                {
                    sumGDV += LichSuGD[i].SoLuong;
                }
            }
            Console.WriteLine($"Tong so luong cua giao dich vang la: {sumGDV}");
            for (int i = 0; i < LichSuGD.Length; i++)
            {
                if (LichSuGD[i] is GiaoDichTienTe)
                {
                    sumGDTT += LichSuGD[i].SoLuong;
                }
            }
            Console.WriteLine($"Tong so luong cua giao dich tien te la: {sumGDTT}");
        }

        public void Tinh_TB_TTien()
        {
            Console.WriteLine("-----Trung binh thanh tien cua giao dich tien te!-----");
            float sumTTien = 0.0f;
            int sluong = 0;
            foreach (ThongTinGiaoDich gd in LichSuGD)
            {
                if (gd is GiaoDichTienTe)
                {
                    sumTTien += gd.ThanhTien();
                    sluong++;
                }
            }

            Console.WriteLine($"Ket qua: {(sumTTien / sluong):N0}");
        }

        public void Xuat_TTGD_Hon1ty()
        {
            Console.WriteLine("-----Giao dich co thanh tien tren 1 ty-----");
            foreach (ThongTinGiaoDich gd in LichSuGD)
            {
                if ( gd.ThanhTien() > 1000000000)
                {
                    Console.WriteLine($"Ma giao dich {gd.MaGiaoDich} co thanh tien tren 1 ty dong: {gd.ThanhTien():N0}");
                }
            }
        }
    }
}