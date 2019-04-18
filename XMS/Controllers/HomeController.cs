using System.Linq;
using System.Web.Mvc;
using Thunder.Infrastructure.Data;

namespace Thunder.XMS.Controllers
{
    public class HomeController : Controller
    {
        private XmsDbContext dbContext = new XmsDbContext();
        public ActionResult Index()
        {
            
            var tmp = dbContext.Channels.ToList();
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}