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
    public class AccountantService
    {
        public static List<AccountantModel> Get()
        {
            var config = new MapperConfiguration(c =>

                c.CreateMap<Accountant, AccountantModel>());

            var mapper = new Mapper(config);
            var data = mapper.Map<List<AccountantModel>>(DataAccessFactory.GetAccountantDataAccess().Get());
            return data;
        }
        public static void Create(AccountantModel s)
        {
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<AccountantModel, Accountant>();
            });
            var mapper = new Mapper(config);
            var data = mapper.Map<Accountant>(s);
            DataAccessFactory.GetAccountantDataAccess().Create(data);
        }
        public static AccountantModel GetOnly(int id)
        {
            var item = DataAccessFactory.GetAccountantDataAccess().Get(id);
            var d = new AccountantModel() { ID = item.ID, Name = item.Name, Address = item.Address, Email_ID = item.Email_ID, Date_of_Birth = item.Date_of_Birth, Username = item.Username, Password = item.Password };
            return d;

        }
        public static void Update(AccountantModel s)
        {
            var config = new MapperConfiguration(c =>
            {
                c.CreateMap<AccountantModel, Accountant>();
            });
            var mapper = new Mapper(config);
            var data = mapper.Map<Accountant>(s);
            DataAccessFactory.GetAccountantDataAccess().Update(data);
        }
        public static void Delete(int id)
        {
            DataAccessFactory.GetAccountantDataAccess().Delete(id);
        }

    }
}
