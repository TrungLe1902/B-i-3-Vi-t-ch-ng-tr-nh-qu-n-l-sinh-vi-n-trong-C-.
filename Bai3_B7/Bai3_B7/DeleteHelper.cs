using Bai3_B7;
using System;
using System.Collections.Generic;

public static class DeleteHelper
{
    public static void XoaSinhVienTheoId(List<SinhVien> danhSachSinhVien)
    {
        Console.Write("Nhập ID của sinh viên cần xóa: ");
        if (!int.TryParse(Console.ReadLine(), out int id))
        {
            Console.WriteLine("ID không hợp lệ. Vui lòng nhập một số nguyên.");
            return;
        }

        var sv = TimSinhVienTheoId(danhSachSinhVien, id);
        if (sv != null)
        {
            danhSachSinhVien.Remove(sv);
            Console.WriteLine($"Đã xóa sinh viên có ID {id} thành công.");
        }
        else
        {
            Console.WriteLine("Không tìm thấy sinh viên với ID này.");
        }
    }

    public static void XoaNhieuSinhVien(List<SinhVien> danhSachSinhVien)
    {
        Console.WriteLine("Nhập danh sách ID của sinh viên cần xóa (cách nhau bằng dấu phẩy):");
        string input = Console.ReadLine();
        string[] idStrings = input.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);
        List<int> ids = new List<int>();

        foreach (var idStr in idStrings)
        {
            if (int.TryParse(idStr.Trim(), out int id))
            {
                ids.Add(id);
            }
            else
            {
                Console.WriteLine($"ID '{idStr}' không hợp lệ và sẽ không được xóa.");
            }
        }

        int count = 0;
        foreach (var id in ids)
        {
            var sv = TimSinhVienTheoId(danhSachSinhVien, id);
            if (sv != null)
            {
                danhSachSinhVien.Remove(sv);
                count++;
            }
            else
            {
                Console.WriteLine($"Không tìm thấy sinh viên có ID {id} để xóa.");
            }
        }

        Console.WriteLine($"Đã xóa {count} sinh viên thành công.");
    }

    private static SinhVien TimSinhVienTheoId(List<SinhVien> danhSachSinhVien, int id)
    {
        return danhSachSinhVien.Find(sv => sv.Id == id);
    }
}
