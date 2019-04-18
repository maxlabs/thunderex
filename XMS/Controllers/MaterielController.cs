using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Thunder.XMS.Models;

namespace Thunder.XMS.Controllers
{
    public class MaterielController : Controller
    {
        // GET: Materiel
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Auth()
        {
            return View();
        }

        public JsonResult AuthList()
        {
            List<MaterielViewModel> list = new List<MaterielViewModel>();
            list.Add(new MaterielViewModel() { Id = 1, Store = "门店A", Name = "胶带", Unit = "个", Count = 1 });
            list.Add(new MaterielViewModel() { Id = 2, Store = "门店B", Name = "胶带", Unit = "个", Count = 1 });
            list.Add(new MaterielViewModel() { Id = 3, Store = "门店C", Name = "胶带", Unit = "个", Count = 4 });
            list.Add(new MaterielViewModel() { Id = 4, Store = "门店A", Name = "胶带", Unit = "个", Count = 1 });
            list.Add(new MaterielViewModel() { Id = 5, Store = "门店C", Name = "胶带", Unit = "个", Count = 3 });
            list.Add(new MaterielViewModel() { Id = 6, Store = "门店A", Name = "胶带", Unit = "个", Count = 1 });
            list.Add(new MaterielViewModel() { Id = 7, Store = "门店D", Name = "胶带", Unit = "个", Count = 1 });
            list.Add(new MaterielViewModel() { Id = 8, Store = "门店B", Name = "胶带", Unit = "个", Count = 1 });
            //var list = dbContext.Stores.ToList();
            return Json(new { total = list.Count, rows = list });
        }
    }
}