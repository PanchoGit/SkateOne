using System.Collections.Generic;
using System.Web.Http;
using System.Web.Http.Cors;
using Common.Logger;
using Common.Logger.Interface;
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
        //private readonly ILoggerWrapper logger;

        public SkaterController(ISkaterService service)
        {
            this.service = service;
            //logger = new LoggerWrapper(typeof(SkaterController));
        }

        [HttpGet]
        public IHttpActionResult GetAll()
        {
            //logger.LogInfo("Init");
            var result = new Result<IEnumerable<Skater>>(service.GetAll());

            return result.CreateResponse(this);
        }
    }
}