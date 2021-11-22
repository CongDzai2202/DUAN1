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
    public class ServicesQLNhaCungCap : IServicesQLNhaCungCap
    {
        private IServiceNhaCungCap _iServicesNhaCungCap;
        private bool _statusSavedata;
        public ServicesQLNhaCungCap()
        {
            _iServicesNhaCungCap = new ServiceNhaCungCap();
        }
        public List<NhaCungCap> getLstNhaCungCaps()
        {
            return _iServicesNhaCungCap.GetLstNhaCungCaps();
        }

        public string saveNCC()
        {
            _statusSavedata = true;
           return _iServicesNhaCungCap.saveNCC();
        }

        public string SuaNCC(NhaCungCap ncc)
        {
            _statusSavedata = false;
            return _iServicesNhaCungCap.SuaHD(ncc);
        }

        public string ThemNCC(NhaCungCap ncc)
        {
            _statusSavedata = false;
            return _iServicesNhaCungCap.ThemHD(ncc);
        }
        public bool Statusdata()
        {
            return _statusSavedata;
        }
    }
}
