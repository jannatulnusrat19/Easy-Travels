using BLL;
using BLL.BEnt;
using Presentation.Auth;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;



namespace Presentation.Controllers
{
    public class AdminController : ApiController
    {
        /*[Route("api/Adminlist/Names")]
        [HttpGet]
        public List<string> GetNames()
        {
           return EasyTravelService.GetNames();
        }*/

        [ValidUser]
        [Route("api/Adminlist/All")]
        [HttpGet]
        public List<AdminListModel> GetAll()
        {
            return EasyTravelService.Get();
        }
        [ValidUser]
        [Route("api/Adminlist/Create")]
        [HttpPost]
        public void Create(AdminListModel s)
        {
            EasyTravelService.Create(s);
        }
        [ValidUser]
        [Route("api/Adminlist/update")]
        [HttpPost]
        public HttpResponseMessage Update(AdminListModel s)
        {
            EasyTravelService.Update(s);
            return Request.CreateResponse(HttpStatusCode.OK, "Updated");

        }
        [ValidUser]
        [Route("api/AdminList/delete/{id}")]
        [HttpDelete]
        public HttpResponseMessage Delete(int id)
        {
            EasyTravelService.Delete(id);
            return Request.CreateResponse(HttpStatusCode.OK, "Deleted");
        }
    
}
}
