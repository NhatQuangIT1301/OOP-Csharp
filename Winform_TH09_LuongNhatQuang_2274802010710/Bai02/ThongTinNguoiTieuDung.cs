using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai02
{
    internal class ThongTinNguoiTieuDung
    {
        private string hoTen, khuVuc;
        private int dinhMuc;
        private float tieuThu, thanhTien;

        public ThongTinNguoiTieuDung() { }

        public ThongTinNguoiTieuDung(string HoTen, string KhuVuc, int DinhMuc, float TieuThu, float ThanhTien)
        {
            hoTen = HoTen;
            khuVuc = KhuVuc;
            dinhMuc = DinhMuc;
            tieuThu = TieuThu;
            thanhTien = ThanhTien;
        }

        public string HoTen { get => hoTen; set => hoTen = value; }
        public string KhuVuc { get => khuVuc; set => khuVuc = value; }
        public int DinhMuc { get => dinhMuc; set => dinhMuc = value; }
        public float TieuThu { get => tieuThu; set => tieuThu = value; }
        public float ThanhTien { get => thanhTien; set => thanhTien = value; }
    }
}
