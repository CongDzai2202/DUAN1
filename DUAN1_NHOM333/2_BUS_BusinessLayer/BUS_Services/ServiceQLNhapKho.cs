using _1_DAL_DataAccesLayer.DAL_IServices;
using _1_DAL_DataAccesLayer.DAL_Services;
using _1_DAL_DataAccesLayer.Models;
using _2_BUS_BusinessLayer.BUS_IServices;
using _2_BUS_BusinessLayer.BUS_Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_BUS_BusinessLayer.BUS_Services
{
    public class ServiceQLNhapKho : IServiceQLNhapKho
    {
        private IServiceNhaCungCap _iServiceNhaCungCap;
        private IServicePhieuNhap _iServicePhieuNhap;
        private IServiceChiTietPhieuNhap _iServiceChiTietPhieuNhap;
        private IServiceThongTinHangHoa _iServiceThongTinHangHoa;
        private List<PhieuNhap> _lstPhieuNhaps;
        private List<PhieuNhapChiTiet> _lstPhieuNhapCTs;
        private List<NhaCungCap> _lstNhaCungCaps;
        private List<ThongTinSanPham> _lstThongTinSanPhams;
        private List<ViewNhapKho> _lstViewNKs;

        public ServiceQLNhapKho()
        {
            _iServiceNhaCungCap = new ServiceNhaCungCap();
            _iServicePhieuNhap = new ServicePhieuNhap();
            _iServiceChiTietPhieuNhap = new ServiceChiTietPhieuNhap();
            _iServiceThongTinHangHoa = new ServiceThongTinHangHoa();
            _lstPhieuNhaps = new List<PhieuNhap>();
            _lstThongTinSanPhams = new List<ThongTinSanPham>();
            _lstNhaCungCaps = new List<NhaCungCap>();
            _lstPhieuNhapCTs = new List<PhieuNhapChiTiet>();
            _lstViewNKs = new List<ViewNhapKho>();
            LoadviewNK();
        }
        /*public string Them(ViewNhapKho NK)
        {
            try
            {
                _lstViewNKs.Add(NK);
                return "";
            }
            catch (Exception e)
            {
                return e.Message;
            }
            
        }*/
        public string Them(PhieuNhap PN)
        {
            return _iServicePhieuNhap.ThemPN(PN);
        }

        public List<ViewNhapKho> getLstViewNL()
        {
            return _lstViewNKs;
        }
        public void LoadviewNK()
        {
            #region c1
            /* _lstPhieuNhapCTs = _iServiceChiTietPhieuNhap.GetLstChiTietPhieuNhaps();
                _lstPhieuNhaps = _iServicePhieuNhap.GetLstPhieunhaps();
                var listview = (from ctpn in _lstPhieuNhapCTs
                                join pn in _lstPhieuNhaps
                                on ctpn.MaPhieuNhap equals pn.MaPhieuNhap
                                select new
                                {
                                    PhieuNhapChiTiet = ctpn,
                                    PhieuNhap = pn
                                }).ToList();
                listview.ForEach(x =>
                {
                    ViewNhapKho view = new ViewNhapKho();
                    view.Phieunhapchitiet = x.PhieuNhapChiTiet;
                    view.Phieunhap = x.PhieuNhap;
                    _lstViewNKs.Add(view);
                });*/
            #endregion
            #region loaddata
            _lstNhaCungCaps = _iServiceNhaCungCap.GetLstNhaCungCaps();
            _lstPhieuNhaps = _iServicePhieuNhap.GetLstPhieunhaps();
            _lstPhieuNhapCTs = _iServiceChiTietPhieuNhap.GetLstChiTietPhieuNhaps();
            _lstThongTinSanPhams = _iServiceThongTinHangHoa.GetLstTTHangHoas();
            var listNK = (from ncc in _lstNhaCungCaps
                            join pn in _lstPhieuNhaps on ncc.MaNhaCungCap equals pn.MaNhaCungCap
                            join pnct in _lstPhieuNhapCTs on pn.MaPhieuNhap equals pnct.MaPhieuNhap
                            join ttsp in _lstThongTinSanPhams on pnct.MaThongTin equals ttsp.MaThongTin 
                            select new
                            {
                                thongtinsanpham = ttsp,
                                PhieuNhapChiTiet = pnct,
                                PhieuNhap = pn,
                                nhacungcap = ncc
                            }).ToList();
            listNK.ForEach(x =>
            {
                ViewNhapKho view = new ViewNhapKho();
                view.ThongtinSP = x.thongtinsanpham;
                view.Phieunhapchitiet = x.PhieuNhapChiTiet;
                view.Phieunhap = x.PhieuNhap;
                view.Nhacungcap = x.nhacungcap;
                _lstViewNKs.Add(view);
            });
            #endregion
        }
        public string Sua(PhieuNhap PN)
        {
            return _iServicePhieuNhap.SuaPN(PN);
        }
        /*public string Sua(ViewNhapKho NK)
        {
            #region c1
            try
            {
                var index = _lstViewNKs.FindIndex(x => x.Phieunhap.MaPhieuNhap == NK.Phieunhap.MaPhieuNhap);
                _lstViewNKs[index] = NK;
                return _iServicePhieuNhap.SuaPN(NK.Phieunhap);
            }
            catch (Exception e)
            {
                return e.Message;
            } 
            #endregion
        }*/

        public ViewNhapKho luachonViewNK(string ViewNK_ma)
        {
            return _lstViewNKs.Where(x => x.Phieunhap.MaPhieuNhap == ViewNK_ma).FirstOrDefault();
        }

        public string save()
        {
            return _iServicePhieuNhap.LuuPN();
        }

       /* public PhieuNhapChiTiet GetPhieuNhapChiTiet(string PN_ma)
        {
            return _lstPhieuNhapCTs.Where(x => x.MaCtphieuNhap == PN_ma).FirstOrDefault();
        }*/
    }
}
