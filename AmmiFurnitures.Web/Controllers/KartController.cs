using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AmmiFurnitures.Web.Controllers
{
    public class KartController : Controller
    {
        // GET: Kart
        [Authorize]
        public ActionResult Index()
        {
            return View();
        }
    }
}