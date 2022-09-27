using DAL.EntityFramework;
using DAL.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class AccountantRepo :IRepo<Accountant, int ,bool>
    {
        Easy_TravelEntities1 db;
        public AccountantRepo(Easy_TravelEntities1 db)
        {
            this.db = db;
        }
        public bool Create(Accountant obj)
        {
            db.Accountants.Add(obj);
            var res = db.SaveChanges();
            return res > 0;
        }

        public bool Delete(int id)
        {
            db.Accountants.Remove(db.Accountants.FirstOrDefault(e => e.ID == id));
            var res = db.SaveChanges();
            return res == 0;
        }

        public List<Accountant> Get()
        {
            return db.Accountants.ToList();
        }

        public Accountant Get(int id)
        {
            return db.Accountants.Find(id);
        }

        public bool Update(Accountant obj)
        {
            var data = db.Accountants.FirstOrDefault(e => e.ID == obj.ID);
            data.Name = obj.Name;
            data.Address = obj.Address;
            data.Email_ID = obj.Email_ID;
            data.Date_of_Birth = obj.Date_of_Birth;
            data.Username = obj.Username;
            data.Password = obj.Password;
            db.SaveChanges();
            return true;
        }
    }
}

