using Microsoft.AspNetCore.Mvc;
using FinTrakERP.Web.Controllers;

namespace FinTrakERP.Web.Public.Controllers
{
    public class AboutController : FinTrakERPControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}