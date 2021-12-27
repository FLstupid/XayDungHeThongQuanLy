using FinalExam.People;
using System;
using System.Collections.Generic;
using System.Text;

namespace FinalExam.Other
{
    class KhoaHoc
    {
        string tenKhoaHoc;
        int maKhoaHoc;
        string nienKhoa;
        string namNhapHoc;
        List<SinhVien> ListSv;
        public string TenKhoaHoc
        {
            get => tenKhoaHoc;
            set => tenKhoaHoc = value;
        }
        public int MaKhoaHoc
        {
            get => maKhoaHoc;
            set => maKhoaHoc = value;
        }
        public string NienKhoa
        {
            get => nienKhoa;
            set => nienKhoa = value;
        }
        public string NamNhapHoc
        {
            get => namNhapHoc;
            set => namNhapHoc = value;
        }
        public List<SinhVien> ListSv1 { get => ListSv; set => ListSv = value; }

        public KhoaHoc(int maKhoaHoc, string tenKhoaHoc, string nienKhoa, string namNhapHoc, List<SinhVien> ListSv)
        {
            this.tenKhoaHoc = tenKhoaHoc;
            this.maKhoaHoc = maKhoaHoc;
            this.nienKhoa = nienKhoa;
            this.namNhapHoc = namNhapHoc;
            this.ListSv = ListSv;
        }
        public KhoaHoc(KhoaHoc khoahoc) : this( khoahoc.maKhoaHoc, khoahoc.tenKhoaHoc, khoahoc.nienKhoa,
                                         khoahoc.namNhapHoc, khoahoc.ListSv)
        {
        }
        public KhoaHoc()
        {
            tenKhoaHoc = "";
            maKhoaHoc = 0;
            nienKhoa = "";
            namNhapHoc = "";
        }
    }
}
