using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.BEnt
{
    public class HotelBookingModel
    {
        public int TouristID { get; set; }
        public string TouristName { get; set; }
        public string TouristPhone { get; set; }
        public string HotelName { get; set; }
        public string Place { get; set; }
        public string Type { get; set; }
        public int Price { get; set; }
        public string Offer { get; set; }
        public string ExtraInfo { get; set; }
        public int No_of_Days { get; set; }
    }
}
