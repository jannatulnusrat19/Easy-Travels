using DAL.EntityFramework;
using DAL.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class HotelBookingRepo : IRepo<HotelBooking, int,bool>
    {
        Easy_TravelEntities1 db;
        public HotelBookingRepo(Easy_TravelEntities1 db)
        {
            this.db = db;
        }
        public bool Create(HotelBooking obj)
        {
            db.HotelBookings.Add(obj);
            var res = db.SaveChanges();
            return res > 0;
        }

        public bool Delete(int id)
        {
            db.HotelBookings.Remove(db.HotelBookings.FirstOrDefault(e => e.TouristID == id));
            var res = db.SaveChanges();
            return res == 0;
        }

        public List<HotelBooking> Get()
        {
            return db.HotelBookings.ToList();
        }

        public HotelBooking Get(int id)
        {
            return db.HotelBookings.Find(id);
        }

        public bool Update(HotelBooking obj)
        {
            var data = db.HotelBookings.FirstOrDefault(e => e.TouristID == obj.TouristID);
            data.TouristName = obj.TouristName;
            data.TouristPhone = obj.TouristPhone;
            data.HotelName = obj.HotelName;
            data.Place = obj.Place;
            data.Type = obj.Type;
            data.Price = obj.Price;
            data.Offer = obj.Offer;
            data.ExtraInfo = obj.ExtraInfo;
            data.No_of_Days = obj.No_of_Days;
            db.SaveChanges();
            return true;
        }
    }
}

