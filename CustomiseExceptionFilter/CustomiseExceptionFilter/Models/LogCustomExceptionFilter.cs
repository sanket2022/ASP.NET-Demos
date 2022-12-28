﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CustomiseExceptionFilter.Models
{
    public class LogCustomExceptionFilter : FilterAttribute, IExceptionFilter
    {
        public void OnException(ExceptionContext filterContext)
        {
            if(!filterContext.ExceptionHandled)
            {
                var exceptionMessage = filterContext.Exception.Message;
                var stackTrace = filterContext.Exception.StackTrace;
                var controllerName = filterContext.RouteData.Values["controller"].ToString();
                var actionName = filterContext.RouteData.Values["action"].ToString();
                string Message = "Date :" + DateTime.Now.ToString()
                    + ", Controller: " + controllerName
                    + ", Action: " + actionName
                    + ",Erroe Message: " + exceptionMessage
                    + Environment.NewLine 
                    +"Stack Trace: " + stackTrace;

                File.AppendAllText(HttpContext.Current.Server.MapPath("~Log/Log.txt"), Message);
                filterContext.ExceptionHandled = true;
                filterContext.Result = new ViewResult()
                {
                    ViewName = "Error"
                };
            }
        }
    }
}