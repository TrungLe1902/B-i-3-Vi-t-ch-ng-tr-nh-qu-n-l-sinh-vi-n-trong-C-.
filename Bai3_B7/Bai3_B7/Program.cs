using Bai3_B7;
using System;
using System.Text;

class Program
{
    static void Main(string[] args)
    {
        IQuanLySinhVien qlsv = new QuanLySinhVien();
        while (true)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Menu:");
            Console.WriteLine("1. Thêm sinh viên từ bàn phím");
            Console.WriteLine("2. Thêm sinh viên từ file Excel");
            Console.WriteLine("3. Sắp xếp sinh viên theo tên");
            Console.WriteLine("4. Sắp xếp sinh viên theo học lực");
            Console.WriteLine("5. Sắp xếp sinh viên theo điểm trung bình");
            Console.WriteLine("6. Cập nhật thông tin sinh viên bởi ID");
            Console.WriteLine("7. Xóa sinh viên bởi ID");
            Console.WriteLine("8. Xóa nhiều sinh viên cùng lúc");
            Console.WriteLine("9. Hiển thị danh sách sinh viên");
            Console.WriteLine("0. Thoát");
            Console.Write("Chọn một tùy chọn: ");
            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    qlsv.ThemSinhVien();
                    break;
                case 2:
                    Console.Write("Nhập đường dẫn file Excel: ");
                    string excelFilePath = Console.ReadLine();
                    qlsv.ThemSinhVienTuFileExcel(excelFilePath);
                    break;
                case 3:
                    qlsv.SapXepTheoTen();
                    qlsv.HienThiDanhSachSinhVien();
                    break;
                case 4:
                    qlsv.SapXepTheoHocLuc();
                    qlsv.HienThiDanhSachSinhVien();
                    break;
                case 5:
                    qlsv.SapXepTheoDiemTrungBinh();
                    qlsv.HienThiDanhSachSinhVien();
                    break;
                case 6:
                    int idCapNhat = int.Parse(Console.ReadLine());
                    qlsv.CapNhatThongTinSinhVien(idCapNhat);
                    break;
                case 7:
                
                    int idXoa = int.Parse(Console.ReadLine());
                    qlsv.XoaSinhVienTheoId(idXoa);
                    qlsv.HienThiDanhSachSinhVien();
                    break;
                case 8:
                    qlsv.XoaNhieuSinhVien();
                    qlsv.HienThiDanhSachSinhVien();
                    break;
                case 9:
                    qlsv.HienThiDanhSachSinhVien();
                    break;
                case 0:
                    return;
                default:
                    Console.WriteLine("Tùy chọn không hợp lệ. Vui lòng chọn lại.");
                    break;
            }
        }
    }
}
