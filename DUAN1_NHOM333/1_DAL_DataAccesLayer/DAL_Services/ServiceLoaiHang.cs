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
    public class ServiceLoaiHang: IServiceLoaiHang
    {
        private DatabaseContext1 _dbContext;
        private List<LOAIHANG> _lstLoaiHangs;

        public ServiceLoaiHang()
        {
            _dbContext = new DatabaseContext1();
            _lstLoaiHangs = new List<LOAIHANG>();
            _dbContext.LOAIHANGS.ToList();

        }
        public string ThemLH(LOAIHANG lh)
        {
            _dbContext.LOAIHANGS.Add(lh);
            _dbContext.SaveChanges();
            return "Thêm Thành Công";
        }

        public string SuaLH(LOAIHANG lh)
        {
            _dbContext.LOAIHANGS.Update(lh);
            _dbContext.SaveChanges();
            return "Sua Thành Công";
        }

        public string XoaLH(LOAIHANG lh)
        {
           
            return "Xóa Thành Công";
        }

        public List<LOAIHANG> GetLstLoaiHang()
        {
            return _lstLoaiHangs;
        }
    }
}
