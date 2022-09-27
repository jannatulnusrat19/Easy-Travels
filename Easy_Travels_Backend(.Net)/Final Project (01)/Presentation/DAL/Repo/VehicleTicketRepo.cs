using DAL.EntityFramework;
using DAL.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class VehicleTicketRepo : IRepo<TicketBooking, int, bool>
    {
        Easy_TravelEntities1 db;
        public VehicleTicketRepo(Easy_TravelEntities1 db)
        {
            this.db = db;
        }
        public bool Create(TicketBooking obj)
        {
            db.TicketBookings.Add(obj);
            var res = db.SaveChanges();
            return res > 0;
        }

        public bool Delete(int id)
        {
            db.TicketBookings.Remove(db.TicketBookings.FirstOrDefault(e => e.CusID == id));
            var res = db.SaveChanges();
            return res == 0;
        }

        public List<TicketBooking> Get()
        {
            return db.TicketBookings.ToList();
        }

        public TicketBooking Get(int id)
        {
            return db.TicketBookings.Find(id);
        }

        public bool Update(TicketBooking obj)
        {
            var data = db.TicketBookings.FirstOrDefault(e => e.CusID == obj.CusID);
            data.VehicleName = obj.VehicleName;
            data.StartingPoint = obj.StartingPoint;
            data.FinishingPont = obj.FinishingPont;
            data.VehicleType = obj.VehicleType;
            data.BookingDate = obj.BookingDate;
            data.SeatNO = obj.SeatNO;
            data.Payment = obj.Payment;
            data.TransactionNO = obj.TransactionNO;
            data.Status = obj.Status;
            db.SaveChanges();
            return true;

        }




    }
}

