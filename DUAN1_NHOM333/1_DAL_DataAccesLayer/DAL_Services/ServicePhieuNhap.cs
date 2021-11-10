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
    public class ServicePhieuNhap:IServicePhieuNhap
    {
        private DatabaseContext _dbContext;
        private List<PhieuNhap> _lstPhieuNhap;

        public ServicePhieuNhap()
        {
            _dbContext = new DatabaseContext();
            _lstPhieuNhap = new List<PhieuNhap>();
            _lstPhieuNhap=_dbContext.PhieuNhaps.AsNoTracking().ToList();
        }
        public string ThemPN(PhieuNhap pn)
        {
            _dbContext.PhieuNhaps.Add(pn);
            return "Thêm Thành Công";
        }

        public string SuaPN(PhieuNhap pn)
        {
            _dbContext.PhieuNhaps.Update(pn);
            return "Thêm Thành Công";
        }

        public string XoaPN(PhieuNhap pn)
        {
            pn.TrangThai = 1;
            if (_dbContext.PhieuNhaps.ToList().Any(c => c.MaPhieuNhap == pn.MaPhieuNhap))
            {
                _dbContext.PhieuNhaps.Update(pn);
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

        public List<PhieuNhap> GetLstPhieunhaps()
        {
            return _lstPhieuNhap;
        }
    }
}
