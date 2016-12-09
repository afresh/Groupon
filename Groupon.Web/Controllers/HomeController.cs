using System.Web.Mvc;
using Abp.Web.Mvc.Authorization;

namespace Groupon.Web.Controllers
{
    //[AbpMvcAuthorize]
    public class HomeController : GrouponControllerBase
    {
        public ActionResult Index()
        {
            return View("~/App/Main/views/layout/layout.cshtml"); //Layout of the angular application.
        }
	}
}