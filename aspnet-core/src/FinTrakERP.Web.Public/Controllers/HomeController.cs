using Microsoft.AspNetCore.Mvc;
using FinTrakERP.Web.Controllers;

namespace FinTrakERP.Web.Public.Controllers
{
    public class HomeController : FinTrakERPControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}