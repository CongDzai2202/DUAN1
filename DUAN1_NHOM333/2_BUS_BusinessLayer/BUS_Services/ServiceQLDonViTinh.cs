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
    public class ServiceQLDonViTinh:IServicesQLDonViTinh
    {
        private IServiceDonViTinh _IQLDonViTinh;
        public ServiceQLDonViTinh()
        {
            _IQLDonViTinh = new ServiceDonViTinh();
            GetDataFromDB();
        }

        public string ThemKT(DonViTinh kt)
        {
            return _IQLDonViTinh.ThemKT(kt);

        }

        public string SuaKT(DonViTinh kt)
        {
            return _IQLDonViTinh.SuaKT(kt);
        }

        public string XoaKT(DonViTinh kt)
        {
            return _IQLDonViTinh.XoaKT(kt);
        }

        public List<DonViTinh> GetLstKichThuoc()
        {
            return _IQLDonViTinh.GetLstKichThuoc();
        }

        public void GetDataFromDB()
        {
            _IQLDonViTinh.GetDataFromDB();
        }

        public List<ChatLieu> GetChatLieu()
        {
           return _IQLDonViTinh.GetChatLieu();
        }
    }
}
