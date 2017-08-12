using MyMVC.CodeLayers.ServiceLayer;
using MyMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyMVC.Areas.User.Controllers
{
    //[RouteArea("User")]
    public class UserController : Controller
    {
        // GET: User/User
        public ActionResult Index()
        {
            UserSL a = new UserSL();
            List<UserContext> b = a.GetAll();
                        
            return View(b);
        }
    }
}