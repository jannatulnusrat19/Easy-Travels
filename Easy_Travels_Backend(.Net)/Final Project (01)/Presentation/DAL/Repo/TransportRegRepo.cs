using DAL.EntityFramework;
using DAL.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class TransportRegRepo : IRepo<TransportReg, int, bool>
    {
        Easy_TravelEntities1 db;
        public TransportRegRepo(Easy_TravelEntities1 db)
        {
            this.db = db;
        }


        public bool Create(TransportReg obj)
        {
            db.TransportRegs.Add(obj);
            var res = db.SaveChanges();
            return res > 0;
        }

        public bool Delete(int id)
        {
            db.TransportRegs.Remove(db.TransportRegs.FirstOrDefault(e => e.Id == id));
            var res = db.SaveChanges();
            return res == 0;
        }

        public List<TransportReg> Get()
        {
            return db.TransportRegs.ToList();
        }

        public TransportReg Get(int id)
        {
            return db.TransportRegs.Find(id);
        }

        public bool Update(TransportReg obj)
        {
            var data = db.TransportRegs.FirstOrDefault(e => e.Id == obj.Id);
            data.Name = obj.Name;
            data.Email= obj.Email;
            data.Phone = obj.Phone;
            data.Type = obj.Type;
            data.Password = obj.Password;
            db.SaveChanges();
            return true;

        }

    }
}

