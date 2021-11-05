using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1_DAL_DataAccesLayer.DAL_IServices;
using _1_DAL_DataAccesLayer.DatabaseContext;
using _1_DAL_DataAccesLayer.Entities;

namespace _1_DAL_DataAccesLayer.DAL_Services
{
    public class ServiceHoaDon:IServiceHoaDon
    {
        private DatabaseContext1 _dbContext;
        private List<HOADON> _lstHoaDon;

        public ServiceHoaDon()
        {
            _dbContext = new DatabaseContext1();
            _lstHoaDon = new List<HOADON>();
            _dbContext.HOADONS.ToList();
        }
        public string ThemHD(HOADON hd)
        {
            _dbContext.HOADONS.Add(hd);
            return "Thêm Thành Công";
        }

        public string SuaHD(HOADON hd)
        {
            _dbContext.HOADONS.Update(hd);
            return "Sửa Thành Công";
        }

        public string XoaHD(HOADON hd)
        {
            hd.TRANGTHAI = false;
            if (_dbContext.HOADONS.ToList().Any(c => c.MAHOADON == hd.MAHOADON))
            {
                _dbContext.HOADONS.Update(hd);
                return "Xóa Thành Công";
            }
            else
            {
                return "Xóa Không Thành Công";
            }
        }

        public string LuuHD()
        {
            _dbContext.SaveChanges();
            return "Lưu Hóa Đơn Thành Công";
        }

        public List<HOADON> GetLstHoaDon()
        {
            return _lstHoaDon;
        }
    }
}
