using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1_DAL_DataAccesLayer.Models;

namespace _1_DAL_DataAccesLayer.DAL_IServices
{
    public interface IServiceHangHoa
    {
        public string ThemHH(SanPham hh);
        public string SuaHH(SanPham hh);
        public string XoaHH(SanPham hh);
        public List<SanPham> GetLstHangHoa();
    }
}
