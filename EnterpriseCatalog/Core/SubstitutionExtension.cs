using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EnterpriseCatalog.Core
{
    public static class SubstittutionExtension
    {
        public delegate string SubstitutionCalback(HttpContextBase coontext);

        public static object Substitution(this HtmlHelper html, SubstitutionCalback cbSubstitution)
        {
            html.ViewContext.HttpContext.Response.WriteSubstitution(
            c => HttpUtility.HtmlEncode(
            cbSubstitution(new HttpContextWrapper(c))
            ));
            return null;
        }
    }
}