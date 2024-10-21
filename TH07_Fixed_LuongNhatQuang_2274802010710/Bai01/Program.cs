using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ThuVienX arrSach = new ThuVienX();
            arrSach.NhapTTSach();
            arrSach.XuatTTSach();
            arrSach.Sum_TTien_TungLoai();
            Console.WriteLine($"Trung binh cong don gia sach tham khao: {arrSach.Tinh_TBCong()}");
            arrSach.Tim_TenNXB();
        }
    }
}
