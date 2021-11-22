using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1_DAL_DataAccesLayer.Models;

namespace _1_DAL_DataAccesLayer.DAL_IServices
{
    public interface IServiceNhaCungCap
    {
        public string ThemHD(NhaCungCap ncc);
        public string SuaHD(NhaCungCap ncc);
        public string XoaHD(NhaCungCap hd);
        public List<NhaCungCap> GetLstNhaCungCaps();
        public string saveNCC();
    }
}
