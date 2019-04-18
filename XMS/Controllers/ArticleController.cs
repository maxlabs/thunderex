using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Thunder.XMS.Models;

namespace Thunder.XMS.Controllers
{
    public class ArticleController : Controller
    {
        // GET: Article
        public ActionResult Index()
        {
            return View();
        }

        public JsonResult List()
        {
            List<ArticleViewModel> list = new List<ArticleViewModel>();
            list.Add(new ArticleViewModel() { Id = 1, Title = "aaa" , Creator = "asdf", Content = "adfasdf", CreateTime = DateTime.Now });
            list.Add(new ArticleViewModel() { Id = 2, Title = "aaa", Creator = "asdf", Content = "adfasdf", CreateTime = DateTime.Now });
            list.Add(new ArticleViewModel() { Id = 3, Title = "aaa", Creator = "asdf", Content = "adfasdf", CreateTime = DateTime.Now });
            list.Add(new ArticleViewModel() { Id = 4, Title = "aaa", Creator = "asdf", Content = "adfasdf", CreateTime = DateTime.Now });
            list.Add(new ArticleViewModel() { Id = 5, Title = "aaa", Creator = "asdf", Content = "adfasdf", CreateTime = DateTime.Now });
            list.Add(new ArticleViewModel() { Id = 6, Title = "aaa", Creator = "asdf", Content = "adfasdf", CreateTime = DateTime.Now });
            list.Add(new ArticleViewModel() { Id = 7, Title = "aaa", Creator = "asdf", Content = "adfasdf", CreateTime = DateTime.Now });
            list.Add(new ArticleViewModel() { Id = 8, Title = "aaa", Creator = "asdf", Content = "adfasdf", CreateTime = DateTime.Now });
            //var list = dbContext.Stores.ToList();
            return Json(new { total = list.Count, rows = list });
        }
    }
}