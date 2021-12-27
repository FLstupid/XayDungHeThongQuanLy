using System;
using System.Collections.Generic;
using System.Text;

namespace FinalExam.People
{
    class CuuSinhVien: SinhVien
    {
        string namTotNghiep;
        public string NamTotNghiep
        {
            get => namTotNghiep;
            set => namTotNghiep = value;
        }
        public CuuSinhVien()
        {
            namTotNghiep = "";
            MaSoSinhVien = 0;
            NganhHoc = "";
        }
        public CuuSinhVien(CuuSinhVien cuuSinhVien) : this(cuuSinhVien.MaSoSinhVien, cuuSinhVien.Ho, cuuSinhVien.Ten, cuuSinhVien.NgaySinh, cuuSinhVien.GioiTinh, cuuSinhVien.SoDT, cuuSinhVien.NganhHoc, cuuSinhVien.NamTotNghiep)
        {
        }

        public CuuSinhVien(int maSoSinhVien, string ho, string ten, string ngaySinh, string gioiTinh, string soDT, string nganhHoc, string namTotnghiep)
        {
            MaSoSinhVien = maSoSinhVien;
            Ho = ho;
            Ten = ten;
            NgaySinh = ngaySinh;
            GioiTinh = gioiTinh;
            SoDT = soDT;
            NganhHoc = nganhHoc;
            NamTotNghiep = namTotnghiep;
        }
        public override void Display()
        {
            
        }
        public override void Search()
        {
            
        }
        public override void Delete()
        {
            
        }
    }
}
