using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1_DAL_DataAccesLayer.Models;

namespace _1_DAL_DataAccesLayer.DAL_IServices
{
    public interface IServiceDonViTinh
    {
        public string ThemKT(DonViTinh kt);
        public string SuaKT(DonViTinh kt);
        public string XoaKT(DonViTinh kt);
        public List<DonViTinh> GetLstKichThuoc();
    }
}
