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
    public class ServiceNhanVien:IServiceNhanVien
    {
        private DatabaseContext _dbContext;
        private List<NhanVien> _lstNhanviens;

        public ServiceNhanVien()
        {
            _dbContext = new DatabaseContext();
            _lstNhanviens = new List<NhanVien>();
            _lstNhanviens=_dbContext.NhanViens.AsNoTracking().ToList();
        }
        public string ThemNV(NhanVien nv)
        {
            _dbContext.NhanViens.Add(nv);
            _dbContext.SaveChanges();
            return "Thêm Thành Công";
        }

        public string SuaNV(NhanVien nv)
        {
            _dbContext.NhanViens.Update(nv);
            _dbContext.SaveChanges();
            return "Sưa Thành Công";
        }

        public string XoaNV(NhanVien nv)
        {
            nv.TrangThai = 1;
            if (_dbContext.NhanViens.ToList().Any(c => c.MaNhanVien == nv.MaNhanVien))
            {
                _dbContext.NhanViens.Update(nv);
                _dbContext.SaveChanges();
                return "Xóa Thành Công";
            }
            else
            {
                return "Xóa Không Thành Công";
            }
        }

        public List<NhanVien> GetLstNhanVien()
        {
            return _lstNhanviens;
        }
    }
}
