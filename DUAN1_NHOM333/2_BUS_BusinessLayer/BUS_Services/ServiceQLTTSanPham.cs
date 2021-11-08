using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1_DAL_DataAccesLayer.DAL_IServices;
using _1_DAL_DataAccesLayer.DAL_Services;
using _1_DAL_DataAccesLayer.Models;
using _2_BUS_BusinessLayer.BUS_IServices;

namespace _2_BUS_BusinessLayer.BUS_Services
{
    public class ServiceQLTTSanPham: IServiceQLCTSanPham
    {
        private IServiceThongTinHangHoa _iServiceThongTinHangHoa;

        public ServiceQLTTSanPham()
        {
            _iServiceThongTinHangHoa = new ServiceThongTinHangHoa();
        }
        public List<ThongTinSanPham> GetLstThongTinSanPhams()
        {
            return _iServiceThongTinHangHoa.GetLstTTHangHoas();
        }

        public string ThemSP(ThongTinSanPham hh)
        {
            return _iServiceThongTinHangHoa.ThemTTHH(hh);
        }

        public string SuaSP(ThongTinSanPham hh)
        {
            return _iServiceThongTinHangHoa.SuaTTHH(hh);
        }

        public string XoaSP(ThongTinSanPham hh)
        {
            return _iServiceThongTinHangHoa.XoaTTHH(hh);
        }

        public string LuuSP()
        {
            return _iServiceThongTinHangHoa.LuuTTHH();
        }
    }
}
