using Bai3_B7;
using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Bai3_B7
{
    public class QuanLySinhVien : IQuanLySinhVien
    {
        private List<SinhVien> danhSachSinhVien;
        private int currentId;

        public QuanLySinhVien()
        {
            danhSachSinhVien = new List<SinhVien>();
            currentId = 1;
        }


        public void ThemSinhVien()
        {
            Console.WriteLine("Nhập thông tin sinh viên mới:");
            string ten = InputHelper.NhapTenSinhVien();
            string gioiTinh = InputHelper.NhapGioiTinhSinhVien();
            int tuoi = InputHelper.NhapTuoiSinhVien();
            double diemToan = InputHelper.NhapDiem("Toán");
            double diemLy = InputHelper.NhapDiem("Lý");
            double diemHoa = InputHelper.NhapDiem("Hóa");

            SinhVien sv = new SinhVien(currentId++, ten, gioiTinh, tuoi, diemToan, diemLy, diemHoa);
            danhSachSinhVien.Add(sv);

            Console.WriteLine("Đã thêm sinh viên thành công!");
        }

        public void ThemSinhVienTuFileExcel(string filePath)
        {

            ExcelHelper.ThemSinhVienTuFileExcel(filePath, danhSachSinhVien, ref currentId);
        }

        public void SapXepTheoTen()
        {

            danhSachSinhVien = danhSachSinhVien.OrderBy(sv => sv.Ten).ToList();
        }

        public void SapXepTheoHocLuc()
        {

            danhSachSinhVien = danhSachSinhVien.OrderByDescending(sv => sv.HocLuc).ToList();
        }

        public void SapXepTheoDiemTrungBinh()
        {

            danhSachSinhVien = danhSachSinhVien.OrderByDescending(sv => sv.DiemTrungBinh).ToList();
        }

        public void CapNhatThongTinSinhVien(int id)
        {
            UpdateHelper.CapNhatThongTinSinhVien(danhSachSinhVien, id);
        }

        public void XoaSinhVienTheoId(int id)
        {
            DeleteHelper.XoaSinhVienTheoId(danhSachSinhVien);
        }

        public void XoaNhieuSinhVien()
        {
            DeleteHelper.XoaNhieuSinhVien(danhSachSinhVien);
        }
        public void HienThiDanhSachSinhVien()
        {
            foreach (var sv in danhSachSinhVien)
            {
                Console.WriteLine(sv);
            }
        }

      
    }

}


