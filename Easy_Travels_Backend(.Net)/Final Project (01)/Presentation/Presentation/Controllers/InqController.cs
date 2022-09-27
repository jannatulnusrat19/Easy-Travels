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
    public class InqController : ApiController
    {
        [Route("api/Inq/All")]
        [HttpGet]
        public List<InqModel> GetAll()
        {
            return InqService.Get();
        }
        [Route("api/Inq/Create")]
        [HttpPost]
        public HttpResponseMessage Create(InqModel r)
        {
            InqService.Create(r);
            return Request.CreateResponse(HttpStatusCode.OK, "Created");
        }
        [Route("api/Inq/{id}")]
        [HttpGet]
        public HttpResponseMessage Get(int id)
        {
            var data = InqService.GetOnly(id);
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }
        [Route("api/Inq/update")]
        [HttpPost]
        public HttpResponseMessage Update(InqModel r)
        {
            InqService.Update(r);
            return Request.CreateResponse(HttpStatusCode.OK, "Updated");

        }
        [Route("api/Inq/delete/{id}")]
        [HttpDelete]
        public HttpResponseMessage Delete(int id)
        {
            InqService.Delete(id);
            return Request.CreateResponse(HttpStatusCode.OK, "Deleted");
        }
    }
}
