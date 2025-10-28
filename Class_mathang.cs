using System;

namespace DoAn
{
    public class MatHang
    {
        #region Attributes
        private string maMatHang ;
        private string tenMatHang = "";
        private decimal donGia;
        private int soLuong;
        private string donViTinh = "";
        private string nhaCungCap = "";
        private DateTime ngayNhap;
        #endregion

        #region Properties
        public string MaMatHang
        {
            get { return maMatHang; }
            set { maMatHang = value; }
        }
        public string TenHang
        {
            get { return tenMatHang; }
            set { tenMatHang = value; }
        }
        public decimal DonGia
        {
            get { return donGia; }
            set { donGia = value; }
        }
        public int SoLuong
        {
            get { return soLuong; }
            set { soLuong = value; }
        }
        public string DonViTinh
        {
            get { return donViTinh; }
            set { donViTinh = value; }
        }
        public string NhaCungCap
        {
            get { return nhaCungCap; }
            set { nhaCungCap = value; }
        }
        public DateTime NgayNhap
        {
            get { return ngayNhap; }
            set { ngayNhap = value; }
        }
        #endregion

        #region Methods
        // Constructors
        public MatHang() { }

        public MatHang(string maMatHang, string tenHang, decimal donGia, int soLuong, string donViTinh, string nhaCungCap, DateTime ngayNhap)
        {
            this.MaMatHang = maMatHang;
            this.TenHang = tenHang;
            this.DonGia = donGia;
            this.SoLuong = soLuong;
            this.DonViTinh = donViTinh;
            this.NhaCungCap = nhaCungCap;
            this.NgayNhap = ngayNhap;
        }

        // Xuất thông tin mặt hàng
        public void XuatThongTin()
        {
            Console.WriteLine($"Mã hàng: {MaMatHang}");
            Console.WriteLine($"Tên hàng: {TenHang}");
            Console.WriteLine($"Đơn giá: {DonGia}"+"VND");
            Console.WriteLine($"Số lượng: {SoLuong}");
            Console.WriteLine($"Đơn vị tính: {DonViTinh}");
            Console.WriteLine($"Nhà cung cấp: {NhaCungCap}");
            Console.WriteLine($"Ngày nhập: {NgayNhap.ToShortDateString()}");
            Console.WriteLine("-----------------------------------------");
        }
        #endregion
    }
}
