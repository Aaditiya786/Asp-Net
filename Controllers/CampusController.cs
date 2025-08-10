using System.Web.Mvc;

namespace Tutorial6Ex2.Controllers
{
    public class CampusController : Controller
    {
       
        public ActionResult Overview()
        {
            return Content("This page provides an overview of our campus");
        }

        
        public ActionResult Locations()
        {
            return Content("This page shows locations of all our campuses");
        }
    }
}