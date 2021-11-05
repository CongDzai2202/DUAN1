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
    public class ServiceHangHoa : IServiceHangHoa
    {
        private DatabaseContext1 _dbContext;
        private List<HANGHOA> _lstHangHoa;

        public ServiceHangHoa()
        {
            _dbContext = new DatabaseContext1();
            _lstHangHoa = new List<HANGHOA>();
            _dbContext.HANGHOAS.ToList();
        }

        public string ThemHH(HANGHOA hh)
        {
            _dbContext.HANGHOAS.Add(hh);
            _dbContext.SaveChanges();
            return "Thêm Thành Công";
        }

        public string SuaHH(HANGHOA hh)
        {
            _dbContext.HANGHOAS.Update(hh);
            _dbContext.SaveChanges();
            return "Sửa Thành Công";
        }

        public string XoaHH(HANGHOA hh)
        {
            return "Xóa Thành Công";
        }

        public List<HANGHOA> GetLstHangHoa()
        {
            return _lstHangHoa;
        }
    }
}
