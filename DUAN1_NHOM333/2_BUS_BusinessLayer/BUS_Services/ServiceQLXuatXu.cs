using _1_DAL_DataAccesLayer.DAL_IServices;
using _1_DAL_DataAccesLayer.DAL_Services;
using _1_DAL_DataAccesLayer.Models;
using _2_BUS_BusinessLayer.BUS_IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_BUS_BusinessLayer.BUS_Services
{
    public class ServiceQLXuatXu : IServiceQLXuatXu
    {
        private IServiceXuatXu _iserviceXuatXu;
        public ServiceQLXuatXu()
        {
            _iserviceXuatXu = new ServiceXuatXu();
            GetDataFromDB();
        }
        public void GetDataFromDB()
        {
            _iserviceXuatXu.GetDataFromDB();
        }

        public List<XuatXu> GetLstXuatXu()
        {
            return _iserviceXuatXu._GetLstXuatXu();
        }

        public string SuaXX(XuatXu xx)
        {
            return _iserviceXuatXu.SuaXX(xx);
        }

        public string ThemXX(XuatXu xx)
        {
            return _iserviceXuatXu.ThemXX(xx);
        }
        public string XoaXX(XuatXu xx)
        {
            return _iserviceXuatXu.XoaXX(xx);
        }

      

        

     
    }
}
