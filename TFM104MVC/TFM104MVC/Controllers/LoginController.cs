using AutoMapper.Execution;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication.Facebook;
using Microsoft.AspNetCore.Authentication.Google;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TFM104MVC.Database;
using TFM104MVC.Models.Entity;
using TFM104MVC.Extensions;
using System.Security.Claims;
using Microsoft.AspNetCore.Authorization;

namespace TFM104MVC.Controllers
{
    public class LoginController : Controller
    {
        private AppDbContext _context;

        public LoginController(AppDbContext appDbContext)
        {
            _context = appDbContext;
        }

        //private readonly IConfiguration _configuration;
        //private readonly IAuthenticateRepository _authenticateRepository;
        //private readonly IMapper _mapper;
        //private readonly ISender _sender;
        //private readonly IProductRepository _productRepository;
        //private readonly IHttpContextAccessor _httpContextAccessor;
        //public LoginController(IConfiguration configuration, IAuthenticateRepository authenticateRepository, IMapper mapper, ISender sender, IProductRepository productRepository, IHttpContextAccessor httpContextAccessor)

        //{
        //    _configuration = configuration;
        //    _authenticateRepository = authenticateRepository;
        //    _mapper = mapper;
        //    _sender = sender;
        //    _productRepository = productRepository;
        //    _httpContextAccessor = httpContextAccessor;

        //}

        //會員管理頁
        [Authorize(AuthenticationSchemes = "Cookies")]
        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> ResponseAsync()
        {
            var res = await HttpContext.AuthenticateAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            var data = res.Principal.Claims.Select(x => new KeyValuePair<string, string>(x.Type, x.Value)).ToList();
            var email = data.GetValueByKey("emailaddress");
            var lastName = data.GetValueByKey("surname");
            var firstName = data.GetValueByKey("givenname");
            if (string.IsNullOrWhiteSpace(email)) throw new System.Exception("Can not Find Fb Email");
            var existUser = _context.Users.FirstOrDefault(x => x.Account == email);
            if (existUser == null)
            {
                var member = new User
                {
                    Account = email,
                    Password = "zzzzzzzz",
                    LastName = lastName,
                    FirstName = firstName,
                    RoleName = "Member"
                };

                _context.Users.Add(member);
                _context.SaveChanges();
            };

            var user = _context.Users.FirstOrDefault(x => x.Account == email);

            //return Ok("登入成功");
            //return Json(data);
            return Redirect("~/Home/Index");
        }




        /// <summary>
        /// FB登入(修)
        /// </summary>
        /// <returns></returns>
        public IActionResult FbLogin()
        {
            var p = new AuthenticationProperties()
            {
                RedirectUri = Url.Action("Response")
            };
            return Challenge(p, FacebookDefaults.AuthenticationScheme);
        }
        /// <summary>
        /// Google登入(修)
        /// </summary>
        /// <returns></returns>
        public IActionResult GoogleLogin()
        {
            var g = new AuthenticationProperties()
            {
                RedirectUri = Url.Action("Response")
            };
            return Challenge(g, GoogleDefaults.AuthenticationScheme);
        }










    }
}
