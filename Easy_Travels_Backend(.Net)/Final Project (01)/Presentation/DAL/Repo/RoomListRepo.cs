using DAL.EntityFramework;
using DAL.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class RoomListRepo : IRepo<RoomList, int, bool>
    {
        Easy_TravelEntities1 db;
        public RoomListRepo(Easy_TravelEntities1 db)
        {
            this.db = db;
        }
        public bool Create(RoomList obj)
        {
            db.RoomLists.Add(obj);
            var res = db.SaveChanges();
            return res > 0;
        }

        public bool Delete(int id)
        {
            db.RoomLists.Remove(db.RoomLists.FirstOrDefault(e => e.Id == id));
            var res = db.SaveChanges();
            return res == 0;
        }

        public List<RoomList> Get()
        {
            return db.RoomLists.ToList();
        }

        public RoomList Get(int id)
        {
            return db.RoomLists.Find(id);
        }

        public bool Update(RoomList obj)
        {
            var data = db.RoomLists.FirstOrDefault(e => e.Id == obj.Id);
            data.Name = obj.Name;
            data.Place = obj.Place;
            data.Type = obj.Type;
            data.Price = obj.Price;
            data.Offer = obj.Offer;
            data.ExtraInfo = obj.ExtraInfo;
            db.SaveChanges();
            return true;
        }
    }
}

