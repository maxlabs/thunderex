using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Thunder.ApplicationCore.Entities;
using Thunder.Infrastructure.Data;
using Thunder.XMS.Models.Channel;
using XMS.Models;

namespace Thunder.XMS.Controllers
{
    public class ChannelController : Controller
    {
        private XmsDbContext dbContext = new XmsDbContext();
        // GET: Channel
        #region Channel
        public ActionResult Index()
        {
            return View();
        }

        public JsonResult List()
        {
            var list = dbContext.Channels.ToList();
            return Json(new { total = list.Count, rows = list });
        }

        public ActionResult Add()
        {
            var model = new TbChannel();
            return View(model);
        }

        [HttpPost]
        public JsonResult Delete(List<int> ids)
        {
            var result = ResultUtil.success("删除成功！");
            return Json(result, "application/json");
        }
        #endregion

        #region Payment
        public ActionResult Payment()
        {
            return View();
        }

        public JsonResult PaymentList()
        {
            List<ChannelPaymentViewModel> list = new List<ChannelPaymentViewModel>();
            for(int i = 0; i < 100; i++)
            {
                list.Add(new ChannelPaymentViewModel(i, i, 10 * i, 20 *i, 30 *i));
            }
            
            return Json(new { total = list.Count, rows = list });
            
        }

        [HttpPost]
        public JsonResult PaymentDelete(List<int> ids)
        {
            var result = ResultUtil.success("删除成功！");
            return Json(result, "application/json");
        }
        #endregion

        #region Receipt
        public ActionResult Receipt()
        {
            return View();
        }

        public JsonResult ReceiptList()
        {
            List<ChannelReceiptViewModel> list = new List<ChannelReceiptViewModel>();
            for (int i = 0; i < 100; i++)
            {
                list.Add(new ChannelReceiptViewModel(i, i, 10 * i, 20 * i, 30 * i));
            }

            return Json(new { total = list.Count, rows = list });

        }

        [HttpPost]
        public JsonResult ReceiptDelete(List<int> ids)
        {
            var result = ResultUtil.success("删除成功！");
            return Json(result, "application/json");
        }
        #endregion
    }
}