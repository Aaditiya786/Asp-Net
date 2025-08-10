using System.Web.Mvc;

namespace ASP_NET.Controllers
{
    public class SubjectController : Controller
    {
        // Existing actions
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Details(int id)
        {
            ViewBag.SubjectId = id;
            return View();
        }

        
        public ActionResult About()
        {
            return View(); 
        }
    }
}