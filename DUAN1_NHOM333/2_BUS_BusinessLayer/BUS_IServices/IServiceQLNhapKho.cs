using _1_DAL_DataAccesLayer.Models;
using _2_BUS_BusinessLayer.BUS_Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_BUS_BusinessLayer.BUS_IServices
{
    public interface IServiceQLNhapKho
    {
        public List<ViewNhapKho> getLstViewNL();
        //public string Them(ViewNhapKho NK);
        public string Them(PhieuNhap PN);
        public string Sua(PhieuNhap PN);
       // public string Sua(ViewNhapKho NK);
        public string save();
        public void LoadviewNK();
        public ViewNhapKho luachonViewNK(string ViewNK_ma);
        //public PhieuNhapChiTiet GetPhieuNhapChiTiet(string PN_ma);

    }
}
