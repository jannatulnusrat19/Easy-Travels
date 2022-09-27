using DAL.EntityFramework;
using DAL.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class BookedVehicleRepo : IRepo<BookedVehicle, int, bool>
    {
        Easy_TravelEntities1 db;
        public BookedVehicleRepo(Easy_TravelEntities1 db)
        {
            this.db = db;
        }
        public bool Create(BookedVehicle obj)
        {
            db.BookedVehicles.Add(obj);
            var res = db.SaveChanges();
            return res > 0;
        }

        public bool Delete(int id)
        {
            db.BookedVehicles.Remove(db.BookedVehicles.FirstOrDefault(e => e.TouristID == id));
            var res = db.SaveChanges();
            return res == 0;
        }

        public List<BookedVehicle> Get()
        {
            return db.BookedVehicles.ToList();
        }

        public BookedVehicle Get(int id)
        {
            return db.BookedVehicles.Find(id);
        }

        public bool Update(BookedVehicle obj)
        {
            var data = db.BookedVehicles.FirstOrDefault(e => e.TouristID == obj.TouristID);
            data.TouristName = obj.TouristName;
            data.TouristPhone = obj.TouristPhone;
            data.VehicleID = obj.VehicleID;
            data.VehicleName = obj.VehicleName;
            data.Type = obj.Type;
            data.StartingPoint = obj.StartingPoint;
            data.FinishingPoint = obj.FinishingPoint;
            data.Price = obj.Price;
            data.Offer = obj.Offer;
            data.ExtraInfo = obj.ExtraInfo;
            data.No_of_Seat = obj.No_of_Seat;
            data.TotalAmmount = obj.TotalAmmount;
            db.SaveChanges();
            return true;
        }
    }
}

