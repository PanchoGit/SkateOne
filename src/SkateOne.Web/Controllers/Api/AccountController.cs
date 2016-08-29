using System.Web.Http;
using SkateOne.Web.Extensions;
using SkateOne.Web.Models;

namespace SkateOne.Web.Controllers.Api
{
    public class AccountController : ApiController
    {
        [HttpPost]
        public IHttpActionResult Login()
        {
            var result = new Result();
            return result.CreateResponse(this);
        }
    }
}