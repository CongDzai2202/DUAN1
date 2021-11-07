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
    public class ServiceChiTietPhieuNhap: IServiceChiTietPhieuNhap
    {
        private DatabaseContext1 _dbContext;
        private List<CHITIETPHIEUNHAP> _lstChiTietPhieuNhaps;

        public ServiceChiTietPhieuNhap()
        {
            _dbContext = new DatabaseContext1();
            _lstChiTietPhieuNhaps = new List<CHITIETPHIEUNHAP>();
            _dbContext.CHITIETPHIEUNHAPS.ToList();
        }
        public string ThemCTPN(CHITIETPHIEUNHAP ctpn)
        {
            _dbContext.CHITIETPHIEUNHAPS.Add(ctpn);
            return "Thêm Thành Công";
        }

        public string SuaCTPN(CHITIETPHIEUNHAP ctpn)
        {
            _dbContext.CHITIETPHIEUNHAPS.Update(ctpn);
            return "Sửa Thành Công";
        }

        public string XoaCTPN(CHITIETPHIEUNHAP ctpn)
        {
            ctpn.TRANGTHAI = 1;
            if (_dbContext.CHITIETPHIEUNHAPS.ToList().Any(c => c.MACHITIETPHIEUNHAP == ctpn.MACHITIETPHIEUNHAP))
            {
                _dbContext.CHITIETPHIEUNHAPS.Update(ctpn);
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

        public List<CHITIETPHIEUNHAP> GetLstChiTietPhieuNhaps()
        {
            return _lstChiTietPhieuNhaps;
        }
    }
}
