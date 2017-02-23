using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebScadaPlatform.Domain;

namespace WebScadaPlatform.Controllers
{
    public class RealTimeController : Controller
    {
        //
        // GET: /RealTime/
        public ActionResult Display()
        {
            return View("Display");
        }

        /// <summary>
        /// 墒情
        /// </summary>
        /// <returns></returns>
        public ActionResult SoilMoisture()
        {
            var data = new Data();
            return PartialView("SoilMoisture", data.tagGroups().ToList());
        }
	}
}