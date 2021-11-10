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
    public class ServiceNhaCungCap:IServiceNhaCungCap
    {
        private DatabaseContext _dbContext;
        private List<NhaCungCap> _lstNhaCungCap;
        public ServiceNhaCungCap()
        {
            _dbContext = new DatabaseContext();
            _lstNhaCungCap = new List<NhaCungCap>();
            _lstNhaCungCap = _dbContext.NhaCungCaps.AsNoTracking().ToList();
        }
        public string ThemHD(NhaCungCap ncc)
        {
            _dbContext.NhaCungCaps.Add(ncc);
            _dbContext.SaveChanges();
            return "Thêm Thành Công";
        }

        public string SuaHD(NhaCungCap ncc)
        {
            _dbContext.NhaCungCaps.Update(ncc);
            _dbContext.SaveChanges();
            return "Sửa Thành Công";
        }

        public string XoaHD(NhaCungCap ncc)
        {
            ncc.TrangThai = 1;
            if (_dbContext.NhaCungCaps.ToList().Any(c => c.MaNhaCungCap == ncc.MaNhaCungCap))
            {
                _dbContext.NhaCungCaps.Update(ncc);
                _dbContext.SaveChanges();
                return "Xóa Thành Công";
            }
            else
            {
                return "Xóa Không Thành Công";
            }
        }

        public List<NhaCungCap> GetLstNhaCungCaps()
        {
            return _lstNhaCungCap;
        }
    }
}
