using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Thunder.Infrastructure.Data;

namespace Thunder.XMS.Controllers.PricePro
{
    public class CurrencyRateController : Controller
    {
        private XmsDbContext dbContext = new XmsDbContext();
        // GET: CurrencyRate
        public ActionResult Index()
        {
            return View();
        }

        //[HttpGet]
        public JsonResult List()
        {
            var list = dbContext.CurrencyRates.ToList();
            return Json(new { total = list.Count, rows = list });
        }
    }
}