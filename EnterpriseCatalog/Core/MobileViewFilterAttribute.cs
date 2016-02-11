using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EnterpriseCatalog.Core
{
    public class MobileViewFilterAttribute : System.Web.Mvc.ActionFilterAttribute
    {
        public override void OnActionExecuted(ActionExecutedContext filterContext)
        {
            if (Convert.ToBoolean(filterContext.HttpContext.Request.Browser.IsMobileDevice))
            {
                var action = (string)filterContext.RouteData.Values["action"];
                var viewName = ((ViewResult)filterContext.Result).ViewName;
                if (string.IsNullOrEmpty(viewName)) viewName = action;

                var result = new ViewResult
                {
                    ViewName = (viewName + "Mobile"),
                    MasterName = ((ViewResult)filterContext.Result).MasterName,
                    ViewData = ((ViewResult)filterContext.Result).ViewData,
                    TempData = ((ViewResult)filterContext.Result).TempData
                };
                filterContext.Result = result;
                filterContext.HttpContext.Response.Clear();
            }
            base.OnActionExecuted(filterContext);
        }
    }
}