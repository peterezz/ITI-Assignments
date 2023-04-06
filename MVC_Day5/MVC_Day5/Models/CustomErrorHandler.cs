using System;
using System.Web.Mvc;

namespace MVC_Day5.Models
{
    public class CustomErrorHandler : HandleErrorAttribute
    {
        public override void OnException( ExceptionContext filterContext )
        {
            Exception ex = filterContext.Exception;
            filterContext.ExceptionHandled = true;
            filterContext.Result = new ViewResult( )
            {
                ViewName = "CustomHandelError"
            };

            base.OnException( filterContext );
        }
    }
}