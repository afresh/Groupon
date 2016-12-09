using System.Web.Mvc;
using Abp.Web.Mvc.Authorization;

namespace Groupon.Web.Controllers
{
    [AbpMvcAuthorize]
    public class CmsController : GrouponControllerBase
    {
        public ActionResult Index()
        {
            return View("~/Cms/Main/views/layout/layout.cshtml"); //Layout of the angular application.
        }
	}
}