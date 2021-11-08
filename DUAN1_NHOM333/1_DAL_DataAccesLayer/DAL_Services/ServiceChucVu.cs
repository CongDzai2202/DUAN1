using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1_DAL_DataAccesLayer.DAL_IServices;
using _1_DAL_DataAccesLayer.Context;
using _1_DAL_DataAccesLayer.Models;

namespace _1_DAL_DataAccesLayer.DAL_Services
{
    public class ServiceChucVu:IServiceChucVu
    {
        private DatabaseContext _dbContext;
        private List<ChucVu> _lstChucVus;
        public ServiceChucVu()
        {
            _dbContext = new DatabaseContext();
            _lstChucVus = new List<ChucVu>();
            _lstChucVus = _dbContext.ChucVus.ToList();
        }
        public string Them(ChucVu cv)
        {
            _dbContext.ChucVus.Add(cv);
            _dbContext.SaveChanges();
            return "Thêm Thành Công";
        }

        public string Sua(ChucVu cv)
        {
            _dbContext.ChucVus.Update(cv);
            _dbContext.SaveChanges();
            return "Sửa Thành Công";
        }

        public string Xoa(ChucVu cv)
        {
            cv.TrangThai = 1;
            if (_dbContext.ChucVus.ToList().Any(c=>c.MaChucVu == cv.MaChucVu ))
            {
                _dbContext.ChucVus.Update(cv);
                _dbContext.SaveChanges();
                return "Xóa Thành Công";
            }
            else
            {
                return "Xóa Không Thành Công";
            }
        }

        public List<ChucVu> GetLstChucvus()
        {
            return _lstChucVus;
        }
    }
}
