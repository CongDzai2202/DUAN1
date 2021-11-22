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
        private List<ChucVu> _lstchucVus;


        public ServiceNhanVien()
        {
            _dbContext = new DatabaseContext();
            _lstNhanviens = new List<NhanVien>();
            _lstchucVus = new List<ChucVu>();
            _lstNhanviens=_dbContext.NhanViens.AsNoTracking().ToList();
            GetDataFromDB();
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

        public List<ChucVu> GetLstChucVu()
        {
            return _lstchucVus;
        }

        public void GetDataFromDB()
        {
            _lstNhanviens = _dbContext.NhanViens.ToList();
            _lstchucVus = _dbContext.ChucVus.ToList();
        }

        public List<NhanVien> TimKiemNV(string nv)
        {
            return _lstNhanviens.Where(c => c.TenNhanVien.Contains(nv) || c.SoDienThoai.Contains(nv)).ToList();
        }
    }
}
