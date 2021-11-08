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
    public class ServiceThongTinHangHoa: IServiceThongTinHangHoa
    {
        private DatabaseContext _dbContext;
        private List<ThongTinSanPham> _lstHangHoa;

        public ServiceThongTinHangHoa()
        {
            _dbContext = new DatabaseContext();
            _lstHangHoa = new List<ThongTinSanPham>();
            _lstHangHoa = _dbContext.ThongTinSanPhams.ToList();
        }
        public string ThemTTHH(ThongTinSanPham tthh)
        {
            _dbContext.ThongTinSanPhams.Add(tthh);
            return "Thêm Thành Công";
        }

        public string SuaTTHH(ThongTinSanPham tthh)
        {
            _dbContext.ThongTinSanPhams.Update(tthh);
            return "Sửa Thành Công";
        }

        public string XoaTTHH(ThongTinSanPham tthh)
        {
            tthh.TrangThai = 1;
            if (_dbContext.ThongTinSanPhams.ToList().Any(c => c.MaThongTin == tthh.MaThongTin))
            {
                _dbContext.ThongTinSanPhams.Update(tthh);
                _dbContext.SaveChanges();
                return "Xóa Thành Công";
            }
            else
            {
                return "Xóa Không Thành Công";
            }
        }

        public string LuuTTHH()
        {
            _dbContext.SaveChanges();
            return "Thêm Thành Công";
        }

        public List<ThongTinSanPham> GetLstTTHangHoas()
        {
            return _lstHangHoa;
        }
    }
}
