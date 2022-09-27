using DAL.Interface;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Repo;
using DAL.EntityFramework;

namespace DAL
{
    public class DataAccessFactory
    {
        static Easy_TravelEntities1 db = new Easy_TravelEntities1();
        public static IRepo<AdminList, int , bool> GetAdminListDataAccess()
        {
            return new AdminRepo(db);
        }
        public static IRepo<Accountant, int, bool> GetAccountantDataAccess()
        {
            return new AccountantRepo(db);
        }
        public static IRepo<CusLogin, int, bool> GetCusLoginDataAccess()
        {
            return new TouristRepo(db);
        }
        public static IAuth<AdminList> GetAuthDataAccess()
        {
            return new AdminRepo(db);
        }
        public static IRepo<Token, string, Token> GetTokenDataAccess()
        {
            return new TokenRepo(db);
        }




        //Hotel Owner
      
        public static IRepo<RoomList, int, bool> GetRoomListDataAccess()
        {
            return new RoomListRepo(db);
        }
        public static IRepo<Inq, int, bool> GetInqDataAccess()
        {
            return new InqRepo(db);
        }
        public static IRepo<Report, int, bool> GetReportDataAccess()
        {
            return new ReportRepo(db);
        }
        public static IRepo<BookedHotel, int, bool> GetBookedHotelDataAccess()
        {
            return new BookedHotelRepo(db);
        }
        public static IRepo<HotelReg, int, bool> GetHotelRegDataAccess()
        {
            return new HotelRegRepo(db);
        }

        public static IRepo<BookedVehicle, int, bool> GetBookedVehicleDataAccess()
        {
            return new BookedVehicleRepo(db);
        }

        public static IRepo<HotelBooking, int ,bool> GetHotelBookingDataAccess()
        {
            return new HotelBookingRepo(db);
        }
        public static IRepo<VehicleBooking, int, bool> GetVehicleBookingDataAccess()
        {
            return new VehicleBookingRepo(db);
        }




        public static IRepo<TicketBooking, int, bool> GetTicketBookingDataAccess()
        {
            return new VehicleTicketRepo(db);
        }
        public static IRepo<TransportReg, int, bool> GetTransportRegDataAccess()
        {
            return new TransportRegRepo(db);
        }

     
    


    }
}
