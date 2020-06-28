using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DAO;
using DTO;
namespace QuanLyTrungTam2
{
    public class Bus_GiaoVien
    {
        DAO_GiaoVien giaoVien = new DAO_GiaoVien();
        
        public DataTable loadGV()
        {
            return giaoVien.load_GV();
        }
        public bool ThemGiaoVien(DTO_GiaoVien a)
        {
           return giaoVien.ThemGiaoVien(a);
        }
        public bool SuaGiaoVien(DTO_GiaoVien a)
        {
            return giaoVien.SuaGiaoVien(a);
        }
        public bool XoaGiaoVien(string s)
        {
            return giaoVien.XoaGiaoVien(s);
        }
           
         
    }
}
