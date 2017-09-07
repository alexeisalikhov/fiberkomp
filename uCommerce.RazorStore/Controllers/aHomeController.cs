using System.Web.Mvc;
using Umbraco.Web.Models;
using Umbraco.Web.Mvc;

//HomeController duplicate to test Umbraco

namespace UCommerce.RazorStore.Controllers
{
    public class aHomeController : RenderMvcController
    {
        [HttpGet]
        public ActionResult Index()
        {
            return View("/views/frontpage.cshtml");
        }


    }
}