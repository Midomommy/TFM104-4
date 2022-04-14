using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication.Facebook;
using Microsoft.AspNetCore.Authentication.Google;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Threading.Tasks;

namespace TFM104MVC.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> ResponseAsync()
        {
            var res = await HttpContext.AuthenticateAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            var data = res.Principal.Claims.Select(x => new
            {
                x.Type,
                x.Value,
                x.Issuer,
                x.OriginalIssuer
            });
            //return Json(data);
            return Redirect("~/Home/Index");
        }

        //============FB登入(修)
        public IActionResult FbLogin()
        {
            var p = new AuthenticationProperties()
            {
                RedirectUri = Url.Action("Response")
            };
            return Challenge(p, FacebookDefaults.AuthenticationScheme);
        }
        //============Google登入(修)
        public IActionResult GoogleLogin()
        {
            var g = new AuthenticationProperties()
            {
                RedirectUri = Url.Action("Response")
            };
            return Challenge(g, GoogleDefaults.AuthenticationScheme);
        }

        //public async Task<IActionResult> ResponseAsync()
        //{
        //    var res = await HttpContext.AuthenticateAsync(CookieAuthenticationDefaults.AuthenticationScheme);
        //    var data = res.Principal.Claims.Select(x => new
        //    {
        //        x.Type,
        //        x.Value,
        //        x.Issuer,
        //        x.OriginalIssuer
        //    });

        //    //return Json(data);
        //    return Redirect("~/Home/Index");
        //}
        //============










    }
}
