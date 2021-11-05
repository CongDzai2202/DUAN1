using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1_DAL_DataAccesLayer.Entities;

namespace _1_DAL_DataAccesLayer.DAL_IServices
{
    public interface IServiceKichThuoc
    {
        public string ThemKT(KICHTHUOC kt);
        public string SuaKT(KICHTHUOC kt);
        public string XoaKT(KICHTHUOC kt);
        public List<KICHTHUOC> GetLstKichThuoc();
    }
}
