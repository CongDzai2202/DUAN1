using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1_DAL_DataAccesLayer.Models;

namespace _1_DAL_DataAccesLayer.DAL_IServices
{
    public interface IServiceThongTinHangHoa
    {
        public string ThemTTHH(ThongTinSanPham tthh);
        public string SuaTTHH(ThongTinSanPham tthh);
        public string XoaTTHH(ThongTinSanPham tthh);
        public string LuuTTHH();
        public List<ThongTinSanPham> GetLstTTHangHoas();
    }
}
