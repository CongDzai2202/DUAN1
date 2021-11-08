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
    public class ServiceChiTietPhieuNhap: IServiceChiTietPhieuNhap
    {
        private DatabaseContext _dbContext;
        private List<PhieuNhapChiTiet> _lstChiTietPhieuNhaps;

        public ServiceChiTietPhieuNhap()
        {
            _dbContext = new DatabaseContext();
            _lstChiTietPhieuNhaps = new List<PhieuNhapChiTiet>();
            _dbContext.PhieuNhapChiTiets.ToList();
        }
        public string ThemCTPN(PhieuNhapChiTiet ctpn)
        {
            _dbContext.PhieuNhapChiTiets.Add(ctpn);
            return "Thêm Thành Công";
        }

        public string SuaCTPN(PhieuNhapChiTiet ctpn)
        {
            _dbContext.PhieuNhapChiTiets.Update(ctpn);
            return "Sửa Thành Công";
        }

        public string XoaCTPN(PhieuNhapChiTiet ctpn)
        {
            ctpn.TrangThai = 1;
            if (_dbContext.PhieuNhapChiTiets.ToList().Any(c => c.MaCtphieuNhap == ctpn.MaCtphieuNhap))
            {
                _dbContext.PhieuNhapChiTiets.Update(ctpn);
                _dbContext.SaveChanges();
                return "Xóa Thành Công";
            }
            else
            {
                return "Xóa Không Thành Công";
            }
        }

        public string LuuCTPN()
        {
            _dbContext.SaveChanges();
            return "Lưu Thành Công";
        }

        public List<PhieuNhapChiTiet> GetLstChiTietPhieuNhaps()
        {
            return _lstChiTietPhieuNhaps;
        }
    }
}
