using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai01
{
    internal class cNhanVien
    {
        private string maNV, hoTenNV, phongBan;
        private DateTime ngaySinh;
        private float heSoLuong;
        private bool gioiTinh;

        public cNhanVien() { }

        public cNhanVien(string maNV, string hoTenNV, string phongBan, DateTime ngaySinh, float heSoLuong, bool gioiTinh)
        {
            this.maNV = maNV;
            this.hoTenNV = hoTenNV;
            this.phongBan = phongBan;
            this.ngaySinh = ngaySinh;
            this.heSoLuong = heSoLuong;
            this.gioiTinh = gioiTinh;
        }

        public string MaNV { get => maNV; set => maNV = value; }
        public string HoTenNV { get => hoTenNV; set => hoTenNV = value; }
        public string PhongBan { get => phongBan; set => phongBan = value; }
        public DateTime NgaySinh { get => ngaySinh; set => ngaySinh = value; }
        public float HeSoLuong { get => heSoLuong; set => heSoLuong = value; }
        public bool GioiTinh { get => gioiTinh; set => gioiTinh = value; }
    }
}
