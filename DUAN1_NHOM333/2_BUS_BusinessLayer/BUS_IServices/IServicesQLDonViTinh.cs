using _1_DAL_DataAccesLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_BUS_BusinessLayer.BUS_IServices
{
    public interface IServicesQLDonViTinh
    {

        public string ThemKT(DonViTinh kt);
        public string SuaKT(DonViTinh kt);
        public string XoaKT(DonViTinh kt);
        public List<DonViTinh> GetLstKichThuoc();
        public List<ChatLieu> GetChatLieu();
        public void GetDataFromDB();
    }
}
