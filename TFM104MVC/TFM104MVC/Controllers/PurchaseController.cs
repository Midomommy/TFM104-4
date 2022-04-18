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
            List<string> pidList= new List<string>();
            ViewBag.pidList = productId;

            Console.WriteLine(ViewBag.pidList);

            return View();

        }
        public IActionResult Cart()
        {
            return View();
        }

    }
}
