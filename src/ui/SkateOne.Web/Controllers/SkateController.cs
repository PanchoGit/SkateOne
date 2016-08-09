using System.Web.Mvc;
using SkateOne.Service;

namespace SkateOne.Web.Controllers
{
    public class SkateController : Controller
    {
        private readonly ISkaterService service;

        public SkateController(ISkaterService service)
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
