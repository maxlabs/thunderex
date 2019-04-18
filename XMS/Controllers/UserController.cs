using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Thunder.Infrastructure.Data;
using Thunder.XMS.Models;

namespace Thunder.XMS.Controllers
{
    public class UserController : Controller
    {
        private XmsDbContext dbContext = new XmsDbContext();
        // GET: UserManagent
        public ActionResult Index()
        {
            return View();
        }

        public JsonResult List()
        {
            List<UserViewModel> list = new List<UserViewModel>();
            list.Add(new UserViewModel() { Id = 1, UserName = "aaaa", Password = "123456", Department = "集散中心A", Role = "财务" });
            list.Add(new UserViewModel() { Id = 2, UserName = "bbbb", Password = "123456", Department = "门店A", Role = "财务" });
            list.Add(new UserViewModel() { Id = 3, UserName = "cccc", Password = "123456", Department = "集散中心B", Role = "财务" });
            list.Add(new UserViewModel() { Id = 4, UserName = "dddd", Password = "123456", Department = "集散中心C", Role = "客服" });
            list.Add(new UserViewModel() { Id = 5, UserName = "eeee", Password = "123456", Department = "门店B", Role = "财务" });
            list.Add(new UserViewModel() { Id = 6, UserName = "ffff", Password = "123456", Department = "集散中心A", Role = "门店人员" });
            list.Add(new UserViewModel() { Id = 7, UserName = "gggg", Password = "123456", Department = "门店C", Role = "财务" });
            list.Add(new UserViewModel() { Id = 8, UserName = "hhhh", Password = "123456", Department = "集散中心A", Role = "财务" });
            //var list = dbContext.Users.ToList();
            return Json(new { total = list.Count, rows = list }, JsonRequestBehavior.AllowGet);
        }

        public ActionResult Role()
        {
            return View();
        }

        public JsonResult RoleList()
        {
            List<UserRoleViewModel> list = new List<UserRoleViewModel>();
            list.Add(new UserRoleViewModel() { Id = 1, Name = "财务" });
            list.Add(new UserRoleViewModel() { Id = 2, Name = "客服" });
            list.Add(new UserRoleViewModel() { Id = 3, Name = "门店员工" });
            list.Add(new UserRoleViewModel() { Id = 4, Name = "管理员" });
            //var list = dbContext.Users.ToList();
            return Json(new { total = list.Count, rows = list }, JsonRequestBehavior.AllowGet);
        }

        
    }
}