namespace ImlSampleDialog.UI.Controllers
{
    using System.Web.Mvc;    
    using Incoding.MvcContrib;

    public class HomeController : IncControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}