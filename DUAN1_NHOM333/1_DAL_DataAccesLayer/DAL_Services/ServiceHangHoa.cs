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
    public class ServiceHangHoa : IServiceHangHoa
    {
        private DatabaseContext _dbContext;
        private List<SanPham> _lstHangHoa;

        public ServiceHangHoa()
        {
            _dbContext = new DatabaseContext();
            _lstHangHoa = new List<SanPham>();
            _lstHangHoa = _dbContext.SanPhams.ToList();
        }

        public string ThemHH(SanPham hh)
        {
            _dbContext.SanPhams.Add(hh);
            _dbContext.SaveChanges();
            return "Thêm Thành Công";
        }

        public string SuaHH(SanPham hh)
        {
            _dbContext.SanPhams.Update(hh);
            _dbContext.SaveChanges();
            return "Sửa Thành Công";
        }

        public string XoaHH(SanPham hh)
        {
            return "Xóa Thành Công";
        }

        public List<SanPham> GetLstHangHoa()
        {
            return _lstHangHoa;
        }
    }
}
