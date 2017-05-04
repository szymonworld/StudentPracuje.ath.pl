using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Pracuj.ath.bielsko.pl.Helpers
{
    public static class EditorExtensions
    {
        public static MvcHtmlString TextEditor(this HtmlHelper helper, string target)
        {
            return MvcHtmlString.Create("<script> $(function() { $('#" + target + "').ckeditor(); }); </script> <textarea id='" + target + "' style='padding-top:50px;'></textarea>");
        }
    }
}