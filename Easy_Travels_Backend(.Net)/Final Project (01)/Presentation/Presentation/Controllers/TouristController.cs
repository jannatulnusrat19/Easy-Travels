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
    public class TouristController : ApiController
    {
        [ValidUser]
        [Route("api/CusLogin/All")]
        [HttpGet]
        public List<TouristModel> GetAll()
        {
            return TouristService.Get();
        }
        [ValidUser]
        [Route("api/CusLogin/Create")]
        [HttpPost]
        public void Create(TouristModel s)
        {
            TouristService.Create(s);
        }
        [ValidUser]
        [Route("api/CusLogin/update")]
        [HttpPost]
        public HttpResponseMessage Update(TouristModel s)
        {
            TouristService.Update(s);
            return Request.CreateResponse(HttpStatusCode.OK, "Updated");

        }
        [ValidUser]
        [Route("api/CusLogin/delete/{id}")]
        [HttpDelete]
        public HttpResponseMessage Delete(int id)
        {
            TouristService.Delete(id);
            return Request.CreateResponse(HttpStatusCode.OK, "Deleted");
        }
    }
}
