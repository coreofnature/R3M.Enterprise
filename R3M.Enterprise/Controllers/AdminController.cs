using R3M.Enterprise.Models;
using R3M.Enterprise.Models.DataContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace R3M.Enterprise.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin

        R3M_Enterprise_DBContext db = new R3M_Enterprise_DBContext();
        public ActionResult Index()
        {
            var test = db.BlogCategory.ToList();
            return View(test);
        }
    }
}