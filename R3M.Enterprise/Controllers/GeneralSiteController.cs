using R3M.Enterprise.Models.DataContext;
using R3M.Enterprise.Models.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Helpers;
using System.Web.Mvc;

namespace R3M.Enterprise.Controllers
{
    public class GeneralSiteController : Controller
    {
        R3M_Enterprise_DBContext db = new R3M_Enterprise_DBContext();
        // GET: GeneralSite
        public ActionResult Index()
        {
            return View(db.GeneralSite.ToList());
        }

        // GET: GeneralSite/Edit/5
        public ActionResult Edit(int id)
        {
            var generalSite = db.GeneralSite.Where(x => x.Id == id).SingleOrDefault();
            return View(generalSite);
        }

        // POST: GeneralSite/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, GeneralSite generalSite, HttpPostedFileBase logoUrl)
        {
            if (ModelState.IsValid)
            {
                var _generalSite = db.GeneralSite.Where(x => x.Id == id).SingleOrDefault();

                if(logoUrl != null)
                {
                    if (System.IO.File.Exists(Server.MapPath(generalSite.LogoUrl)))
                    {
                        System.IO.File.Delete(Server.MapPath(generalSite.LogoUrl));
                    }
                    WebImage img = new WebImage(logoUrl.InputStream);
                    FileInfo imgInfo = new FileInfo(logoUrl.FileName);

                    string logoName = imgInfo.FullName + imgInfo.Extension;
                    img.Resize(200,126); //değiştirilebilir. Gelen değer alınabilir.
                    img.Save("~/Uploads/GeneralSite/" + logoName);

                    generalSite.LogoUrl = "~Uploads/GeneralSite/" + logoName;
                }

                //Model set
                _generalSite.Title = generalSite.Title;
                _generalSite.Keywords = generalSite.Keywords;
                _generalSite.Description = generalSite.Description;
                _generalSite.Superscription = generalSite.Superscription;
                _generalSite.LogoUrl = generalSite.LogoUrl;

                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(generalSite);
        }
    }
}
