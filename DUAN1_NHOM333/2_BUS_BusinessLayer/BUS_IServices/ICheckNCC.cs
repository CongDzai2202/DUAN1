using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_BUS_BusinessLayer.BUS_IServices
{
    public interface ICheckNCC
    {
        public bool checkSDT(string sdt);
        public bool checkEmail(string email);
        public bool checkChu(string test);
        public bool checkSo(string test);
        public bool checkNull(string text);
    }
}
