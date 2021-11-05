using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1_DAL_DataAccesLayer.Entities;

namespace _1_DAL_DataAccesLayer.DAL_IServices
{
    public interface IServiceNhaCungCap
    {
        public string ThemHD(NHACUNGCAP ncc);
        public string SuaHD(NHACUNGCAP ncc);
        public string XoaHD(NHACUNGCAP hd);
        public List<NHACUNGCAP> GetLstNhaCungCaps();
    }
}
