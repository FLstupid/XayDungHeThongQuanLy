using System;
using System.Collections.Generic;
using System.Text;

namespace FinalExam.Other
{
    class ThoiKhoaBieu
    {
        string thuHai;
        string thuBa;
        string thuTu;
        string thuNam;
        string thuSau;
        string thuBay;
        string tietHoc;
        int maGiangVien;
        string tenGiangVien;

        public string ThuHai { get => thuHai; set => thuHai = value; }
        public string ThuBa { get => thuBa; set => thuBa = value; }
        public string ThuTu { get => thuTu; set => thuTu = value; }
        public string ThuNam { get => thuNam; set => thuNam = value; }
        public string ThuSau { get => thuSau; set => thuSau = value; }
        public string ThuBay { get => thuBay; set => thuBay = value; }
        public string TietHoc { get => tietHoc; set => tietHoc = value; }
        public int MaGiangVien { get => maGiangVien; set => maGiangVien = value; }
        public string TenGiangVien { get => tenGiangVien; set => tenGiangVien = value; }

        public ThoiKhoaBieu(string thuHai, string thuBa, string thuTu, string thuNam, string thuSau, string thuBay, string tietHoc, int maGiangVien, string tenGiangVien)
        {
            this.thuHai = thuHai;
            this.thuBa = thuBa;
            this.thuTu = thuTu;
            this.thuNam = thuNam;
            this.thuSau = thuSau;
            this.thuBay = thuBay;
            this.tietHoc = tietHoc;
            this.maGiangVien = maGiangVien;
            this.tenGiangVien = tenGiangVien;
        }

        public ThoiKhoaBieu()
        {
            ThuHai = "";
            ThuBa = "";
            ThuTu = "";
            ThuNam = "";
            ThuSau = "";
            ThuBay = "";
            TietHoc = "";
            MaGiangVien = 0;
            TenGiangVien = "";
        }
    }
}
