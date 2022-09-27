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
    public class TransportRegController : ApiController
    {
        [ValidUser]
        [Route("api/TransportReg/All")]
        [HttpGet]
        public List<TransportRegModel> GetAll()
        {
            return TransportRegService.Get();
        }
        [Route("api/TransportReg/Create")]
        [HttpPost]
        public HttpResponseMessage Create(TransportRegModel r)
        {
            TransportRegService.Create(r);
            return Request.CreateResponse(HttpStatusCode.OK, "Created");
        }
        [Route("api/TransportReg/{id}")]
        [HttpGet]
        public HttpResponseMessage Get(int id)
        {
            var data = TransportRegService.GetOnly(id);
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }
        [Route("api/TransportReg/update")]
        [HttpPost]
        public HttpResponseMessage Update(TransportRegModel r)
        {
            TransportRegService.Update(r);
            return Request.CreateResponse(HttpStatusCode.OK, "Updated");

        }
        [Route("api/TransportReg/delete/{id}")]
        [HttpDelete]
        public HttpResponseMessage Delete(int id)
        {
            TransportRegService.Delete(id);
            return Request.CreateResponse(HttpStatusCode.OK, "Deleted");
        }
    }
}
