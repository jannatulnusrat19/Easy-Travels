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
    public class RoomListService
    {
        public static List<RoomListModel> Get()
        {
            var config = new MapperConfiguration(c =>

                c.CreateMap<RoomList, RoomListModel>());

            var mapper = new Mapper(config);
            var data = mapper.Map<List<RoomListModel>>(DataAccessFactory.GetRoomListDataAccess().Get());
            return data;
        }
        public static void Create(RoomListModel r)
        {
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<RoomListModel, RoomList>();
            });
            var mapper = new Mapper(config);
            var data = mapper.Map<RoomList>(r);
            DataAccessFactory.GetRoomListDataAccess().Create(data);
        }
        public static RoomListModel GetOnly(int id)
        {
            var item = DataAccessFactory.GetRoomListDataAccess().Get(id);
            var d = new RoomListModel() { Id = item.Id, Name = item.Name, Place = item.Place, Type = item.Type, Price = item.Price, Offer = item.Offer, ExtraInfo = item.ExtraInfo };
            return d;

        }
        public static void Update(RoomListModel r)
        {
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<RoomListModel, RoomList>();
            });
            var mapper = new Mapper(config);
            var data = mapper.Map<RoomList>(r);
            DataAccessFactory.GetRoomListDataAccess().Update(data);
        }
        public static void Delete(int id)
        {
            DataAccessFactory.GetRoomListDataAccess().Delete(id);
        }
    }

}
