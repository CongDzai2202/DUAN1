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
    public class ServiceKichThuoc: IServiceKichThuoc
    {
        private DatabaseContext1 _dbContext;
        private List<DONVITINH> _lstKichThuoc;

        public ServiceKichThuoc()
        {
            _dbContext = new DatabaseContext1();
            _lstKichThuoc = new List<DONVITINH>();
            _dbContext.KICHTHUOCS.ToList();
        }
        public string ThemKT(DONVITINH kt)
        {
            _dbContext.KICHTHUOCS.Add(kt);
            _dbContext.SaveChanges();
            return "Thêm Thành Công";
        }

        public string SuaKT(DONVITINH kt)
        {
            _dbContext.KICHTHUOCS.Update(kt);
            _dbContext.SaveChanges();
            return "Sửa Thành Công";
        }

        public string XoaKT(DONVITINH kt)
        {
            _dbContext.KICHTHUOCS.Remove(kt);
            _dbContext.SaveChanges();
            return "Xóa Thành Công";
        }

        public List<DONVITINH> GetLstKichThuoc()
        {
            return _lstKichThuoc;
        }
    }
}
