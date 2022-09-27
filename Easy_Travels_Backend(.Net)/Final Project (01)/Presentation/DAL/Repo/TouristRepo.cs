using DAL.EntityFramework;
using DAL.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repo
{
    public class TouristRepo : IRepo<CusLogin, int , bool>
    {
        Easy_TravelEntities1 db;
        public TouristRepo(Easy_TravelEntities1 db)
        {
            this.db = db;
        }
        public bool Create(CusLogin obj)
        {
            db.CusLogins.Add(obj);
            var res = db.SaveChanges();
            return res > 0;
        }

        public bool Delete(int id)
        {
            db.CusLogins.Remove(db.CusLogins.FirstOrDefault(e => e.Id == id));
            var res = db.SaveChanges();
            return res == 0;
        }

        public List<CusLogin> Get()
        {
            return db.CusLogins.ToList();
        }

        public CusLogin Get(int id)
        {
            return db.CusLogins.Find(id);
        }

        public bool Update(CusLogin obj)
        {
            var data = db.CusLogins.FirstOrDefault(e => e.Id == obj.Id);
            data.Name = obj.Name;
            data.Password = obj.Password;
            data.Address = obj.Address;
            data.Phone = obj.Phone;
            data.Email = obj.Email;
            db.SaveChanges();
            return true;
        }
    }
}
