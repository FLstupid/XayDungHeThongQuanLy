using FinalExam.People;
using System;
using System.Collections.Generic;
using System.Text;

namespace FinalExam.Other
{
    class MonHoc
    {
        int maMonHoc;
        string tenMonHoc;
        int soTinChi;
        string loaiMonHoc;
        int gioiHanSinhVien;
        int soLuongDangKi;
        int maGiangVien;
        string tenGiangVien;
        string thoiGianDay;
        string tietDau;
        string tietCuoi;

        public int MaMonHoc { get => maMonHoc; set => maMonHoc = value; }
        public string TenMonHoc { get => tenMonHoc; set => tenMonHoc = value; }
        public int SoTinChi { get => soTinChi; set => soTinChi = value; }
        public string LoaiMonHoc { get => loaiMonHoc; set => loaiMonHoc = value; }
        public int GioiHanSinhVien { get => gioiHanSinhVien; set => gioiHanSinhVien = value; }
        public int SoLuongDangKi { get => soLuongDangKi; set => soLuongDangKi = value; }
        public int MaGiangVien { get => maGiangVien; set => maGiangVien = value; }
        public string TenGiangVien { get => tenGiangVien; set => tenGiangVien = value; }
        public string ThoiGianDay { get => thoiGianDay; set => thoiGianDay = value; }
        public string TietDau { get => tietDau; set => tietDau = value; }
        public string TietCuoi { get => tietCuoi; set => tietCuoi = value; }

        public MonHoc(int maMonHoc, string tenMonHoc, int soTinChi, string loaiMonHoc, int gioiHanSinhVien, int soLuongDangKi, int maGiangVien, string tenGiangVien, string thoiGianDay, string tietDau, string tietCuoi)
        {
            this.maMonHoc = maMonHoc;
            this.tenMonHoc = tenMonHoc;
            this.soTinChi = soTinChi;
            this.loaiMonHoc = loaiMonHoc;
            this.gioiHanSinhVien = gioiHanSinhVien;
            this.soLuongDangKi = soLuongDangKi;
            this.maGiangVien = maGiangVien;
            this.tenGiangVien = tenGiangVien;
            this.thoiGianDay = thoiGianDay;
            this.tietDau = tietDau;
            this.tietCuoi = tietCuoi;
        }
        public MonHoc(MonHoc monhoc) : this(monhoc.MaMonHoc, monhoc.TenMonHoc, monhoc.SoTinChi, monhoc.LoaiMonHoc, monhoc.GioiHanSinhVien, monhoc.SoLuongDangKi, monhoc.MaGiangVien, monhoc.TenGiangVien, monhoc.ThoiGianDay, monhoc.tietDau, monhoc.TietCuoi)
        {
        }
        public MonHoc()
        {
            MaMonHoc = 1;
            TenMonHoc = "";
            SoTinChi = 0;
            LoaiMonHoc = "";
            GioiHanSinhVien = 0;
            SoLuongDangKi = 0;
            MaGiangVien = 0;
            TenGiangVien = "";
            ThoiGianDay = "";
            TietDau = "";
            tietCuoi = "";
        }
    }
}
