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
    public class ReportService
    {
        public static List<ReportModel> Get()
        {
            var config = new MapperConfiguration(c =>

                c.CreateMap<Report, ReportModel>());

            var mapper = new Mapper(config);
            var data = mapper.Map<List<ReportModel>>(DataAccessFactory.GetReportDataAccess().Get());
            return data;
        }
        public static void Create(ReportModel r)
        {
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<ReportModel, Report>();
            });
            var mapper = new Mapper(config);
            var data = mapper.Map<Report>(r);
            DataAccessFactory.GetReportDataAccess().Create(data);
        }
        public static ReportModel GetOnly(int id)
        {
            var item = DataAccessFactory.GetReportDataAccess().Get(id);
            var d = new ReportModel() { Id = item.Id, Name = item.Name, Topic = item.Topic, Details = item.Details };
            return d;

        }
    }

}
