using BLL.BEnt;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using DAL;
using DAL.EntityFramework;

namespace BLL.Services
{
    public class HotelRegService
    {
        public static List<HotelRegModel> Get()
        {
            var config = new MapperConfiguration(c =>

                c.CreateMap<HotelReg, HotelRegModel>());

            var mapper = new Mapper(config);
            var data = mapper.Map<List<HotelRegModel>>(DataAccessFactory.GetHotelRegDataAccess().Get());
            return data;
        }
        public static void Create(HotelRegModel r)
        {
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<HotelRegModel, HotelReg>();
            });
            var mapper = new Mapper(config);
            var data = mapper.Map<HotelReg>(r);
            DataAccessFactory.GetHotelRegDataAccess().Create(data);
        }
        public static HotelRegModel GetOnly(int id)
        {
            var item = DataAccessFactory.GetHotelRegDataAccess().Get(id);
            var d = new HotelRegModel() { Id = item.Id, Name = item.Name, Password = item.Password, Type = item.Type, Place = item.Place, Address = item.Address, Phone = item.Phone, Email = item.Email };
            return d;

        }
        public static void Update(HotelRegModel r)
        {
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<HotelRegModel, HotelReg>();
            });
            var mapper = new Mapper(config);
            var data = mapper.Map<HotelReg>(r);
            DataAccessFactory.GetHotelRegDataAccess().Update(data);
        }
        public static void Delete(int id)
        {
            DataAccessFactory.GetHotelRegDataAccess().Delete(id);
        }
    }

}
