using FinalExam.Other;
using System;
using System.Collections.Generic;
using System.Text;

namespace FinalExam.People
{
    class SinhVien: Person
    {
        int maSoSinhVien;
        string nganhHoc;
        string tenKhoahoc;
        List<MonHoc> listMH = new List<MonHoc>();
        List<Diem> listDiem = new List<Diem>();
        List<ThoiKhoaBieu> listTKB = new List<ThoiKhoaBieu>();
        public int MaSoSinhVien { get => maSoSinhVien; set => maSoSinhVien = value; }
        public string NganhHoc { get => nganhHoc; set => nganhHoc = value; }
        public string TenKhoahoc { get => tenKhoahoc; set => tenKhoahoc = value; }
        internal List<MonHoc> ListMH { get => listMH; set => listMH = value; }
        internal List<Diem> ListDiem { get => listDiem; set => listDiem = value; }
        internal List<ThoiKhoaBieu> ListTKB { get => listTKB; set => listTKB = value; }

        public SinhVien(int maSoSinhVien, string ho, string ten, string ngaysinh, string gioitinh, string soDT, string nganhHoc, string tenKhoahoc, List<MonHoc> listMH, List<Diem> listDiem, List<ThoiKhoaBieu> listTKB)
                        : base(ho, ten, ngaysinh, gioitinh, soDT)
        {
            this.NganhHoc = nganhHoc;
            this.MaSoSinhVien = maSoSinhVien;
            this.TenKhoahoc = tenKhoahoc;
            this.listMH = listMH;
            this.listDiem = listDiem;
            this.listTKB = listTKB;
        }

        public SinhVien(SinhVien sinhvien) : this(sinhvien.MaSoSinhVien,sinhvien.Ho,sinhvien.Ten,sinhvien.NgaySinh,sinhvien.GioiTinh,sinhvien.SoDT, sinhvien.NganhHoc, sinhvien.TenKhoahoc,sinhvien.listMH, sinhvien.listDiem, sinhvien.ListTKB)
        {
        }
        public SinhVien():base()
        {
            MaSoSinhVien = 0;
            NganhHoc = "";
            TenKhoahoc = "";
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
