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
    public class InqService
    {
        public static List<InqModel> Get()
        {
            var config = new MapperConfiguration(c =>

                c.CreateMap<Inq, InqModel>());

            var mapper = new Mapper(config);
            var data = mapper.Map<List<InqModel>>(DataAccessFactory.GetInqDataAccess().Get());
            return data;
        }
        public static void Create(InqModel r)
        {
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<InqModel, Inq>();
            });
            var mapper = new Mapper(config);
            var data = mapper.Map<Inq>(r);
            DataAccessFactory.GetInqDataAccess().Create(data);
        }
        public static InqModel GetOnly(int id)
        {
            var item = DataAccessFactory.GetInqDataAccess().Get(id);
            var d = new InqModel() { Id = item.Id, Name = item.Name, Question = item.Question, Answer = item.Answer };
            return d;

        }
        public static void Update(InqModel r)
        {
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<InqModel, Inq>();
            });
            var mapper = new Mapper(config);
            var data = mapper.Map<Inq>(r);
            DataAccessFactory.GetInqDataAccess().Update(data);
        }
        public static void Delete(int id)
        {
            DataAccessFactory.GetInqDataAccess().Delete(id);
        }
    }

}
