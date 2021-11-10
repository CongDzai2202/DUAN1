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
    public class ServiceLoaiHang: IServiceLoaiHang
    {
        private DatabaseContext _dbContext;
        private List<LoaiHang> _lstLoaiHangs;

        public ServiceLoaiHang()
        {
            _dbContext = new DatabaseContext();
            _lstLoaiHangs = new List<LoaiHang>();
            _lstLoaiHangs=_dbContext.LoaiHangs.AsNoTracking().ToList();

        }
        public string ThemLH(LoaiHang lh)
        {
            _dbContext.LoaiHangs.Add(lh);
            _dbContext.SaveChanges();
            return "Thêm Thành Công";
        }

        public string SuaLH(LoaiHang lh)
        {
            _dbContext.LoaiHangs.Update(lh);
            _dbContext.SaveChanges();
            return "Sua Thành Công";
        }

        public string XoaLH(LoaiHang lh)
        {
           
            return "Xóa Thành Công";
        }

        public List<LoaiHang> GetLstLoaiHang()
        {
            return _lstLoaiHangs;
        }
    }
}
