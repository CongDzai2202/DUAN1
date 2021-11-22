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
    public class ServiceQLNhanVien : ISevicesQLNhanVien
    {
        /// <summary>
        /// 
        /// </summary>
        private IServiceNhanVien _IQLNhanVien;
        private List<ChucVu> _lstChucVu;
        private List<NhanVien> _lstNhanVien;
        public ServiceQLNhanVien()
        {
            _IQLNhanVien = new ServiceNhanVien();
            GetDataFromDB();
        }

        public void GetDataFromDB()
        {
            _IQLNhanVien.GetDataFromDB();
        }

        public List<ChucVu> GetLstChucVu()
        {
            return _lstChucVu = _IQLNhanVien.GetLstChucVu();
        }

        public List<NhanVien> GetLstNhanVien()
        {
            return _lstNhanVien = _IQLNhanVien.GetLstNhanVien();
        }

        public string SuaNV(NhanVien nv)
        {
            return _IQLNhanVien.SuaNV(nv);
        }

        public string ThemNV(NhanVien nv)
        {
            return _IQLNhanVien.ThemNV(nv);
        }

        public List<NhanVien> TimKiemNV(string nv) 
        { 
            return _IQLNhanVien.TimKiemNV(nv);
        }

        public string XoaNV(NhanVien nv)
        {
            return _IQLNhanVien.XoaNV(nv);
        }
    }
}
