using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace TFM104MVC.Controllers
{
    public class OrderController : Controller
    {
        [Authorize(AuthenticationSchemes = "Cookies")]
        public IActionResult Manage()
        {
            return View();
        }

        [Authorize(AuthenticationSchemes = "Cookies")]
        public IActionResult Detail()
        {
            return View();
        }

        [Authorize(AuthenticationSchemes = "Cookies")]
        public IActionResult Edit()
        {
            return View();
        }
    }
}
