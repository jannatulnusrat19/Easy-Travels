using DAL.EntityFramework;
using DAL.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class BookedHotelRepo : IRepo<BookedHotel, int, bool>
    {
        Easy_TravelEntities1 db;
        public BookedHotelRepo(Easy_TravelEntities1 db)
        {
            this.db = db;
        }
        public bool Create(BookedHotel obj)
        {
            db.BookedHotels.Add(obj);
            var res = db.SaveChanges();
            return res > 0;
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<BookedHotel> Get()
        {
            return db.BookedHotels.ToList();
        }

        public BookedHotel Get(int id)
        {
            return db.BookedHotels.Find(id);
        }

        public bool Update(BookedHotel obj)
        {
            throw new NotImplementedException();
        }
    }
}

