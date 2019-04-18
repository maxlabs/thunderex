using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Thunder.XMS.Models;

namespace Thunder.XMS.Controllers
{
    public class DistributionCenterController : Controller
    {
        // GET: DistributionCenter
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult BagState()
        {
            return View();
        }

        public JsonResult BagList()
        {
            List<BagViewModel> list = new List<BagViewModel>();
            list.Add(new BagViewModel() { Id = 1, State = "已发往国内" });
            list.Add(new BagViewModel() { Id = 2, State = "中转中" });
            list.Add(new BagViewModel() { Id = 3, State = "已发往国内" });
            list.Add(new BagViewModel() { Id = 4, State = "中转中" });
            list.Add(new BagViewModel() { Id = 5, State = "中转中" });
            list.Add(new BagViewModel() { Id = 6, State = "已发往国内" });
            list.Add(new BagViewModel() { Id = 7, State = "集散中心" });
            list.Add(new BagViewModel() { Id = 8, State = "已发往国内" });
            //var list = dbContext.Stores.ToList();
            return Json(new { total = list.Count, rows = list });
        }
    }
}