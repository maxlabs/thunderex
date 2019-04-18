using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Thunder.XMS.Models;

namespace Thunder.XMS.Controllers
{
    public class OrderController : Controller
    {
        // GET: OrderCollect
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Adjust()
        {
            return View();
        }

        public JsonResult OrderList()
        {
            List<OrderViewModel> list = new List<OrderViewModel>();
            list.Add(new OrderViewModel() { Id = 1, OrderId = "123123132", Fee = 123456, Customer = "asdf", Mobile = "12345678912", IdCard = "asfsafasd" });
            list.Add(new OrderViewModel() { Id = 2, OrderId = "123123132", Fee = 123456, Customer = "asdf", Mobile = "12345678912", IdCard = "asfsafasd" });
            list.Add(new OrderViewModel() { Id = 3, OrderId = "123123132", Fee = 123456, Customer = "asdf", Mobile = "12345678912", IdCard = "asfsafasd" });
            list.Add(new OrderViewModel() { Id = 4, OrderId = "123123132", Fee = 123456, Customer = "asdf", Mobile = "12345678912", IdCard = "asfsafasd" });
            list.Add(new OrderViewModel() { Id = 5, OrderId = "123123132", Fee = 123456, Customer = "asdf", Mobile = "12345678912", IdCard = "asfsafasd" });
            list.Add(new OrderViewModel() { Id = 6, OrderId = "123123132", Fee = 123456, Customer = "asdf", Mobile = "12345678912", IdCard = "asfsafasd" });
            list.Add(new OrderViewModel() { Id = 7, OrderId = "123123132", Fee = 123456, Customer = "asdf", Mobile = "12345678912", IdCard = "asfsafasd" });
            list.Add(new OrderViewModel() { Id = 8, OrderId = "123123132", Fee = 123456, Customer = "asdf", Mobile = "12345678912", IdCard = "asfsafasd" });
            //var list = dbContext.Stores.ToList();
            return Json(new { total = list.Count, rows = list });
        }
    }
}