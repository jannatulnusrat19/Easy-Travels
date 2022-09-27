using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.BEnt
{
    public class BookedVehicleModel
    {
        public int TouristID { get; set; }
        public string TouristName { get; set; }
        public string TouristPhone { get; set; }
        public int VehicleID { get; set; }
        public string VehicleName { get; set; }
        public string Type { get; set; }
        public string StartingPoint { get; set; }
        public string FinishingPoint { get; set; }
        public int Price { get; set; }
        public string Offer { get; set; }
        public string ExtraInfo { get; set; }
        public int No_of_Seat { get; set; }
        public int TotalAmmount { get; set; }
    }
}
