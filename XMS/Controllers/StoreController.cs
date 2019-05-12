using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Thunder.XMS.Models;
using Thunder.XMS.Models.Store;

namespace Thunder.XMS.Controllers
{
    public class StoreController : Controller
    {
        // GET: StoreOrder
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Bill()
        {
            return View();
        }

        public JsonResult BillList()
        {
            List<BillViewModel> list = new List<BillViewModel>();
            list.Add(new BillViewModel() { Id = 1, Customer = "aaa", Address = "北京", Country = "中国", Fee = 100, Receiver = "bbb", RecvMobile = "123456789912", State = "集散中心" });
            list.Add(new BillViewModel() { Id = 2, Customer = "aaa", Address = "北京", Country = "中国", Fee = 100, Receiver = "bbb", RecvMobile = "123456789912", State = "集散中心" });
            list.Add(new BillViewModel() { Id = 3, Customer = "aaa", Address = "北京", Country = "中国", Fee = 100, Receiver = "bbb", RecvMobile = "123456789912", State = "集散中心" });
            list.Add(new BillViewModel() { Id = 4, Customer = "aaa", Address = "北京", Country = "中国", Fee = 100, Receiver = "bbb", RecvMobile = "123456789912", State = "集散中心" });
            list.Add(new BillViewModel() { Id = 5, Customer = "aaa", Address = "北京", Country = "中国", Fee = 100, Receiver = "bbb", RecvMobile = "123456789912", State = "集散中心" });
            list.Add(new BillViewModel() { Id = 6, Customer = "aaa", Address = "北京", Country = "中国", Fee = 100, Receiver = "bbb", RecvMobile = "123456789912", State = "集散中心" });
            list.Add(new BillViewModel() { Id = 7, Customer = "aaa", Address = "北京", Country = "中国", Fee = 100, Receiver = "bbb", RecvMobile = "123456789912", State = "集散中心" });
            list.Add(new BillViewModel() { Id = 8, Customer = "aaa", Address = "北京", Country = "中国", Fee = 100, Receiver = "bbb", RecvMobile = "123456789912", State = "集散中心" });
            //var list = dbContext.Stores.ToList();
            return Json(new { total = list.Count, rows = list });
        }

        public ActionResult Problem()
        {
            return View();
        }

        public JsonResult ProblemList()
        {
            List<ProblemShipmentViewModel> list = new List<ProblemShipmentViewModel>();
            list.Add(new ProblemShipmentViewModel(1, 111, "1111", "aaa", "bbb", "ccc", "ddd", "eee", DateTime.Now));
            list.Add(new ProblemShipmentViewModel(1, 111, "1111", "aaa", "bbb", "ccc", "ddd", "eee", DateTime.Now));
            list.Add(new ProblemShipmentViewModel(1, 111, "1111", "aaa", "bbb", "ccc", "ddd", "eee", DateTime.Now));
            list.Add(new ProblemShipmentViewModel(1, 111, "1111", "aaa", "bbb", "ccc", "ddd", "eee", DateTime.Now));
            list.Add(new ProblemShipmentViewModel(1, 111, "1111", "aaa", "bbb", "ccc", "ddd", "eee", DateTime.Now));
            list.Add(new ProblemShipmentViewModel(1, 111, "1111", "aaa", "bbb", "ccc", "ddd", "eee", DateTime.Now));
            list.Add(new ProblemShipmentViewModel(1, 111, "1111", "aaa", "bbb", "ccc", "ddd", "eee", DateTime.Now));
            list.Add(new ProblemShipmentViewModel(1, 111, "1111", "aaa", "bbb", "ccc", "ddd", "eee", DateTime.Now));
            //var list = dbContext.Stores.ToList();
            return Json(new { total = list.Count, rows = list });
        }


        public ActionResult IdCard()
        {
            return View();
        }

