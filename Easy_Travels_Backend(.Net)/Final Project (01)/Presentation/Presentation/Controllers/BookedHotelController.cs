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
    public class BookedHotelController : ApiController
    {
        [Route("api/BookedHotel/All")]
        [HttpGet]
        public List<BookedHotelModel> GetAll()
        {
            return BookedHotelService.Get();
        }
        [Route("api/BookedHotel/Create")]
        [HttpPost]
        public HttpResponseMessage Create(BookedHotelModel r)
        {
            BookedHotelService.Create(r);
            return Request.CreateResponse(HttpStatusCode.OK, "Created");
        }
        [Route("api/BookedHotel/{id}")]
        [HttpGet]
        public HttpResponseMessage Get(int id)
        {
            var data = BookedHotelService.GetOnly(id);
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }
    }
}
