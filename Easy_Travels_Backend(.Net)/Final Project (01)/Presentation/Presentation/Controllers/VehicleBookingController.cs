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
    public class VehicleBookingController : ApiController
    {
        [Route("api/VehicleBooking/All")]
        [HttpGet]
        public List<VehicleBookingModel> GetAll()
        {
            return VehicleBookingService.Get();
        }
        [Route("api/VehicleBooking/Create")]
        [HttpPost]
        public HttpResponseMessage Create(VehicleBookingModel r)
        {
            VehicleBookingService.Create(r);
            return Request.CreateResponse(HttpStatusCode.OK, "Created");
        }
        [Route("api/VehicleBooking/{id}")]
        [HttpGet]
        public HttpResponseMessage Get(int id)
        {
            var data = VehicleBookingService.GetOnly(id);
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }
        [Route("api/VehicleBooking/update")]
        [HttpPost]
        public HttpResponseMessage Update(VehicleBookingModel r)
        {
            VehicleBookingService.Update(r);
            return Request.CreateResponse(HttpStatusCode.OK, "Updated");

        }
        [Route("api/VehicleBooking/delete/{id}")]
        [HttpDelete]
        public HttpResponseMessage Delete(int id)
        {
            VehicleBookingService.Delete(id);
            return Request.CreateResponse(HttpStatusCode.OK, "Deleted");
        }
    }
}
