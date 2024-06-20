using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai3_B7
{
    public static class InputHelper
    {
        public static string NhapTenSinhVien()
        {
            string ten;
            do
            {
                Console.Write("Tên sinh viên: ");
                ten = Console.ReadLine().Trim();
                if (string.IsNullOrEmpty(ten) || !IsValidName(ten))
                {
                    Console.WriteLine("Tên sinh viên chỉ được chứa các ký tự chữ cái, không được để trống hoặc chứa số. Vui lòng nhập lại.");
                }
            } while (string.IsNullOrEmpty(ten) || !IsValidName(ten));
            return ten;
        }

        public static string NhapGioiTinhSinhVien()
        {
            string gioiTinh;
            do
            {
                Console.Write("Giới tính sinh viên ('Nam' hoặc 'Nu'): ");
                gioiTinh = Console.ReadLine().Trim();
                if (gioiTinh != "Nam" && gioiTinh != "Nu")
                {
                    Console.WriteLine("Giới tính sinh viên chỉ có thể là 'Nam' hoặc 'Nữ'. Vui lòng nhập lại.");
                }
            } while (gioiTinh != "Nam" && gioiTinh != "Nu");
            return gioiTinh;
        }

        public static int NhapTuoiSinhVien()
        {
            int tuoi;
            do
            {
                Console.Write("Tuổi sinh viên: ");
                if (!int.TryParse(Console.ReadLine(), out tuoi) || tuoi <= 0 || tuoi >= 100)
                {
                    Console.WriteLine("Tuổi sinh viên phải là một số nguyên dương nhỏ hơn 100. Vui lòng nhập lại.");
                }
            } while (tuoi <= 0 || tuoi >= 100);
            return tuoi;
        }

        public static double NhapDiem(string monHoc)
        {
            double diem;
            do
            {
                Console.Write($"Điểm {monHoc}: ");
                if (!double.TryParse(Console.ReadLine(), out diem) || diem < 0 || diem > 10)
                {
                    Console.WriteLine($"Điểm {monHoc} phải là một số nguyên từ 0 đến 10. Vui lòng nhập lại.");
                }
            } while (diem < 0 || diem > 10);
            return diem;
        }

        private static bool IsValidName(string name)
        {
            return name.All(char.IsLetter);
        }
    }
}
