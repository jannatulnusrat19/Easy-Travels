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
    public class HotelRegController : ApiController
    {
        [ValidUser]
        [Route("api/HotelReg/All")]
        [HttpGet]
        public List<HotelRegModel> GetAll()
        {
            return HotelRegService.Get();
        }
        [Route("api/HotelReg/Create")]
        [HttpPost]
        public HttpResponseMessage Create(HotelRegModel r)
        {
            HotelRegService.Create(r);
            return Request.CreateResponse(HttpStatusCode.OK, "Created");
        }
        [Route("api/HotelReg/{id}")]
        [HttpGet]
        public HttpResponseMessage Get(int id)
        {
            var data = HotelRegService.GetOnly(id);
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }
        [Route("api/HotelReg/update")]
        [HttpPost]
        public HttpResponseMessage Update(HotelRegModel r)
        {
            HotelRegService.Update(r);
            return Request.CreateResponse(HttpStatusCode.OK, "Updated");

        }
        [Route("api/HotelReg/delete/{id}")]
        [HttpDelete]
        public HttpResponseMessage Delete(int id)
        {
            HotelRegService.Delete(id);
            return Request.CreateResponse(HttpStatusCode.OK, "Deleted");
        }
    }
}
