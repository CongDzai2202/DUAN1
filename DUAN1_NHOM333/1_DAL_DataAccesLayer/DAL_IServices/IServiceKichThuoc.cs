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
        public string ThemKT(DONVITINH kt);
        public string SuaKT(DONVITINH kt);
        public string XoaKT(DONVITINH kt);
        public List<DONVITINH> GetLstKichThuoc();
    }
}
