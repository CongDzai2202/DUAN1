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
    public class ServiceDonViTinh: IServiceDonViTinh
    {
        private DatabaseContext _dbContext;
        private List<DonViTinh> _lstKichThuoc;

        public ServiceDonViTinh()
        {
            _dbContext = new DatabaseContext();
            _lstKichThuoc = new List<DonViTinh>();
            _lstKichThuoc=_dbContext.DonViTinhs.AsNoTracking().ToList();
        }
        public string ThemKT(DonViTinh kt)
        {
            _dbContext.DonViTinhs.Add(kt);
            _dbContext.SaveChanges();
            return "Thêm Thành Công";
        }

        public string SuaKT(DonViTinh kt)
        {
            _dbContext.DonViTinhs.Update(kt);
            _dbContext.SaveChanges();
            return "Sửa Thành Công";
        }

        public string XoaKT(DonViTinh kt)
        {
            _dbContext.DonViTinhs.Remove(kt);
            _dbContext.SaveChanges();
            return "Xóa Thành Công";
        }

        public List<DonViTinh> GetLstKichThuoc()
        {
            return _lstKichThuoc;
        }
    }
}
