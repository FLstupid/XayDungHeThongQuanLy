using FinalExam.Other;
using System;
using System.Collections.Generic;
using System.Text;

namespace FinalExam.People
{
    class GiangVien: Person
    {
        int maGiangVien;
        string khoa;
        int luong;
        string lichDay;
        List<MonHoc> listMH = new List<MonHoc>();
        public int MaGiangVien { get => maGiangVien; set => maGiangVien = value; }
        public string Khoa { get => khoa; set => khoa = value; }
        public int Luong { get => luong; set => luong = value; }
        internal List<MonHoc> ListMH { get => listMH; set => listMH = value; }
        public string LichDay { get => lichDay; set => lichDay = value; }

        public GiangVien(int maGiangVien, string ho, string ten, string ngaysinh, string gioitinh, string soDT, string khoa, int luong, List<MonHoc> listMH) 
                         :base(ho, ten, ngaysinh, gioitinh, soDT)
        {
            this.maGiangVien = maGiangVien;
            this.khoa = khoa;
            this.luong = luong;
            this.listMH = listMH;
        }
        public GiangVien(GiangVien Gv):this(Gv.MaGiangVien, Gv.Ho, Gv.Ten, Gv.NgaySinh, Gv.GioiTinh, Gv.SoDT, Gv.khoa, Gv.luong, Gv.listMH)
        {

        }
        public GiangVien()
        {
            maGiangVien = 0;
            khoa = "";
            luong = 0;
        }
        public override void add()
        {
            base.add();
            Console.Write("Nhap ten khoa: ");
            Khoa = Console.ReadLine();
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
