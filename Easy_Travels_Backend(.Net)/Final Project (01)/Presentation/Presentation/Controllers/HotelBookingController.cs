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
    public class HotelBookingController : ApiController
    {
        [Route("api/HotelBooking/All")]
        [HttpGet]
        public List<HotelBookingModel> GetAll()
        {
            return HotelBookingService.Get();
        }
        [Route("api/HotelBooking/Create")]
        [HttpPost]
        public HttpResponseMessage Create(HotelBookingModel r)
        {
            HotelBookingService.Create(r);
            return Request.CreateResponse(HttpStatusCode.OK, "Created");
        }
        [Route("api/HotelBooking/{id}")]
        [HttpGet]
        public HttpResponseMessage Get(int id)
        {
            var data = HotelBookingService.GetOnly(id);
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }
        [Route("api/HotelBooking/update")]
        [HttpPost]
        public HttpResponseMessage Update(HotelBookingModel r)
        {
            HotelBookingService.Update(r);
            return Request.CreateResponse(HttpStatusCode.OK, "Updated");

        }
        [Route("api/HotelBooking/delete/{id}")]
        [HttpDelete]
        public HttpResponseMessage Delete(int id)
        {
            HotelBookingService.Delete(id);
            return Request.CreateResponse(HttpStatusCode.OK, "Deleted");
        }
    }
}
