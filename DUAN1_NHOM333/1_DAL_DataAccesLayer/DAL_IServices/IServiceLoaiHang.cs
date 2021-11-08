using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1_DAL_DataAccesLayer.Models;

namespace _1_DAL_DataAccesLayer.DAL_IServices
{
    public interface IServiceLoaiHang
    {
        public string ThemLH(LoaiHang lh);
        public string SuaLH(LoaiHang lh);
        public string XoaLH(LoaiHang lh);
        public List<LoaiHang> GetLstLoaiHang();
    }
}
