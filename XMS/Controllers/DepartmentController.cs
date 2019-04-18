using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Thunder.Infrastructure.Data;
using Thunder.XMS.Models;

namespace Thunder.XMS.Controllers
{
    public class DepartmentController : Controller
    {
        private XmsDbContext dbContext = new XmsDbContext();
        // GET: Department
        public ActionResult Index()
        {
            return View();
        }

        public JsonResult List()
        {
            List<DepartmentViewModel> departList = new List<DepartmentViewModel>();
            departList.Add(new DepartmentViewModel() { Id = 1, ParentId = 0, Name = "集散中心A", DepartType = "集散中心" });
            departList.Add(new DepartmentViewModel() { Id = 2, ParentId = 1, Name = "集散中心B", DepartType = "集散中心" });
            departList.Add(new DepartmentViewModel() { Id = 3, ParentId = 1, Name = "门店A", DepartType = "门店" });
            departList.Add(new DepartmentViewModel() { Id = 4, ParentId = 0, Name = "集散中心C", DepartType = "集散中心" });
            departList.Add(new DepartmentViewModel() { Id = 5, ParentId = 2, Name = "门店B", DepartType = "门店" });
            departList.Add(new DepartmentViewModel() { Id = 6, ParentId = 3, Name = "集散中心D", DepartType = "集散中心" });
            departList.Add(new DepartmentViewModel() { Id = 7, ParentId = 4, Name = "门店C", DepartType = "门店" });
            departList.Add(new DepartmentViewModel() { Id = 8, ParentId = 6, Name = "集散中心E", DepartType = "集散中心" });
            departList.Add(new DepartmentViewModel() { Id = 9, ParentId = 8, Name = "门店D", DepartType = "门店" });
            departList.Add(new DepartmentViewModel() { Id = 10, ParentId = 4, Name = "集散中心F", DepartType = "集散中心" });
            //var list = dbContext.Departments.ToList();
            return Json(new { total = departList.Count, rows = departList }, JsonRequestBehavior.AllowGet);
        }

        public ActionResult Credit()
        {
            return View();
        }

        public JsonResult CreditList()
        {
            List<DepartmentViewModel> departList = new List<DepartmentViewModel>();
            departList.Add(new DepartmentViewModel() { Id = 3, ParentId = 1, Name = "门店A", DepartType = "门店", Credit = 10000 });
            departList.Add(new DepartmentViewModel() { Id = 5, ParentId = 2, Name = "门店B", DepartType = "门店", Credit = 10000 });
            departList.Add(new DepartmentViewModel() { Id = 7, ParentId = 4, Name = "门店C", DepartType = "门店", Credit = 10000 });
            departList.Add(new DepartmentViewModel() { Id = 9, ParentId = 8, Name = "门店D", DepartType = "门店", Credit = 10000 });
            //var list = dbContext.Departments.ToList();
            return Json(new { total = departList.Count, rows = departList }, JsonRequestBehavior.AllowGet);
        }
    }
}