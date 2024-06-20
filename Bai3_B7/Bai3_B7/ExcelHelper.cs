using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai3_B7
{
    public class ExcelHelper
    {
        public static void ThemSinhVienTuFileExcel(string filePath, List<SinhVien> danhSachSinhVien, ref int currentId)
        {
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
            try
            {

                using (var package = new ExcelPackage(new FileInfo(filePath)))
                {
                  
                    var worksheet = package.Workbook.Worksheets.FirstOrDefault();
                    if (worksheet == null)
                    {
                        Console.WriteLine("Không tìm thấy worksheet hợp lệ trong file Excel.");
                        return;
                    }

                    int rowCount = worksheet.Dimension.Rows;
                    for (int row = 2; row <= rowCount; row++) // Bắt đầu từ dòng thứ 2 vì dòng đầu tiên là header
                    {
                        string ten = worksheet.Cells[row, 1].GetValue<string>();
                        string gioiTinh = worksheet.Cells[row, 2].GetValue<string>();
                        int tuoi = worksheet.Cells[row, 3].GetValue<int>();
                        double diemToan = worksheet.Cells[row, 4].GetValue<double>();
                        double diemLy = worksheet.Cells[row, 5].GetValue<double>();
                        double diemHoa = worksheet.Cells[row, 6].GetValue<double>();

                        if (string.IsNullOrWhiteSpace(ten) && string.IsNullOrWhiteSpace(gioiTinh) && tuoi == 0 && diemToan == 0 && diemLy == 0 && diemHoa == 0)
                        {
                            Console.WriteLine($"Dòng {row} không có dữ liệu.");
                            continue;
                        }

                    
                        SinhVien sv = new SinhVien(currentId++, ten, gioiTinh, tuoi, diemToan, diemLy, diemHoa);
                        danhSachSinhVien.Add(sv);
                    }

                    Console.WriteLine("Đã thêm sinh viên từ file Excel thành công.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Đã xảy ra lỗi khi thêm sinh viên từ file Excel: {ex.Message}");
            }
        }
    }
}
