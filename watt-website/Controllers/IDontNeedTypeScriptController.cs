using Microsoft.AspNetCore.Mvc;

namespace watt_website.Controllers
{
    public class IDontNeedTypeScriptController : Controller
    {
        /// <summary>
        /// SPA entry point
        /// </summary>
        /// <returns></returns>
        public IActionResult Index()
        {
            return View();
        }
    }
}