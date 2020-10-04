using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AmmiFurnitures.Web.Models;

namespace AmmiFurnitures.Web.Controllers
{
    public class RegisterController : Controller
    {
        // GET: Register
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Register(tblUser user)
        {
            if (ModelState.IsValid)
            {
                using (AmmiFurnitureDbEntities oDataContext = new AmmiFurnitureDbEntities())
                {
                    user.CreateDate = System.DateTime.Now;
                    user.CreatedBy = user.UserName;
                   
                    oDataContext.tblUsers.Add(user);
                    oDataContext.SaveChanges();

                    return RedirectToAction("Index");
                }
            }

            return View(user);

            
        }
    }
}