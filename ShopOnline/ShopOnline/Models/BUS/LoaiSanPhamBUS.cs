using ShopOnlineDTConnection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ShopOnline.Models.BUS
{
    public class LoaiSanPhamBUS
    {
        public static IEnumerable<LoaiSanPham> DanhSach() 
        {
            var db = new ShopOnlineDTConnectionDB();
            return db.Query<LoaiSanPham>("select *from LoaiSanPham where TinhTrang = 0");
        }
            public static IEnumerable<SanPham> ChiTiet(String id)
        {
            var db = new ShopOnlineDTConnectionDB();
            return db.Query<SanPham>("select *from SanPham where MaLoaiSanPham = '"+id+"'   ");
        }
    }
}