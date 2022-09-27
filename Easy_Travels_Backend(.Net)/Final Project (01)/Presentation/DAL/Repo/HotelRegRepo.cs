using DAL.EntityFramework;
using DAL.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class HotelRegRepo : IRepo<HotelReg, int, bool>, IAuth<HotelReg>
    {
        Easy_TravelEntities1 db;
        public HotelRegRepo(Easy_TravelEntities1 db)
        {
            this.db = db;
        }

        public HotelReg Authenticate(string email, string password)
        {
            return db.HotelRegs.FirstOrDefault(u => u.Email.Equals(email)
         && u.Password.Equals(password));
        }

        public bool Create(HotelReg obj)
        {
            db.HotelRegs.Add(obj);
            var res = db.SaveChanges();
            return res > 0;
        }

        public bool Delete(int id)
        {
            db.HotelRegs.Remove(db.HotelRegs.FirstOrDefault(e => e.Id == id));
            var res = db.SaveChanges();
            return res == 0;
        }

        public List<HotelReg> Get()
        {
            return db.HotelRegs.ToList();
        }

        public HotelReg Get(int id)
        {
            return db.HotelRegs.Find(id);
        }

        public bool Logout(string token)
        {
            throw new NotImplementedException();
        }

        public bool Update(HotelReg obj)
        {
            var data = db.HotelRegs.FirstOrDefault(e => e.Id == obj.Id);
            data.Name = obj.Name;
            data.Password = obj.Password;
            data.Type = obj.Type;
            data.Place = obj.Place;
            data.Address = obj.Address;
            data.Phone = obj.Phone;
            data.Email = obj.Email;
            db.SaveChanges();
            return true;

        }




    }
}

