using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Thunder.Infrastructure.Data;

namespace Thunder.XMS.Controllers.PricePro
{
    public class IncidentalPriceController : Controller
    {
        private XmsDbContext dbContext = new XmsDbContext();
        // GET: IncidentalPrice
        public ActionResult Index()
        {
            return View();
        }

        public JsonResult List()
        {
            var list = dbContext.IncidentalPrices.ToList();
            return Json(new { total = list.Count, rows = list });
        }

        public ActionResult Add()
        {
            return View();
        }
    }
}