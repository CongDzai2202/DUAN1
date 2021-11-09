using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1_DAL_DataAccesLayer.DAL_IServices;
using _1_DAL_DataAccesLayer.Context;
using _1_DAL_DataAccesLayer.Models;
using Microsoft.EntityFrameworkCore;

namespace _1_DAL_DataAccesLayer.DAL_Services
{
    public class ServiceHoaDonChiTiet:IServiceHoaDonChiTiet
    {
        private DatabaseContext _dbContext;
        private List<HoaDonChiTiet> _lstHoaDonChiTiets;
        public ServiceHoaDonChiTiet()
        {
            _dbContext = new DatabaseContext();
            _lstHoaDonChiTiets = new List<HoaDonChiTiet>();
            _lstHoaDonChiTiets=_dbContext.HoaDonChiTiets.AsNoTracking().ToList();
        }

        public string ThemHDCT(HoaDonChiTiet hdct)
        {
            //hdct.Id = GetHoaDonChiTiets().Max(c => c.Id) + 1;
            _dbContext.HoaDonChiTiets.Add(hdct);
            return "Thêm Thành Công";
        }

        public string SuaHDCT(HoaDonChiTiet hdct)
        {
            _dbContext.HoaDonChiTiets.Update(hdct);
            return "Sửa Thành Công";
        }

        public string XoaHDCT(HoaDonChiTiet hdct)
        {
            hdct.TrangThai = 1;
            if (_dbContext.HoaDonChiTiets.ToList().Any(c => c.MaHoaDonChiTiet== hdct.MaHoaDonChiTiet))
            {
                _dbContext.HoaDonChiTiets.Update(hdct);
                return "Xóa Thành Công";
            }
            else
            {
                return "Xóa Không Thành Công";
            }
        }

        public string LuuHDCT()
        {
            _dbContext.SaveChanges();
            return "Lưu Thành Công";
        }

        public List<HoaDonChiTiet> GetHoaDonChiTiets()
        {
            return _lstHoaDonChiTiets;
        }
    }
}
