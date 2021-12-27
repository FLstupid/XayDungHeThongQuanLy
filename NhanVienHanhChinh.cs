using System;
using System.Collections.Generic;
using System.Text;

namespace FinalExam.People
{
    class NhanVienHanhChinh: Person
    {
        string congViec;
        string phongBan;
        int luong;
        public string CongViec
        {
            get => congViec;
            set => congViec = value;
        }
        public string PhongBan
        {
            get => phongBan;
            set => phongBan = value;
        }
        public int Luong
        {
            get => luong;
            set => luong = value;
        }
        public NhanVienHanhChinh(string ho, string ten, string ngaysinh, string gioitinh, string soDT,string congViec, string phongBan, int luong)
                                 :base(ho, ten, ngaysinh, gioitinh, soDT)
        {
            this.congViec = congViec;
            this.phongBan = phongBan;
            this.luong = luong;
        }
        public NhanVienHanhChinh(NhanVienHanhChinh Nv) : this(Nv.Ho, Nv.Ten, Nv.NgaySinh, Nv.GioiTinh, Nv.SoDT, Nv.congViec, Nv.phongBan, Nv.luong)
        {
        }
        public NhanVienHanhChinh()
        {
            congViec = "";
            phongBan = "";
            luong = 0;
        }
        public override void add()
        {
            base.add();
            Console.Write("Nhap cong viec: ");
            CongViec = Console.ReadLine();
            Console.Write("Nhap phong ban: ");
            PhongBan = Console.ReadLine();
            Console.Write("Nhap luong: ");
            Luong = Convert.ToInt32(Console.ReadLine());
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
