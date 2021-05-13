using ShopOnlineDTConnection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ShopOnline.Models.BUS
{
    public class NhaSanXuatBUS
    {
        public static IEnumerable<NhaSanXuat> DanhSach()
        {
            var db = new ShopOnlineDTConnectionDB();
            return db.Query<NhaSanXuat>("select * from NhaSanXuat where TinhTrang = 0");

        }
        public static IEnumerable<SanPham> ChiTiet(String id)
        {
            var db = new ShopOnlineDTConnectionDB();
            return db.Query<SanPham>("select * from SanPham where MaNhaSanXuat = '"+id+" '");

        }
    }
}