public interface IQuanLySinhVien
{
    void ThemSinhVien();
    void ThemSinhVienTuFileExcel(string filePath);
    void SapXepTheoTen();
    void SapXepTheoHocLuc();
    void SapXepTheoDiemTrungBinh();
    void CapNhatThongTinSinhVien(int id);
    void XoaSinhVienTheoId(int id);
    void XoaNhieuSinhVien();
    void HienThiDanhSachSinhVien();
}
