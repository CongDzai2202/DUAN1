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
    public class ServiceXuatXu:IServiceXuatXu
    {
        private List<XuatXu> _lstXuatXu;
        private DatabaseContext _dbContext;

        public ServiceXuatXu()
        {
            _dbContext = new DatabaseContext();
            _lstXuatXu = new List<XuatXu>();
            _lstXuatXu = _dbContext.XuatXus.AsNoTracking().ToList();

        }
        public string ThemXX(XuatXu xx)
        {
            _dbContext.XuatXus.Add(xx);
            _dbContext.SaveChanges();
            return "Thêm Thành Công";
        }

        public string SuaXX(XuatXu xx)
        {
            _dbContext.XuatXus.Update(xx);
            _dbContext.SaveChanges();
            return "Thêm Thành Công";
        }

        public string XoaXX(XuatXu xx)
        {
            _dbContext.XuatXus.Remove(xx);
            _dbContext.SaveChanges();
            return "Thêm Thành Công";
        }

        public List<XuatXu> _GetLstXuatXu()
        {
            return _lstXuatXu;
        }
    }
}
