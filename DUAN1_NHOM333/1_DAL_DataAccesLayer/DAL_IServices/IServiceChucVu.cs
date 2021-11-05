using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1_DAL_DataAccesLayer.Entities;

namespace _1_DAL_DataAccesLayer.DAL_IServices
{
    public interface IServiceChucVu
    {
        public string Them(CHUCVU cv);
        public string Sua(CHUCVU cv);
        public string Xoa(CHUCVU cv);
        public List<CHUCVU> GetLstChucvus();
    }
}
