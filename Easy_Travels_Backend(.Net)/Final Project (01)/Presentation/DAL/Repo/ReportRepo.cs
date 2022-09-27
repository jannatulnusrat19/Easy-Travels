using DAL.EntityFramework;
using DAL.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ReportRepo : IRepo<Report, int, bool>
    {
        Easy_TravelEntities1 db;
        public ReportRepo(Easy_TravelEntities1 db)
        {
            this.db = db;
        }
        public bool Create(Report obj)
        {
            db.Reports.Add(obj);
            var res = db.SaveChanges();
            return res > 0;
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<Report> Get()
        {
            return db.Reports.ToList();
        }

        public Report Get(int id)
        {
            return db.Reports.Find(id);
        }

        public bool Update(Report obj)
        {
            throw new NotImplementedException();
        }
    }
}

