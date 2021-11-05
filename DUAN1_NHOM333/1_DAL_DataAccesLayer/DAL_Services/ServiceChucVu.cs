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
    public class ServiceChucVu:IServiceChucVu
    {
        private DatabaseContext1 _dbContext;
        private List<CHUCVU> _lstChucVus;
        public ServiceChucVu()
        {
            _dbContext = new DatabaseContext1();
            _lstChucVus = new List<CHUCVU>();
            _lstChucVus = _dbContext.CHUCVUS.ToList();
        }
        public string Them(CHUCVU cv)
        {
            _dbContext.CHUCVUS.Add(cv);
            _dbContext.SaveChanges();
            return "Thêm Thành Công";
        }

        public string Sua(CHUCVU cv)
        {
            _dbContext.CHUCVUS.Update(cv);
            _dbContext.SaveChanges();
            return "Sửa Thành Công";
        }

        public string Xoa(CHUCVU cv)
        {
            cv.TRANGTHAI = false;
            if (_dbContext.CHUCVUS.ToList().Any(c=>c.MACHUCVU == cv.MACHUCVU ))
            {
                _dbContext.CHUCVUS.Update(cv);
                _dbContext.SaveChanges();
                return "Xóa Thành Công";
            }
            else
            {
                return "Xóa Không Thành Công";
            }
        }

        public List<CHUCVU> GetLstChucvus()
        {
            return _lstChucVus;
        }
    }
}
