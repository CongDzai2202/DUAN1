using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1_DAL_DataAccesLayer.Entities;

namespace _1_DAL_DataAccesLayer.DAL_IServices
{
    public interface IServiceThongTinHangHoa
    {
        public string ThemTTHH(THONGTINHANGHOA tthh);
        public string SuaTTHH(THONGTINHANGHOA tthh);
        public string XoaTTHH(THONGTINHANGHOA tthh);
        public string LuuTTHH();
        public List<HANGHOA> GetLstHangHoas();
    }
}
