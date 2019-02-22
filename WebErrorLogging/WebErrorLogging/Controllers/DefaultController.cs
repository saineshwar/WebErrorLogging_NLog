using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using NLog;


namespace WebErrorLogging.Controllers
{
    public class DefaultController : Controller
    {
        public readonly Logger Logger = NLog.LogManager.GetCurrentClassLogger();
        // GET: Default
        public ActionResult Index()
        {
            try
            {
                Logger.Debug("Hi I am NLog Debug Level");
                Logger.Info("Hi I am NLog Info Level");
                Logger.Warn("Hi I am NLog Warn Level");
                throw new NullReferenceException();
                return View();
            }
            catch (Exception ex)
            {
                Logger.Error(ex, "Hi I am NLog Error Level");
                Logger.Fatal(ex, "Hi I am NLog Fatal Level");
                throw;
            }
        }
    }
}