        public JsonResult IdCardList()
        {
            List<IdCardViewModel> list = new List<IdCardViewModel>();
            list.Add(new IdCardViewModel() { Id = 1, Customer = "aaa", OrderId = "123123132", ReceiveCard = "asdfasfd", Receiver = "asdf", CustomerCard = "asfasdfsaf" });
            list.Add(new IdCardViewModel() { Id = 2, Customer = "aaa", OrderId = "123123132", ReceiveCard = "asdfasfd", Receiver = "asdf", CustomerCard = "asfasdfsaf" });
            list.Add(new IdCardViewModel() { Id = 3, Customer = "aaa", OrderId = "123123132", ReceiveCard = "asdfasfd", Receiver = "asdf", CustomerCard = "asfasdfsaf" });
            list.Add(new IdCardViewModel() { Id = 4, Customer = "aaa", OrderId = "123123132", ReceiveCard = "asdfasfd", Receiver = "asdf", CustomerCard = "asfasdfsaf" });
            list.Add(new IdCardViewModel() { Id = 5, Customer = "aaa", OrderId = "123123132", ReceiveCard = "asdfasfd", Receiver = "asdf", CustomerCard = "asfasdfsaf" });
            list.Add(new IdCardViewModel() { Id = 6, Customer = "aaa", OrderId = "123123132", ReceiveCard = "asdfasfd", Receiver = "asdf", CustomerCard = "asfasdfsaf" });
            list.Add(new IdCardViewModel() { Id = 7, Customer = "aaa", OrderId = "123123132", ReceiveCard = "asdfasfd", Receiver = "asdf", CustomerCard = "asfasdfsaf" });
            list.Add(new IdCardViewModel() { Id = 8, Customer = "aaa", OrderId = "123123132", ReceiveCard = "asdfasfd", Receiver = "asdf", CustomerCard = "asfasdfsaf" });
            //var list = dbContext.Stores.ToList();
            return Json(new { total = list.Count, rows = list });
        }

        public ActionResult History()
        {
            return View();
        }

        public ActionResult ChangeRecord()
        {
            return View();
        }

        public JsonResult ChangeRecordList()
        {
            List<ChangeRecordViewModel> list = new List<ChangeRecordViewModel>();
            list.Add(new ChangeRecordViewModel() { Id = 1, OrderId = "123123132", Content = "修改运单价格", OpUser = "asdf", OpTime = DateTime.Now });
            list.Add(new ChangeRecordViewModel() { Id = 2, OrderId = "123123132", Content = "修改物流记录", OpUser = "asdf", OpTime = DateTime.Now });
            list.Add(new ChangeRecordViewModel() { Id = 3, OrderId = "123123132", Content = "修改物流记录", OpUser = "asdf", OpTime = DateTime.Now });
            list.Add(new ChangeRecordViewModel() { Id = 4, OrderId = "123123132", Content = "修改物流记录", OpUser = "asdf", OpTime = DateTime.Now });
            list.Add(new ChangeRecordViewModel() { Id = 5, OrderId = "123123132", Content = "修改运单价格", OpUser = "asdf", OpTime = DateTime.Now });
            list.Add(new ChangeRecordViewModel() { Id = 6, OrderId = "123123132", Content = "修改运单价格", OpUser = "asdf", OpTime = DateTime.Now });
            list.Add(new ChangeRecordViewModel() { Id = 7, OrderId = "123123132", Content = "修改物流记录", OpUser = "asdf", OpTime = DateTime.Now });
            list.Add(new ChangeRecordViewModel() { Id = 8, OrderId = "123123132", Content = "修改物流记录", OpUser = "asdf", OpTime = DateTime.Now });
            //var list = dbContext.Stores.ToList();
            return Json(new { total = list.Count, rows = list });
        }

        public ActionResult Financial()
        {
            return View();
        }

