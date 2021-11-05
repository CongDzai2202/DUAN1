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
    public class ServicePhieuNhap:IServicePhieuNhap
    {
        private DatabaseContext1 _dbContext;
        private List<PHIEUNHAP> _lstPhieuNhap;

        public ServicePhieuNhap()
        {
            _dbContext = new DatabaseContext1();
            _lstPhieuNhap = new List<PHIEUNHAP>();
            _dbContext.PHIEUNHAPS.ToList();
        }
        public string ThemPN(PHIEUNHAP pn)
        {
            _dbContext.PHIEUNHAPS.Add(pn);
            return "Thêm Thành Công";
        }

        public string SuaPN(PHIEUNHAP pn)
        {
            _dbContext.PHIEUNHAPS.Update(pn);
            return "Thêm Thành Công";
        }

        public string XoaPN(PHIEUNHAP pn)
        {
            pn.TRANGTHAI = false;
            if (_dbContext.PHIEUNHAPS.ToList().Any(c => c.MAPHIEUNHAP == pn.MAPHIEUNHAP))
            {
                _dbContext.PHIEUNHAPS.Update(pn);
                _dbContext.SaveChanges();
                return "Xóa Thành Công";
            }
            else
            {
                return "Xóa Không Thành Công";
            }
        }

        public string LuuPN()
        {
            _dbContext.SaveChanges();
            return "Lưu Thành Công";
        }

        public List<PHIEUNHAP> GetLstPhieunhaps()
        {
            return _lstPhieuNhap;
        }
    }
}
