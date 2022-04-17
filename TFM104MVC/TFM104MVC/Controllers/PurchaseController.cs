using AutoMapper;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Security.Claims;
using System.Threading.Tasks;

using TFM104MVC.Dtos;
using TFM104MVC.Models;
using TFM104MVC.Models.Entity;
using TFM104MVC.Services;

namespace TFM104MVC.Controllers
{
    public class PurchaseController : Controller
    {
        private IProductRepository _productRepository;
        private readonly IMapper _mapper;
        private readonly IWebHostEnvironment _environment;

        public PurchaseController(IProductRepository productRepository, IMapper mapper, IWebHostEnvironment webHostEnvironment)
        {
            _productRepository = productRepository;
            _mapper = mapper;
            _environment = webHostEnvironment;
        }

        [HttpPost]
        public IActionResult Booking([FromForm]List<string> productId)
        {

            //把商品id從session拿出來
            //var pid= HttpContext.Session.GetString("pid");
        
            //System.Console.WriteLine(pid); //確定有拿到 我好棒

            //var userId = HttpContext.User.FindFirstValue("userId");

            //var productFromRepo = await  _productRepository.GetProductAsync(Guid.Parse(pid));

            //var orderItem = new LineItem()
            //{
            //    ProductId = productFromRepo.Id,
            //    DiscountPersent = productFromRepo.DiscountPersent,
            //    OriginalPrice = productFromRepo.OriginalPrice,
            //    Product = productFromRepo,
            //};

            //var order = new Order()
            //{
            //    UserId = int.Parse(userId),
            //    CreateDateUTC = DateTime.UtcNow,
            //    State = OrderStateEnum.Pending,
            //    OrderItems = (ICollection<LineItem>)orderItem
            //};


            return View();

        }
        public IActionResult Cart()
        {
            return View();
        }

    }
}
