using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1_DAL_DataAccesLayer.Entities;

namespace _1_DAL_DataAccesLayer.DAL_IServices
{
    public interface IServiceTheLoai
    {
        public string ThemLH(LOAIHANG lh);
        public string SuaLH(LOAIHANG lh);
        public string XoaLH(LOAIHANG lh);
        public List<LOAIHANG> GetLstLoaiHang();
    }
}
