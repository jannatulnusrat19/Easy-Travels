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
    public class VehicleTicketController : ApiController
    {
        [Route("api/TicketBooking/All")]
        [HttpGet]
        public List<VehicleTicketModel> GetAll()
        {
            return VehicleTicketService.Get();
        }
        [Route("api/TicketBooking/Create")]
        [HttpPost]
        public HttpResponseMessage Create(VehicleTicketModel r)
        {
            VehicleTicketService.Create(r);
            return Request.CreateResponse(HttpStatusCode.OK, "Created");
        }
        [Route("api/TicketBooking/{id}")]
        [HttpGet]
        public HttpResponseMessage Get(int id)
        {
            var data = VehicleTicketService.GetOnly(id);
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }
        [Route("api/TicketBooking/update")]
        [HttpPost]
        public HttpResponseMessage Update(VehicleTicketModel r)
        {
            VehicleTicketService.Update(r);
            return Request.CreateResponse(HttpStatusCode.OK, "Updated");

        }
        [Route("api/TicketBooking/delete/{id}")]
        [HttpDelete]
        public HttpResponseMessage Delete(int id)
        {
            VehicleTicketService.Delete(id);
            return Request.CreateResponse(HttpStatusCode.OK, "Deleted");
        }
    }
}
