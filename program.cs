using System;

namespace DoAn
{
    class Program
    {
        public static void Main(string [] args)
        {
            MatHang mathang1 = new MatHang("MH01", "cocacola", 12000, 100, "lon", "cocacola_VietNam", DateTime.Parse("1995-05-21"));
            mathang1.XuatThongTin();
        }
    }
}