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
    public class ServiceNhaCungCap:IServiceNhaCungCap
    {
        private DatabaseContext1 _dbContext;
        private List<NHACUNGCAP> _lstNhaCungCap;
        public ServiceNhaCungCap()
        {
            _dbContext = new DatabaseContext1();
            _lstNhaCungCap = new List<NHACUNGCAP>();
        }
        public string ThemHD(NHACUNGCAP ncc)
        {
            _dbContext.NHACUNGCAPS.Add(ncc);
            _dbContext.SaveChanges();
            return "Thêm Thành Công";
        }

        public string SuaHD(NHACUNGCAP ncc)
        {
            _dbContext.NHACUNGCAPS.Update(ncc);
            _dbContext.SaveChanges();
            return "Sửa Thành Công";
        }

        public string XoaHD(NHACUNGCAP ncc)
        {
            ncc.TRANGTHAI = 1;
            if (_dbContext.NHACUNGCAPS.ToList().Any(c => c.MANHACUNGCAP == ncc.MANHACUNGCAP))
            {
                _dbContext.NHACUNGCAPS.Update(ncc);
                _dbContext.SaveChanges();
                return "Xóa Thành Công";
            }
            else
            {
                return "Xóa Không Thành Công";
            }
        }

        public List<NHACUNGCAP> GetLstNhaCungCaps()
        {
            return _lstNhaCungCap;
        }
    }
}
