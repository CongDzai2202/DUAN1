using _1_DAL_DataAccesLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace _2_BUS_BusinessLayer.BUS_IServices
{
    public interface ISevicesQLNhanVien
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param></param>
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
