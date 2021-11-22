using _1_DAL_DataAccesLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_BUS_BusinessLayer.BUS_IServices
{
    public interface IServiceQLXuatXu
    {
        public string ThemXX(XuatXu xx);
        public string SuaXX(XuatXu xx);
        public string XoaXX(XuatXu xx);

        public List<XuatXu> GetLstXuatXu();
        public void GetDataFromDB();
    }
}
