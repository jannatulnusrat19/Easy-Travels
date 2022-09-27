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
    public class BookedVehicleService
    {
        public static List<BookedVehicleModel> Get()
        {
            var config = new MapperConfiguration(c =>

                c.CreateMap<BookedVehicle, BookedVehicleModel>());

            var mapper = new Mapper(config);
            var data = mapper.Map<List<BookedVehicleModel>>(DataAccessFactory.GetBookedVehicleDataAccess().Get());
            return data;
        }
        public static void Create(BookedVehicleModel r)
        {
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<BookedVehicleModel, BookedVehicle>();
            });
            var mapper = new Mapper(config);
            var data = mapper.Map<BookedVehicle>(r);
            DataAccessFactory.GetBookedVehicleDataAccess().Create(data);
        }
        public static BookedVehicleModel GetOnly(int id)
        {
            var item = DataAccessFactory.GetBookedVehicleDataAccess().Get(id);
            var d = new BookedVehicleModel() { TouristID = item.TouristID, TouristName = item.TouristName, TouristPhone = item.TouristPhone, VehicleID = item.VehicleID, VehicleName = item.VehicleName, Type = item.Type, StartingPoint = item.StartingPoint, FinishingPoint = item.FinishingPoint, Price = item.Price, Offer = item.Offer, ExtraInfo = item.ExtraInfo, No_of_Seat = item.No_of_Seat, TotalAmmount = item.TotalAmmount };
            return d;

        }
        public static void Update(BookedVehicleModel r)
        {
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<BookedVehicleModel, BookedVehicle>();
            });
            var mapper = new Mapper(config);
            var data = mapper.Map<BookedVehicle>(r);
            DataAccessFactory.GetBookedVehicleDataAccess().Update(data);
        }

        public static void Delete(int id)
        {
            DataAccessFactory.GetBookedVehicleDataAccess().Delete(id);
        }
    }
}
