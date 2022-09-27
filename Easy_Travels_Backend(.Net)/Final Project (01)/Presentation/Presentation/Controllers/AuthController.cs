using BLL.BEnt;
using BLL.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Presentation.Controllers
{
    public class AuthController : ApiController
    {
        

        [Route("api/login")]
        [HttpPost]
        public HttpResponseMessage Login(AdminListModel obj)
        {
            var data = AuthService.Authenticate(obj.Email, obj.Paaword);
            if (data != null)
            {
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            return Request.CreateResponse(HttpStatusCode.NotFound);
        }
        /*[Route("api/logout")]
        [HttpGet]
        public HttpResponseMessage Logout(TokenModel obj)
        {
            var data = AuthService.Logout(obj);
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }*/

        [Route("api/logout")]
        [HttpGet]
        public HttpResponseMessage Logout()
        {
            var token = Request.Headers.Authorization.ToString();
            if (token != null)
            {
                var rs = AuthService.Logout(token);
                if (rs)
                {
                    return Request.CreateResponse(HttpStatusCode.OK, "Successfully loged out");
                }
            }
            return Request.CreateResponse(HttpStatusCode.BadRequest, "Invalid token to logout");
        }
    }
}
