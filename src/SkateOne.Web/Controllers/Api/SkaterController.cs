using System.Collections.Generic;
using System.Web.Http;
using System.Web.Http.Cors;
using SkateOne.Domain;
using SkateOne.Service;
using SkateOne.Web.Extensions;
using SkateOne.Web.Models;

namespace SkateOne.Web.Controllers.Api
{
    [EnableCors(origins: "http://localhost:8080", headers: "*", methods: "*")]
    public class SkaterController : ApiController
    {
        private readonly ISkaterService service;

        public SkaterController(ISkaterService service)
        {
            this.service = service;
        }

        [HttpGet]
        public IHttpActionResult GetAll()
        {
            var result = new Result<IEnumerable<Skater>>(service.GetAll());

            return result.CreateResponse(this);
        }
    }
}