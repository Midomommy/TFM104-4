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
using System;
using System.Net.Http;
using Newtonsoft.Json;
using TFM104MVC.Services;

namespace TFM104MVC.Controllers
{
    public class LoginController : Controller
    {
        private AppDbContext _context;
        string _redirect_uri = "https://localhost:5001/Login/UseLineLogin";
        string _client_id = "1657070363";
        string _client_serect = "37f66dac4363ffef924d522a7a753de4";
        Guid _state = Guid.NewGuid();
        private readonly IHttpClientFactory _clientFactory;
        private readonly IAuthenticateRepository _authenticateRepository;
        public LoginController(AppDbContext appDbContext,IHttpClientFactory httpClientFactory, IAuthenticateRepository authenticateRepository)
        {
            _context = appDbContext;
            _clientFactory = httpClientFactory;
            _authenticateRepository = authenticateRepository;
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

        [HttpPost]
        public IActionResult LineLogin()
        {
            return Ok($"https://access.line.me/oauth2/v2.1/authorize?response_type=code&client_id={_client_id}&redirect_uri={_redirect_uri}&state={_state}&scope=profile%20openid%20email");

        }


        public async Task<IActionResult> UseLineLogin(string code, Guid state, string error, string error_description)
        {
            if (!string.IsNullOrEmpty(error) || _state != state || string.IsNullOrEmpty(code))
                return RedirectToAction(nameof(Index));

            var url = "https://api.line,me/oauth2/v2.1/token";
            var posData = new Dictionary<string, string>()
            {
                {"client_id",_client_id},
                {"client_id",_client_serect},
                {"code",code},
                {"grant_type","authorization_code"},
                {"redirect_uri",_redirect_uri}
            };

            var contentPost = new FormUrlEncodedContent(posData);
            var client = _clientFactory.CreateClient();
            var response = await client.PostAsync(url, contentPost);

            string responseContent;
            if (response.IsSuccessStatusCode)
                responseContent = await response.Content.ReadAsStringAsync();
            else
                return RedirectToAction(nameof(Index));

            var lineLoginResource = JsonConvert.DeserializeObject<LINELoginResource>(responseContent);

            // 因為Line API 可以同時取得ClientId Token 和 Access Token，所以這邊有兩種選擇
            // 1. 使用JWT解析Id Token, Nuget > System.IdentityModel.Tokens.Jwt
            // var userInfo = new JwtSecurityToken(lineLoginResource.IDToken).Payload;

            // 2. https://developers.line.biz/en/reference/social-api/#profile
            url = $"https://api.line.me/v2/profile";
            client.DefaultRequestHeaders.Add("authorization", $"Bearer {lineLoginResource.AccessToken}");
            response = await client.GetAsync(url);
            if (response.IsSuccessStatusCode)
            {
                responseContent = await response.Content.ReadAsStringAsync();
                var user = JsonConvert.DeserializeObject<LINEUser>(responseContent);

                var existUser = _authenticateRepository.AccountCheck(user.UserEmail);
                if (existUser == null)
                {
                    var member = new User
                    {
                        Account = user.UserEmail,
                        Password = "zzzzzzzz",
                        LastName = user.Name,
                        FirstName = "",
                        RoleName = "Member"
                    };

                    _authenticateRepository.AddUser(member);
                    _authenticateRepository.Save();
                };
            }
            return View();
        }

        public class LINELoginResource
        {
            [JsonProperty("access_token")]
            public string AccessToken { get; set; }

            [JsonProperty("token_type")]
            public string TokenType { get; set; }

            [JsonProperty("expires_in")]
            public string ExpiresIn { get; set; }

            [JsonProperty("scope")]
            public string Scope { get; set; }

            [JsonProperty("refresh_token")]
            public string RefreshToken { get; set; }

            // 這邊跟一般的TokenResponse不同，多了使用者的Id Token
            [JsonProperty("id_token")]
            public string IDToken { get; set; }
        }

        public class LINEUser
        {
            [JsonProperty("userId")]
            public string Id { get; set; }

            [JsonProperty("displayName")]
            public string Name { get; set; }

            [JsonProperty("pictureUrl")]
            public string PictureUrl { get; set; }

            [JsonProperty("statusMessage")]
            public string StatusMessage { get; set; }

            [JsonProperty("email")]
            public string UserEmail { get; set; }
        }
















    }
}
