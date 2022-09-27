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
    public class BookedVehicleController : ApiController
    {
        [Route("api/BookedVehicle/All")]
        [HttpGet]
        public List<BookedVehicleModel> GetAll()
        {
            return BookedVehicleService.Get();
        }
        [Route("api/BookedVehicle/Create")]
        [HttpPost]
        public HttpResponseMessage Create(BookedVehicleModel r)
        {
            BookedVehicleService.Create(r);
            return Request.CreateResponse(HttpStatusCode.OK, "Created");
        }
        [Route("api/BookedVehicle/{id}")]
        [HttpGet]
        public HttpResponseMessage Get(int id)
        {
            var data = BookedVehicleService.GetOnly(id);
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }
        [Route("api/BookedVehicle/update")]
        [HttpPost]
        public HttpResponseMessage Update(BookedVehicleModel r)
        {
            BookedVehicleService.Update(r);
            return Request.CreateResponse(HttpStatusCode.OK, "Updated");

        }
        [Route("api/BookedVehicle/delete/{id}")]
        [HttpDelete]
        public HttpResponseMessage Delete(int id)
        {
            BookedVehicleService.Delete(id);
            return Request.CreateResponse(HttpStatusCode.OK, "Deleted");
        }
    }
}
