using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AmmiFurnitures.Web.Models;
using AmmiFurnitures.Web.ViewModels;

namespace AmmiFurnitures.Web.Areas.Admin.Controllers
{
    public class PageController : Controller
    {
        // GET: Admin/Page

         public ActionResult Index()
        {

            GetPages();
            return View();
        }
        public IEnumerable<PageVM> GetPages()
        {
            List<PageVM> listPages = new List<ViewModels.PageVM>();
            AmmiFurnitureDbEntities o = new AmmiFurnitureDbEntities();
            
                
            return listPages;
        }
    }
}