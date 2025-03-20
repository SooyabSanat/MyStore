using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MyStore.Areas.Admin.Controllers
{
    public class HomeController : Controller
    {
        // GET: HomeController
        public ActionResult Index()
        {
            return View();
        }
    }
}
