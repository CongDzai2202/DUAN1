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
    public class ServiceNhanVien:IServiceNhanVien
    {
        private DatabaseContext1 _dbContext;
        private List<NHANVIEN> _lstNhanviens;

        public ServiceNhanVien()
        {
            _dbContext = new DatabaseContext1();
            _lstNhanviens = new List<NHANVIEN>();
            _dbContext.NHANVIENS.ToList();
        }
        public string ThemNV(NHANVIEN nv)
        {
            _dbContext.NHANVIENS.Add(nv);
            _dbContext.SaveChanges();
            return "Thêm Thành Công";
        }

        public string SuaNV(NHANVIEN nv)
        {
            _dbContext.NHANVIENS.Update(nv);
            _dbContext.SaveChanges();
            return "Sưa Thành Công";
        }

        public string XoaNV(NHANVIEN nv)
        {
            nv.TRANGTHAI = false;
            if (_dbContext.NHANVIENS.ToList().Any(c => c.MANHANVIEN == nv.MANHANVIEN))
            {
                _dbContext.NHANVIENS.Update(nv);
                _dbContext.SaveChanges();
                return "Xóa Thành Công";
            }
            else
            {
                return "Xóa Không Thành Công";
            }
        }

        public List<NHANVIEN> GetLstNhanVien()
        {
            return _lstNhanviens;
        }
    }
}
