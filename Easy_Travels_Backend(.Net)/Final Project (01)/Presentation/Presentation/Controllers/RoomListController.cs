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
    public class RoomListController : ApiController
    {
        [Route("api/RoomList/All")]
        [HttpGet]
        public List<RoomListModel> GetAll()
        {
            return RoomListService.Get();
        }
        [Route("api/RoomList/Create")]
        [HttpPost]
        public HttpResponseMessage Create(RoomListModel r)
        {
            RoomListService.Create(r);
            return Request.CreateResponse(HttpStatusCode.OK, "Created");
        }
        [Route("api/RoomList/{id}")]
        [HttpGet]
        public HttpResponseMessage Get(int id)
        {
            var data = RoomListService.GetOnly(id);
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }
        [Route("api/RoomList/update")]
        [HttpPost]
        public HttpResponseMessage Update(RoomListModel r)
        {
            RoomListService.Update(r);
            return Request.CreateResponse(HttpStatusCode.OK, "Updated");

        }
        [Route("api/RoomList/delete/{id}")]
        [HttpDelete]
        public HttpResponseMessage Delete(int id)
        {
            RoomListService.Delete(id);
            return Request.CreateResponse(HttpStatusCode.OK, "Deleted");
        }
    }
}
