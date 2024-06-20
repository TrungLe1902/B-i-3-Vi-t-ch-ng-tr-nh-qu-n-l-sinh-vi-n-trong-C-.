using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai3_B7
{
    public class SinhVien
    {
        public int Id {  get; set; }
        public string Ten {  get; set; }
        public string GioiTinh {  get; set; }
        public int Tuoi { get; set; }
        public double DiemToan {  get; set; }
        public double DiemLy { get; set; }
        public double DiemHoa { get;set; }
        public double DiemTrungBinh
        {
            get
            {
                return (DiemToan + DiemLy + DiemHoa) / 3;
            }
        }
        public string HocLuc
        {
            get
            {
                if (DiemTrungBinh >= 8)
                    return "Giỏi";
                else if (DiemTrungBinh >= 6.5)
                    return "Khá";
                else if (DiemTrungBinh >= 5)
                    return "Trung Bình";
                else
                    return "Yếu";
            }
        }
        public SinhVien(int id,string ten, string gioiTinh, int tuoi, double diemToan, double diemLy, double diemHoa)
        {
            Id = id;
            Ten = ten;
            GioiTinh = gioiTinh;
            Tuoi = tuoi;
            DiemToan = diemToan;
            DiemLy = diemLy;
            DiemHoa = diemHoa;

        }
        public override string ToString()
        {
            return $"ID: {Id}, Tên: {Ten}, Giới Tính: {GioiTinh}, Tuổi: {Tuoi}, Điểm Toán: {DiemToan}, Điểm Lý: {DiemLy}, Điểm Hóa: {DiemHoa}, Điểm Trung Bình: {DiemTrungBinh:F2}, Học Lực: {HocLuc}";
        }

    }
}