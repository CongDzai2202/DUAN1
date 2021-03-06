using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1_DAL_DataAccesLayer.Models;

namespace _1_DAL_DataAccesLayer.DAL_IServices
{
    public interface IServiceNhanVien
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param ></param>
        /// <returns></returns>
        public string ThemNV(NhanVien nv);
        public string SuaNV(NhanVien nv);
        public string XoaNV(NhanVien nv);
        public List<NhanVien> GetLstNhanVien();
        public List<ChucVu> GetLstChucVu();
        public void GetDataFromDB();
        public List<NhanVien> TimKiemNV(string nv);
    }
}
