﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using XMS.Models;

namespace XMS.Controllers
{
    public class OrderController : Controller
    {
        // GET: Order
        [HttpGet]
        public ActionResult List()
        {
            return View();
        }

        //[HttpPost]
        public JsonResult Load() {
            List<OrderModel> orders = new List<OrderModel>();
            orders.Add(new OrderModel(1, "Order 1 Test ", "XHD-I23LKDSL0-8234", false));
            orders.Add(new OrderModel(2, "Order 1 Test ", "XHD-I23LKDSL0-8234", false));
            orders.Add(new OrderModel(3, "Order 1 Test ", "XHD-I23LKDSL0-8234", false));
            orders.Add(new OrderModel(4, "Order 1 Test ", "XHD-I23LKDSL0-8234", false));
            orders.Add(new OrderModel(5, "Order 1 Test ", "XHD-I23LKDSL0-8234", false));
            orders.Add(new OrderModel(6, "Order 1 Test ", "XHD-I23LKDSL0-8234", false));
            orders.Add(new OrderModel(7, "Order 1 Test ", "XHD-I23LKDSL0-8234", false));
            orders.Add(new OrderModel(8, "Order 1 Test ", "XHD-I23LKDSL0-8234", false));
            orders.Add(new OrderModel(9, "Order 1 Test ", "XHD-I23LKDSL0-8234", false));
            orders.Add(new OrderModel(10, "Order 1 Test ", "XHD-I23LKDSL0-8234", false));

            return Json(orders, JsonRequestBehavior.AllowGet);
        }
    }
}