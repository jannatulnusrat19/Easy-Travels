using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.BEnt
{
    public class BookedHotelModel
    {
        public int TouristID { get; set; }
        public string TouristName { get; set; }
        public string TouristPhone { get; set; }
        public string HotelName { get; set; }
        public string Place { get; set; }
        public string Price { get; set; }
        public string Offer { get; set; }
        public int No_of_Days { get; set; }
        public Nullable<int> TotalAmount { get; set; }
    }
}
