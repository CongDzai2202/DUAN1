using _1_DAL_DataAccesLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_BUS_BusinessLayer.BUS_IServices
{
    public interface IServicesQLNhaCungCap
    {
        public List<NhaCungCap> getLstNhaCungCaps();
        public string ThemNCC(NhaCungCap ncc);
        public string SuaNCC(NhaCungCap ncc);
        public string saveNCC();
        public bool Statusdata();
    }
}
