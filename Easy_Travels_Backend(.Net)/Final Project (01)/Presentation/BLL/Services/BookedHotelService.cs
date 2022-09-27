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
    public class BookedHotelService
    {
        public static List<BookedHotelModel> Get()
        {
            var config = new MapperConfiguration(c =>

                c.CreateMap<BookedHotel, BookedHotelModel>());

            var mapper = new Mapper(config);
            var data = mapper.Map<List<BookedHotelModel>>(DataAccessFactory.GetBookedHotelDataAccess().Get());
            return data;
        }
        public static void Create(BookedHotelModel r)
        {
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<BookedHotelModel, BookedHotel>();
            });
            var mapper = new Mapper(config);
            var data = mapper.Map<BookedHotel>(r);
            DataAccessFactory.GetBookedHotelDataAccess().Create(data);
        }
        public static BookedHotelModel GetOnly(int id)
        {
            var item = DataAccessFactory.GetBookedHotelDataAccess().Get(id);
            var d = new BookedHotelModel() { TouristID = item.TouristID, TouristName = item.TouristName, TouristPhone = item.TouristPhone, HotelName = item.HotelName, Place = item.Place, Price = item.Price, Offer = item.Offer, No_of_Days = item.No_of_Days, TotalAmount = item.TotalAmount };
            return d;

        }
        //public static void Update(BookedHotelModel r)
        //{
        //    var config = new MapperConfiguration(c =>
        //    {
        //        c.CreateMap<BookedHotelModel, BookedHotel>();
        //    });
        //    var mapper = new Mapper(config);
        //    var data = mapper.Map<BookedHotel>(r);
        //    DataAccessFactory.GetBookedHotelDataAccess().Update(data);
        //}
        //public static void Delete(int id)
        //{
        //    DataAccessFactory.GetBookedHotelDataAccess().Delete(id);
        //}
    }
}
