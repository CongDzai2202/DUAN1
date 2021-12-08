using _2_BUS_BusinessLayer.BUS_Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_BUS_BusinessLayer.BUS_IServices
{
    public interface IServiceThongKe
    {
        public List<Bus_ThongKe> GetLstBusThongKe();
    }
}
