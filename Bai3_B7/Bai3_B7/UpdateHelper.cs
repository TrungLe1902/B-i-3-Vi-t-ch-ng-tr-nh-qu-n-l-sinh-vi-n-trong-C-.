using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai3_B7
{
    public static class UpdateHelper
    {
        public static void CapNhatThongTinSinhVien(List<SinhVien> danhSachSinhVien, int id)
        {
            Console.Write("Nhập ID của sinh viên cần cập nhật: ");
            SinhVien sv = danhSachSinhVien.Find(s => s.Id == id);
            if (sv != null)
            {
                Console.WriteLine($"Thông tin sinh viên cần cập nhật:");
                Console.WriteLine(sv); // Hiển thị thông tin sinh viên trước khi cập nhật

                // Yêu cầu người dùng nhập thông tin mới
                Console.WriteLine($"Nhập thông tin mới cho sinh viên có ID {id}:");
                sv.Ten = InputHelper.NhapTenSinhVien();
                sv.GioiTinh = InputHelper.NhapGioiTinhSinhVien();
                sv.Tuoi = InputHelper.NhapTuoiSinhVien();
                sv.DiemToan = InputHelper.NhapDiem("Toán");
                sv.DiemLy = InputHelper.NhapDiem("Lý");
                sv.DiemHoa = InputHelper.NhapDiem("Hóa");

                Console.WriteLine($"Đã cập nhật thông tin sinh viên có ID {id} thành công!");

                // Hiển thị lại thông tin sau khi cập nhật
                Console.WriteLine($"Thông tin sau khi cập nhật:");
                Console.WriteLine(sv);
            }
            else
            {
                Console.WriteLine("Không tìm thấy sinh viên với ID này.");
            }
        }
    }
}
