using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using DAL;
using BLL.BEnt;
using DAL.EntityFramework;
namespace BLL.Services
{
    public class TouristService
    {
        public static List<TouristModel> Get()
        {
            var config = new MapperConfiguration(c =>

                c.CreateMap<CusLogin, TouristModel>())
            {

            };
            var mapper = new Mapper(config);
            var data = mapper.Map<List<TouristModel>>(DataAccessFactory.GetCusLoginDataAccess().Get());
            return data;
        }
        public static void Create(TouristModel s)
        {
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<TouristModel, CusLogin>();
            });
            var mapper = new Mapper(config);
            var data = mapper.Map<CusLogin>(s);
            DataAccessFactory.GetCusLoginDataAccess().Create(data);
        }
        public static TouristModel GetOnly(int id)
        {
            var item = DataAccessFactory.GetCusLoginDataAccess().Get(id);
            var d = new TouristModel() { Id = item.Id, Name = item.Name, Password = item.Password, Address = item.Address, Phone = item.Phone, Email = item.Email};
            return d;

        }
        public static void Update(TouristModel s)
        {
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<TouristModel, CusLogin>();
            });
            var mapper = new Mapper(config);
            var data = mapper.Map<CusLogin>(s);
            DataAccessFactory.GetCusLoginDataAccess().Update(data);
        }
        public static void Delete(int id)
        {
            DataAccessFactory.GetCusLoginDataAccess().Delete(id);
        }
    }
}
