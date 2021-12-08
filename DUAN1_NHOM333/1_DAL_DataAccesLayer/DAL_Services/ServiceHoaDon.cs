using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using _1_DAL_DataAccesLayer.DAL_IServices;
using _1_DAL_DataAccesLayer.Context;
using _1_DAL_DataAccesLayer.Models;
using Microsoft.EntityFrameworkCore;

namespace _1_DAL_DataAccesLayer.DAL_Services
{
    public class ServiceHoaDon:IServiceHoaDon
    {
        private DatabaseContext _dbContext;
        private List<HoaDon> _lstHoaDon;


        public ServiceHoaDon()
        {
            _dbContext = new DatabaseContext();
            _lstHoaDon = new List<HoaDon>();
            _lstHoaDon=_dbContext.HoaDons.AsNoTracking().ToList();
        }
        public string ThemHD(HoaDon hd)
        {
            _dbContext.HoaDons.Add(hd);
            _dbContext.SaveChanges();
            return "Thêm Thành Công";
        }

        public string SuaHD(HoaDon hd)
        {
            _dbContext.ChangeTracker.Clear();
            _dbContext.HoaDons.Update(hd);
            return "Sửa Thành Công";
        }

        public string XoaHD(HoaDon hd)
        {
            hd.TrangThai = 1;
            if (_dbContext.HoaDons.ToList().Any(c => c.MaHoaDon == hd.MaHoaDon))
            {
                _dbContext.HoaDons.Remove(hd);
                return "Xóa Thành Công";
            }
            else
            {
                return "Xóa Không Thành Công";
            }
        }

        public string LuuHD()
        {
            //_dbContext.ChangeTracker.Clear();
            _dbContext.SaveChanges();
            return "Lưu Hóa Đơn Thành Công";
        }

        public List<HoaDon> GetLstHoaDon()
        {
            return _lstHoaDon;
        }

        public void GetLstFromDB()
        {
            _lstHoaDon = _dbContext.HoaDons.AsNoTracking().ToList();
        }
    }
}
