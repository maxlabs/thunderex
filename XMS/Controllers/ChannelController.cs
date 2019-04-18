using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Thunder.Infrastructure.Data;

namespace Thunder.XMS.Controllers
{
    public class ChannelController : Controller
    {
        private XmsDbContext dbContext = new XmsDbContext();
        // GET: Channel
        public ActionResult Index()
        {
            return View();
        }

        public JsonResult List()
        {
            var list = dbContext.Channels.ToList();
            return Json(new { total = list.Count, rows = list });
        }

        public ActionResult PayAndCollect()
        {
            return View();
        }
    }
}