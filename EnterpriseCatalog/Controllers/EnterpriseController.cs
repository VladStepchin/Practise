using EnterpriseCatalog.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EnterpriseCatalog.Controllers
{
    public class EnterpriseController : Controller
    {
        //
        // GET: /Home/

        EnterpriseContext db = new EnterpriseContext();

        
        public ActionResult List()
        {                
            return View(db.Enterprises.ToList());
        }
            
        [HttpGet]
        public ActionResult Edit(int? id)
        {
            if (id == null)
                return HttpNotFound();

            Enterprises enterprise = db.Enterprises.Find(id);

            if (enterprise == null)
                return HttpNotFound();

            return View(enterprise);
        }

        [HttpPost]
        public ActionResult Edit(Enterprises enterprise)
        {
            if (Request.IsAjaxRequest())
            {
                db.Entry(enterprise).State = EntityState.Modified;
                db.SaveChanges();
                return Content("<b>Дані збережені о <b>" + DateTime.Now.ToLongTimeString());
            }
            return RedirectToAction("List");
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Enterprises enterprise)
        {           
            db.Enterprises.Add(enterprise); 
            db.SaveChanges();    
            return RedirectToAction("List");
        }

        [HttpGet]
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }

            Enterprises b = db.Enterprises.Find(id);

            if (b == null)
            {
                return HttpNotFound();
            }
            return View(b);
        }

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }
            Enterprises b = db.Enterprises.Find(id);
            if (b == null)
            {
                return HttpNotFound();
            }
            db.Enterprises.Remove(b);
            db.SaveChanges();
            return RedirectToAction("List");
        }

        public ActionResult Myzlo() 
        {
            return View();
        }
    } 
}
