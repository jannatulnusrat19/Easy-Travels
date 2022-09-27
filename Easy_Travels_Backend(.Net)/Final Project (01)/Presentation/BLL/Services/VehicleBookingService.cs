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
    public class VehicleBookingService
    {
        public static List<VehicleBookingModel> Get()
        {
            var config = new MapperConfiguration(c =>

                c.CreateMap<VehicleBooking, VehicleBookingModel>());

            var mapper = new Mapper(config);
            var data = mapper.Map<List<VehicleBookingModel>>(DataAccessFactory.GetVehicleBookingDataAccess().Get());
            return data;
        }
        public static void Create(VehicleBookingModel r)
        {
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<VehicleBookingModel, VehicleBooking>();
            });
            var mapper = new Mapper(config);
            var data = mapper.Map<VehicleBooking>(r);
            DataAccessFactory.GetVehicleBookingDataAccess().Create(data);
        }
        public static VehicleBookingModel GetOnly(int id)
        {
            var Data = DataAccessFactory.GetVehicleBookingDataAccess().Get(id);
            var d = new VehicleBookingModel() { TouristID = Data.TouristID, TouristName = Data.TouristNmae, TouristPhone = Data.TouristPhone, VehicleID = Data.VehicleID, VehicleName = Data.VehicleName, Type = Data.Type, StartingPoint = Data.StartingPoint, FinishingPoint = Data.FinishingPoint, Price = Data.Price, Offer = Data.Offer, ExtraInfo = Data.ExtraInfo, No_of_Seat = Data.No_of_Seat, };
            return d;
        }
        public static void Update(VehicleBookingModel r)
        {
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<VehicleBookingModel, VehicleBooking>();
            });
            var mapper = new Mapper(config);
            var data = mapper.Map<VehicleBooking>(r);
            DataAccessFactory.GetVehicleBookingDataAccess().Update(data);
        }
        public static void Delete(int id)
        {
            DataAccessFactory.GetVehicleBookingDataAccess().Delete(id);
        }
    }
}