        public JsonResult FinancialList()
        {
            List<StoreFinancialViewModel> list = new List<StoreFinancialViewModel>();
            list.Add(new StoreFinancialViewModel() { Id = 1, OrderId = "123123132", Fee = 100, Source = "支付宝", CreateTime = DateTime.Now });
            list.Add(new StoreFinancialViewModel() { Id = 2, OrderId = "123123132", Fee = 100, Source = "微信", CreateTime = DateTime.Now });
            list.Add(new StoreFinancialViewModel() { Id = 3, OrderId = "123123132", Fee = 100, Source = "支付宝", CreateTime = DateTime.Now });
            list.Add(new StoreFinancialViewModel() { Id = 4, OrderId = "123123132", Fee = 100, Source = "支付宝", CreateTime = DateTime.Now });
            list.Add(new StoreFinancialViewModel() { Id = 5, OrderId = "123123132", Fee = 100, Source = "微信", CreateTime = DateTime.Now });
            list.Add(new StoreFinancialViewModel() { Id = 6, OrderId = "123123132", Fee = 100, Source = "微信", CreateTime = DateTime.Now });
            list.Add(new StoreFinancialViewModel() { Id = 7, OrderId = "123123132", Fee = 100, Source = "支付宝", CreateTime = DateTime.Now });
            list.Add(new StoreFinancialViewModel() { Id = 8, OrderId = "123123132", Fee = 100, Source = "支付宝", CreateTime = DateTime.Now });
            //var list = dbContext.Stores.ToList();
            return Json(new { total = list.Count, rows = list });
        }

        public ActionResult Performance()
        {
            return View();
        }

        public JsonResult PerformanceList()
        {
            List<PerformanceViewModel> list = new List<PerformanceViewModel>();
            list.Add(new PerformanceViewModel() { Id = 1, User = "afas", Fee = 110 , Count = 1 });
            list.Add(new PerformanceViewModel() { Id = 2, User = "asfsaf", Fee= 220 , Count = 3});
            list.Add(new PerformanceViewModel() { Id = 3, User = "asfsaf", Fee = 330 , Count = 5});
            list.Add(new PerformanceViewModel() { Id = 4, User = "asdfasdf", Fee = 440 , Count = 2});
            //var list = dbContext.Users.ToList();
            return Json(new { total = list.Count, rows = list }, JsonRequestBehavior.AllowGet);
        }

        public ActionResult ApplicationMaterials()
        {
            return View();
        }

        public JsonResult ApplicationList()
        {
            List<ApplicationMaterialViewModel> list = new List<ApplicationMaterialViewModel>();
            list.Add(new ApplicationMaterialViewModel(1, "saaa", "sbbb", "sccc","raaa", "rbbb", "rccc"));
            list.Add(new ApplicationMaterialViewModel(1, "saaa", "sbbb", "sccc", "raaa", "rbbb", "rccc"));
            list.Add(new ApplicationMaterialViewModel(1, "saaa", "sbbb", "sccc", "raaa", "rbbb", "rccc"));
            list.Add(new ApplicationMaterialViewModel(1, "saaa", "sbbb", "sccc", "raaa", "rbbb", "rccc"));
            list.Add(new ApplicationMaterialViewModel(1, "saaa", "sbbb", "sccc", "raaa", "rbbb", "rccc"));
            list.Add(new ApplicationMaterialViewModel(1, "saaa", "sbbb", "sccc", "raaa", "rbbb", "rccc"));
            list.Add(new ApplicationMaterialViewModel(1, "saaa", "sbbb", "sccc", "raaa", "rbbb", "rccc"));
            list.Add(new ApplicationMaterialViewModel(1, "saaa", "sbbb", "sccc", "raaa", "rbbb", "rccc"));
            list.Add(new ApplicationMaterialViewModel(1, "saaa", "sbbb", "sccc", "raaa", "rbbb", "rccc"));
            list.Add(new ApplicationMaterialViewModel(1, "saaa", "sbbb", "sccc", "raaa", "rbbb", "rccc"));
            return Json(new { total = list.Count, rows = list }, JsonRequestBehavior.AllowGet);
        }

        public ActionResult MaterialsUpload()
        {
            return View();
        }
    }
}