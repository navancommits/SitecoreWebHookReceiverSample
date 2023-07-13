using SitecoreReceiver.WebHooks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SitecoreReceiver.Controllers
{
    public class SitecoreTrackerController : Controller
    {
        // GET: SitecoreTracker
        public ActionResult List()
        {
            return View(SessionData.SitecoreList);
        }
    }
}