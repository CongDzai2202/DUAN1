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
    public class ServiceHoaDonChiTiet:IServiceHoaDonChiTiet
    {
        private DatabaseContext1 _dbContext;
        private List<HOADONCHITIET> _lstHoaDonChiTiets;
        public ServiceHoaDonChiTiet()
        {
            _dbContext = new DatabaseContext1();
            _lstHoaDonChiTiets = new List<HOADONCHITIET>();
            _dbContext.HOADONCHITIETS.ToList();
        }

        public string ThemHDCT(HOADONCHITIET hdct)
        {
            _dbContext.HOADONCHITIETS.Add(hdct);
            return "Thêm Thành Công";
        }

        public string SuaHDCT(HOADONCHITIET hdct)
        {
            _dbContext.HOADONCHITIETS.Update(hdct);
            return "Sửa Thành Công";
        }

        public string XoaHDCT(HOADONCHITIET hdct)
        {
            hdct.TRANGTHAI = 1;
            if (_dbContext.HOADONCHITIETS.ToList().Any(c => c.MAHOADONCHITIET == hdct.MAHOADONCHITIET))
            {
                _dbContext.HOADONCHITIETS.Update(hdct);
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

        public List<HOADONCHITIET> GetHoaDonChiTiets()
        {
            return _lstHoaDonChiTiets;
        }
    }
}
