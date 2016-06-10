﻿using System.Collections.Generic;
using System.Web.Http;
using SkateOne.Application.Model;
using SkateOne.Application.Service;
using SkateOne.Web.Extensions;
using SkateOne.Web.Models;

namespace SkateOne.Web.Controllers.Api
{
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