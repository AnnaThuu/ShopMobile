using ShopOnlineDTConnection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ShopOnline.Models.BUS
{
    public class ShopOnlineBUS
    {
        public static IEnumerable<SanPham> DanhSach()
        {
            var db = new ShopOnlineDTConnectionDB();
            return db.Query<SanPham>("select * from SanPham where TinhTrang = 0");

        }
        public static SanPham ChiTiet(String a)
        {
            var db = new ShopOnlineDTConnectionDB();
            return db.FirstOrDefault<SanPham>("select * from SanPham where MaSanPham = @0",a);

        }
        public static IEnumerable<SanPham> Top4New()
        {
            var db = new ShopOnlineDTConnectionDB();
            return db.Query<SanPham>("select Top 4 * from SanPham where GhiChu = N'New'");

        }
        public static IEnumerable<SanPham> TopHot()
        {
            var db = new ShopOnlineDTConnectionDB();
            return db.Query<SanPham>("select Top 4 * from SanPham where LuotView > 0");

        }
    }
}