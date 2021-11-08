using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1_DAL_DataAccesLayer.Models;
using _1_DAL_DataAccesLayer.Models;

namespace _1_DAL_DataAccesLayer.DAL_IServices
{
    public interface IServiceChucVu
    {
        public string Them(ChucVu cv);
        public string Sua(ChucVu cv);
        public string Xoa(ChucVu cv);
        public List<ChucVu> GetLstChucvus();
    }
}
