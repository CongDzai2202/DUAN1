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
    public class ServiceThongTinHangHoa: IServiceThongTinHangHoa
    {
        private DatabaseContext1 _dbContext;
        private List<HANGHOA> _lstHangHoa;

        public ServiceThongTinHangHoa()
        {
            _dbContext = new DatabaseContext1();
            _lstHangHoa = new List<HANGHOA>();
            _dbContext.THONGTINHANGHOAS.ToList();
        }
        public string ThemTTHH(THONGTINHANGHOA tthh)
        {
            _dbContext.THONGTINHANGHOAS.Add(tthh);
            return "Thêm Thành Công";
        }

        public string SuaTTHH(THONGTINHANGHOA tthh)
        {
            _dbContext.THONGTINHANGHOAS.Update(tthh);
            return "Sửa Thành Công";
        }

        public string XoaTTHH(THONGTINHANGHOA tthh)
        {
            tthh.TRANGTHAI = false;
            if (_dbContext.THONGTINHANGHOAS.ToList().Any(c => c.MATHONGTIN == tthh.MATHONGTIN))
            {
                _dbContext.THONGTINHANGHOAS.Update(tthh);
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

        public List<HANGHOA> GetLstHangHoas()
        {
            return _lstHangHoa;
        }
    }
}
