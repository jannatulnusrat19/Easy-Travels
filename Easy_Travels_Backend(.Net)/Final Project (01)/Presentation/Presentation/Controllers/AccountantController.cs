using BLL;
using BLL.BEnt;
using BLL.Services;
using Presentation.Auth;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;


namespace Presentation.Controllers
{
    public class AccountantController : ApiController
    {
        [ValidUser]
        [Route("api/Accountant/All")]
        [HttpGet]
        public List<AccountantModel> GetAll()
        {
            return AccountantService.Get();
        }
        [ValidUser]
        [Route("api/Accountant/Create")]
        [HttpPost]
        public void Create(AccountantModel s)
        {
            AccountantService.Create(s);
        }
        [ValidUser]
        [Route("api/Accountant/update")]
        [HttpPost]
        public HttpResponseMessage Update(AccountantModel s)
        {
            AccountantService.Update(s);
            return Request.CreateResponse(HttpStatusCode.OK, "Updated");

        }
        [ValidUser]
        [Route("api/Accountant/delete/{id}")]
        [HttpDelete]
        public HttpResponseMessage Delete(int id)
        {
            AccountantService.Delete(id);
            return Request.CreateResponse(HttpStatusCode.OK, "Deleted");
        }
    }
}
