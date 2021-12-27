using System;
using System.Collections.Generic;
using System.Text;

namespace FinalExam.People
{
    class HocSinh: Person
    {
        int soBaoDanh;
        string truongTHPT;
        string khoiThi;
        string nganh;
        int diemThi;
        string khuVuc;
        double diemUuTien;

        public int SoBaoDanh { get => soBaoDanh; set => soBaoDanh = value; }
        public string TruongTHPT { get => truongTHPT; set => truongTHPT = value; }
        public string KhoiThi { get => khoiThi; set => khoiThi = value; }
        public string Nganh { get => nganh; set => nganh = value; }
        public int DiemThi { get => diemThi; set => diemThi = value; }
        public string KhuVuc { get => khuVuc; set => khuVuc = value; }
        public double DiemUuTien { get => diemUuTien; set => diemUuTien = value; }
        public HocSinh(int soBaoDanh, string ho, string ten, string ngaysinh, string gioitinh, string soDT, string truongTHPT, string khoiThi, string nganh, int diemThi,
                       string khuVuc, double diemUuTien): base(ho, ten, ngaysinh, gioitinh, soDT)
        {
            this.soBaoDanh = soBaoDanh;
            this.truongTHPT = truongTHPT;
            this.khoiThi = khoiThi;
            this.nganh = nganh;
            this.diemThi = diemThi;
            this.khuVuc = khuVuc;
            this.diemUuTien = diemUuTien;
        }
        public HocSinh(HocSinh hocsinh) : this(hocsinh.SoBaoDanh, hocsinh.Ho, hocsinh.Ten, hocsinh.NgaySinh, hocsinh.GioiTinh, hocsinh.SoDT,hocsinh.truongTHPT, 
                                               hocsinh.khoiThi,hocsinh.nganh, hocsinh.diemThi, hocsinh.khuVuc, hocsinh.diemUuTien)
        {
        }
        public HocSinh()
        {
            soBaoDanh = 1;
            truongTHPT = "";
            khoiThi = "";
            nganh = "";
            diemThi = 0;
            khuVuc = "";
            diemUuTien = 0;
        }
        public override void add()
        {
            base.add();
            Console.Write("Nhap ten truong THPT: ");
            TruongTHPT = Console.ReadLine();
            Console.Write("Nhap khoi thi: ");
            KhoiThi = Console.ReadLine();
            Console.Write("Nhap nganh thi: ");
            Nganh = Console.ReadLine();
            Console.Write("Nhap diem thi: ");
            DiemThi = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhap khu vuc: ");
            KhuVuc = Console.ReadLine();
            Console.Write("Nhap diem uu tien: ");
            DiemUuTien = Convert.ToDouble(Console.ReadLine());
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
