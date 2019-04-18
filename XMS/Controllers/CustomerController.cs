using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Thunder.Infrastructure.Data;
using Thunder.XMS.Models;

namespace Thunder.XMS.Controllers
{
    public class CustomerController : Controller
    {
        private XmsDbContext dbContext = new XmsDbContext();
        // GET: CustomerManament
        public ActionResult Index()
        {
            return View();
        }

        public JsonResult List()
        {
            List<CustomerViewModel> list = new List<CustomerViewModel>();
            list.Add(new CustomerViewModel() { Id = 1, Name = "aaa", Sex = "男", Email = "asfd@aaa.com", Mobile = "12345678912" });
            list.Add(new CustomerViewModel() { Id = 2, Name = "bbb", Sex = "女", Email = "asfd@aaa.com", Mobile = "12345678912" });
            list.Add(new CustomerViewModel() { Id = 3, Name = "ccc", Sex = "女", Email = "asfd@aaa.com", Mobile = "12345678912" });
            list.Add(new CustomerViewModel() { Id = 4, Name = "eee", Sex = "女", Email = "asfd@aaa.com", Mobile = "12345678912" });
            list.Add(new CustomerViewModel() { Id = 5, Name = "fff", Sex = "男", Email = "asfd@aaa.com", Mobile = "12345678912" });
            list.Add(new CustomerViewModel() { Id = 6, Name = "ggg", Sex = "男", Email = "asfd@aaa.com", Mobile = "12345678912" });
            list.Add(new CustomerViewModel() { Id = 7, Name = "fff", Sex = "男", Email = "asfd@aaa.com", Mobile = "12345678912" });
            //var list = dbContext.Customers.ToList();
            return Json(new { total = list.Count, rows = list }, JsonRequestBehavior.AllowGet);
        }

        public ActionResult Credit()
        {
            return View();
        }

        public JsonResult CreditList()
        {
            List<CustomerViewModel> list = new List<CustomerViewModel>();
            list.Add(new CustomerViewModel() { Id = 1, Name = "aaa", Sex = "男", Email = "asfd@aaa.com", Mobile = "12345678912", Credit = 10000 });
            list.Add(new CustomerViewModel() { Id = 2, Name = "bbb", Sex = "女", Email = "asfd@aaa.com", Mobile = "12345678912", Credit = 10000 });
            list.Add(new CustomerViewModel() { Id = 3, Name = "ccc", Sex = "女", Email = "asfd@aaa.com", Mobile = "12345678912", Credit = 10000 });
            list.Add(new CustomerViewModel() { Id = 4, Name = "eee", Sex = "女", Email = "asfd@aaa.com", Mobile = "12345678912", Credit = 10000 });
            list.Add(new CustomerViewModel() { Id = 5, Name = "fff", Sex = "男", Email = "asfd@aaa.com", Mobile = "12345678912", Credit = 10000 });
            list.Add(new CustomerViewModel() { Id = 6, Name = "ggg", Sex = "男", Email = "asfd@aaa.com", Mobile = "12345678912", Credit = 10000 });
            list.Add(new CustomerViewModel() { Id = 7, Name = "fff", Sex = "男", Email = "asfd@aaa.com", Mobile = "12345678912", Credit = 10000 });
            //var list = dbContext.Customers.ToList();
            return Json(new { total = list.Count, rows = list }, JsonRequestBehavior.AllowGet);
        }

        public ActionResult Bill()
        {
            return View();
        }

        public JsonResult BillList()
        {
            List<CustomerBillViewModel> list = new List<CustomerBillViewModel>();
            list.Add(new CustomerBillViewModel() { Id = 1, OrderId = "aaa", Fee = 10000 , CreateDate = DateTime.Now, State = "未结算"});
            list.Add(new CustomerBillViewModel() { Id = 2, OrderId = "bbb", Fee = 10000, CreateDate = DateTime.Now, State = "未结算" });
            list.Add(new CustomerBillViewModel() { Id = 3, OrderId = "ccc", Fee = 10000, CreateDate = DateTime.Now, State = "未结算" });
            list.Add(new CustomerBillViewModel() { Id = 4, OrderId = "eee", Fee = 10000, CreateDate = DateTime.Now, State = "未结算" });
            list.Add(new CustomerBillViewModel() { Id = 5, OrderId = "fff", Fee = 10000, CreateDate = DateTime.Now, State = "未结算" });
            list.Add(new CustomerBillViewModel() { Id = 6, OrderId = "ggg", Fee = 10000, CreateDate = DateTime.Now, State = "未结算" });
            list.Add(new CustomerBillViewModel() { Id = 7, OrderId = "fff", Fee = 10000, CreateDate = DateTime.Now, State = "未结算" });
            //var list = dbContext.Customers.ToList();
            return Json(new { total = list.Count, rows = list }, JsonRequestBehavior.AllowGet);
        }
    }
}