using EnterpriseCatalog.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EnterpriseCatalog.Controllers
{
    public class WorkforceController : Controller
    {
        //
        // GET: /Workforce/

        EnterpriseContext db = new EnterpriseContext();

        [HttpGet]
        public ActionResult List(int? id)
        {

            if (id == null)
            {
                return HttpNotFound();
            }

            Enterprises ent = db.Enterprises.Find(id);

            if (ent == null)
            {
                return HttpNotFound();
            }

            ent.Workforces = db.Workforces.Where(m=>m.EnterprisesId == ent.Id);

            return View(ent);
        }

    }
}
