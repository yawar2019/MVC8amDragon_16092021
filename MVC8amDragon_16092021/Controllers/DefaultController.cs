using MVC8amDragon_16092021.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC8amDragon_16092021.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        public ActionResult Index()
        {
            DbSuperstarEntities db = new Models.DbSuperstarEntities();
            ViewBag.CountryName = new SelectList(db.Countries.ToList(), "CountryId", "CountryName");
            return View(db.CustomControls.ToList());
        }

        [HttpPost]
        public ActionResult Index(RegisterForm frm)
        {
            

            return View();
        }
     
        public ActionResult create()
        {


            return View();
        }

    }
}