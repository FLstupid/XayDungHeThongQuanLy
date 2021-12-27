using System;
using System.Collections.Generic;
using System.Text;

namespace FinalExam.Other
{
    class Diem
    {
        int maMonHoc;
        string tenMonHoc;
        double diemCuoiKi;
        double diemQuaTrinh;
        double diemTrungBinh;
        string diemChu;
   
        public int MaMonHoc { get => maMonHoc; set => maMonHoc = value; }
        public string TenMonHoc { get => tenMonHoc; set => tenMonHoc = value; }
        public double DiemCuoiKi { get => diemCuoiKi; set => diemCuoiKi = value; }
        public double DiemQuaTrinh { get => diemQuaTrinh; set => diemQuaTrinh = value; }
        public double DiemTrungBinh { get => diemTrungBinh; set => diemTrungBinh = value; }
        public string DiemChu { get => diemChu; set => diemChu = value; }

        public Diem(int maMonHoc, string tenMonHoc, double diemCuoiKi, double diemQuaTrinh, double diemTrungBinh, string diemChu)
        {
            this.maMonHoc = maMonHoc;
            this.tenMonHoc = tenMonHoc;
            this.diemCuoiKi = diemCuoiKi;
            this.diemQuaTrinh = diemQuaTrinh;
            this.diemTrungBinh = diemTrungBinh;
            this.diemChu = diemChu;
        }

        public Diem(Diem diem) : this(diem.maMonHoc, diem.tenMonHoc, diem.DiemQuaTrinh, diem.DiemCuoiKi, diem.DiemTrungBinh, diem.DiemChu)
        {
        }
        public Diem()
        {
            MaMonHoc = 0;
            TenMonHoc = "";
            DiemCuoiKi = 0;
            DiemQuaTrinh = 0;
            DiemTrungBinh = 0;
            DiemChu = "";
        }
    }
}
