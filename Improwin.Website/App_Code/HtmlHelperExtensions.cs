using System;
using System.Collections.Generic;
using System.Web;
using System.Web.Mvc;

namespace System.Web.Mvc.Html
    
{
    public static class HtmlHelperExtensions
    {
        public static string ActivePage(this HtmlHelper helper, string controller, string action,string Class,Int64 IsController)
        {
            string classValue = "";

            string currentController = helper.ViewContext.Controller.ValueProvider.GetValue("controller").RawValue.ToString();
            string currentAction = helper.ViewContext.Controller.ValueProvider.GetValue("action").RawValue.ToString();
            if (currentController == controller && currentAction == action && IsController == 1)
            {
                classValue = Class;
            }

            return classValue;
        }
    }
}