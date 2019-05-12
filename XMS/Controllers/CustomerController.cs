using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Thunder.XMS.Models;
using XMS.Models;

namespace XMS.Controllers
{
    public class CustomerController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public JsonResult List1()
        {
            List<CustomerViewModel> customers = new List<CustomerViewModel>();
            customers.Add(new CustomerViewModel(1, "Customer 1", "8234", "18866668888", "123456@qq.com", 1100));
            customers.Add(new CustomerViewModel(2, "Customer 1", "8234", "18866668888", "123456@qq.com", 1100));
            customers.Add(new CustomerViewModel(3, "Customer 1", "8234", "18866668888", "123456@qq.com", 1100));
            customers.Add(new CustomerViewModel(4, "Customer 1", "8234", "18866668888", "123456@qq.com", 1100));
            customers.Add(new CustomerViewModel(5, "Customer 1", "8234", "18866668888", "123456@qq.com", 1100));
            customers.Add(new CustomerViewModel(6, "Customer 1", "8234", "18866668888", "123456@qq.com", 1100));
            customers.Add(new CustomerViewModel(7, "Customer 1", "8234", "18866668888", "123456@qq.com", 1100));
            customers.Add(new CustomerViewModel(8, "Customer 1", "8234", "18866668888", "123456@qq.com", 1100));
            customers.Add(new CustomerViewModel(9, "Customer 1", "8234", "18866668888", "123456@qq.com", 1100));
            customers.Add(new CustomerViewModel(10, "Customer 1", "8234","18866668888", "123456@qq.com", 1100));

            Dictionary<string, object> result = new Dictionary<string, object>();
            result.Add("rows", customers);
            result.Add("total", 100);

            return Json(result, "application/x-www-form-urlencoded");
        }


        // GET: Customer
        public ActionResult List()
        {
            return View();
        }

        [HttpPost]
        public JsonResult Load()
        {
            List<CustomerModel> customers = new List<CustomerModel>();
            customers.Add(new CustomerModel(1, "Customer 1", "8234", "风雷快递", "010-88888888", "18866668888", "北京市海淀区学院路40号"));
            customers.Add(new CustomerModel(2, "Customer 1", "8234", "风雷快递", "010-88888888", "18866668888", "北京市海淀区学院路40号"));
            customers.Add(new CustomerModel(3, "Customer 1", "8234", "风雷快递", "010-88888888", "18866668888", "北京市海淀区学院路40号"));
            customers.Add(new CustomerModel(4, "Customer 1", "8234", "风雷快递", "010-88888888", "18866668888", "北京市海淀区学院路40号"));
            customers.Add(new CustomerModel(5, "Customer 1", "8234", "风雷快递", "010-88888888", "18866668888", "北京市海淀区学院路40号"));
            customers.Add(new CustomerModel(6, "Customer 1", "8234", "风雷快递", "010-88888888", "18866668888", "北京市海淀区学院路40号"));
            customers.Add(new CustomerModel(7, "Customer 1", "8234", "风雷快递", "010-88888888", "18866668888", "北京市海淀区学院路40号"));
            customers.Add(new CustomerModel(8, "Customer 1", "8234", "风雷快递", "010-88888888", "18866668888", "北京市海淀区学院路40号"));
            customers.Add(new CustomerModel(9, "Customer 1", "8234", "风雷快递", "010-88888888", "18866668888", "北京市海淀区学院路40号"));
            customers.Add(new CustomerModel(10, "Customer 1", "8234", "风雷快递", "010-88888888", "18866668888", "北京市海淀区学院路40号"));

            Dictionary<string, object> result = new Dictionary<string, object>();
            result.Add("rows", customers);
            result.Add("total", 100);

            return Json(result, "application/x-www-form-urlencoded");
        }

        [HttpPost]
        public JsonResult Delete(List<string> ids)
        {
            var result = ResultUtil.success("删除成功！");
            return Json(result, "application/json");
        }

        public ActionResult Credit()
        {
            return View();
        }

        public ActionResult Bill()
        {
            return View();
        }
    }
}