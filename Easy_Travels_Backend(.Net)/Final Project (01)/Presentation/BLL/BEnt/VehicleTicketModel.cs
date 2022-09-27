using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.BEnt
{
    public class VehicleTicketModel
    {
        public int CusID { get; set; }
        public string VehicleName { get; set; }
        public string StartingPoint { get; set; }
        public string FinishingPont { get; set; }
        public string VehicleType { get; set; }
        public string BookingDate { get; set; }
        public string SeatNO { get; set; }
        public string Payment { get; set; }
        public string TransactionNO { get; set; }
        public string Status { get; set; }
    }
}
