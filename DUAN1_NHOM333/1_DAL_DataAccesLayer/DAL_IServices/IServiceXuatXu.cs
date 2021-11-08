using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1_DAL_DataAccesLayer.Models;

namespace _1_DAL_DataAccesLayer.DAL_IServices
{
    public interface IServiceXuatXu
    {
        public string ThemXX(XuatXu xx);
        public string SuaXX(XuatXu xx);
        public string XoaXX(XuatXu xx);

        public List<XuatXu> _GetLstXuatXu();

    }
}
