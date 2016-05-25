using System.Web.Mvc;
using SkateOne.Application.Service;

namespace SkateOne.Web.Controllers
{
    public class SkateController : Controller
    {
        private readonly ISkateService service;

        public SkateController(ISkateService service)
        {
            this.service = service;
        }

        public ActionResult Index()
        {
            var list = service.GetAll();

            return View();
        }
    }
}
