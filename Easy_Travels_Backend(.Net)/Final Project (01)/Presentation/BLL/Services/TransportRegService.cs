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
    public class TransportRegService

    {
        public static List<TransportRegModel> Get()
        {
            var config = new MapperConfiguration(c =>

                c.CreateMap<TransportReg, TransportRegModel>());

            var mapper = new Mapper(config);
            var data = mapper.Map<List<TransportRegModel>>(DataAccessFactory.GetTransportRegDataAccess().Get());
            return data;
        }
        public static void Create(TransportRegModel r)
        {
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<TransportRegModel, TransportReg>();
            });
            var mapper = new Mapper(config);
            var data = mapper.Map<TransportReg>(r);
            DataAccessFactory.GetTransportRegDataAccess().Create(data);
        }
        public static TransportRegModel GetOnly(int id)
        {
            var item = DataAccessFactory.GetTransportRegDataAccess().Get(id);
            var d = new TransportRegModel() { TranportId = item.Id, CompanyName = item.Name, EmailID = item.Email, Phone = item.Phone, Type = item.Type, Password = item.Password };
            return d;

        }
        public static void Update(TransportRegModel r)
        {
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<TransportRegModel, TransportReg>();
            });
            var mapper = new Mapper(config);
            var data = mapper.Map<TransportReg>(r);
            DataAccessFactory.GetTransportRegDataAccess().Update(data);
        }
        public static void Delete(int id)
        {
            DataAccessFactory.GetTransportRegDataAccess().Delete(id);
        }
    }

}
