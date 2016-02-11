using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EnterpriseCatalog.Core;
using System.ServiceModel.Syndication;
using EnterpriseCatalog.Models;
using System.Collections;

namespace EnterpriseCatalog.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        EnterpriseContext db = new EnterpriseContext();

        [MobileViewFilter]
        [OutputCache(VaryByParam = "None", Duration = 60)]
        public ActionResult About()
        {
            return View();
        }

        public virtual ActionResult Feed(string id)
        {
            var items = new List<SyndicationItem>();
     
           for (int i = 0; i < 10; i++)
           {
                string feedTitle = "Test Title " + i;
     
                var helper = new UrlHelper(this.Request.RequestContext);
               var url = helper.Action("Index", "Home", new { }, Request.IsSecureConnection ? "https" : "http");
  
               var feedPackageItem = new SyndicationItem(feedTitle, "Test Description " + i, new Uri(url));
              feedPackageItem.PublishDate = DateTime.Now;
               items.Add(feedPackageItem);
          }
    
           return new RssResult("Demo Feed", items);
       }   
    }
}
