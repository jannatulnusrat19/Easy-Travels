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
    public class VehicleTicketService
    {
        public static List<VehicleTicketModel> Get()
        {
            var config = new MapperConfiguration(c =>

                c.CreateMap<TicketBooking, VehicleTicketModel>());

            var mapper = new Mapper(config);
            var data = mapper.Map<List<VehicleTicketModel>>(DataAccessFactory.GetTicketBookingDataAccess().Get());
            return data;
        }
        public static void Create(VehicleTicketModel r)
        {
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<VehicleTicketModel, TicketBooking>();
            });
            var mapper = new Mapper(config);
            var data = mapper.Map<TicketBooking>(r);
            DataAccessFactory.GetTicketBookingDataAccess().Create(data);
        }
        public static VehicleTicketModel GetOnly(int id)
        {
            var item = DataAccessFactory.GetTicketBookingDataAccess().Get(id);
            var d = new VehicleTicketModel() { CusID = item.CusID, VehicleName = item.VehicleName, StartingPoint = item.StartingPoint, FinishingPont = item.FinishingPont, VehicleType = item.VehicleType, BookingDate = item.BookingDate, SeatNO = item.SeatNO, Payment = item.Payment, TransactionNO = item.TransactionNO, Status = item.Status };
            return d;

        }

        public static void Update(VehicleTicketModel r)
        {
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<VehicleTicketModel, TicketBooking>();
            });
            var mapper = new Mapper(config);
            var data = mapper.Map<TicketBooking>(r);
            DataAccessFactory.GetTicketBookingDataAccess().Update(data);
        }
        public static void Delete(int id)
        {
            DataAccessFactory.GetTicketBookingDataAccess().Delete(id);
        }


    }

}
