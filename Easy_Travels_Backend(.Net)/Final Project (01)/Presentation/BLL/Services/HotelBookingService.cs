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
    public class HotelBookingService
    {
        public static List<HotelBookingModel> Get()
        {
            var config = new MapperConfiguration(c =>

                c.CreateMap<HotelBooking, HotelBookingModel>());

            var mapper = new Mapper(config);
            var data = mapper.Map<List<HotelBookingModel>>(DataAccessFactory.GetHotelBookingDataAccess().Get());
            return data;
        }
        public static void Create(HotelBookingModel r)
        {
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<HotelBookingModel, HotelBooking>();
            });
            var mapper = new Mapper(config);
            var data = mapper.Map<HotelBooking>(r);
            DataAccessFactory.GetHotelBookingDataAccess().Create(data);
        }
        public static HotelBookingModel GetOnly(int id)
        {
            var Data = DataAccessFactory.GetHotelBookingDataAccess().Get(id);
            var d = new HotelBookingModel() { TouristID = Data.TouristID, TouristName = Data.TouristName, TouristPhone = Data.TouristPhone, HotelName = Data.HotelName, Place = Data.Place, Type = Data.Type, Price = Data.Price, Offer = Data.Offer, ExtraInfo = Data.ExtraInfo, No_of_Days = Data.No_of_Days, };
            return d;

        }
        public static void Update(HotelBookingModel r)
        {
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<HotelBookingModel, HotelBooking>();
            });
            var mapper = new Mapper(config);
            var data = mapper.Map<HotelBooking>(r);
            DataAccessFactory.GetHotelBookingDataAccess().Update(data);
        }
        public static void Delete(int id)
        {
            DataAccessFactory.GetHotelBookingDataAccess().Delete(id);
        }
    }
}
