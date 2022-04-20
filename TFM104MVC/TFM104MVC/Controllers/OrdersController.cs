using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Security.Claims;
using System.Threading.Tasks;
using TFM104MVC.Dtos;
using TFM104MVC.Models.Entity;
using TFM104MVC.Models.Session;
using TFM104MVC.Services;

namespace TFM104MVC.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrdersController : ControllerBase
    {
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly IProductRepository _productRepository;
        private readonly IMapper _mapper;
        public OrdersController(IHttpContextAccessor httpContextAccessor,IProductRepository productRepository,IMapper mapper)
        {
            _httpContextAccessor = httpContextAccessor;
            _productRepository = productRepository;
            _mapper = mapper;
        }

        [HttpPost("addorder")]
        [Authorize(AuthenticationSchemes ="Cookies")]
        public async Task<IActionResult> AddOrder([FromBody] ProductCheck productCheck)
        {
            //1.先取出使用者Id
            var userId = _httpContextAccessor.HttpContext.User.FindFirstValue("userId");
            int UserId = int.Parse(userId);
            //使用參數傳進來的ProductId 取得特定商品資料
            var productFromRepo = await _productRepository.GetProductWithNoPicturesAsync(productCheck.ProductId);

            var orderdetail = new Orderdetail()
            {
                UnitPrice = productFromRepo.OriginalPrice,
                ProductId = productFromRepo.Id,
                Quantity = productCheck.Quantity,
                DiscountPersent = productFromRepo.DiscountPersent,
                Product = productFromRepo,
            };

            List<Orderdetail> listOrderDetails = new List<Orderdetail>();
            listOrderDetails.Add(orderdetail);

            var order = new Order()
            {
                Name = productCheck.Name,
                Discount = null,
                OrderStatus = Models.Enum.OrderStatus.NotPaid,
                Date = DateTime.UtcNow,
                UserId = UserId,
                Orderdetails = listOrderDetails
            };

            await _productRepository.AddOrder(order);
            await _productRepository.SaveAsync();

            return NoContent(); 
        }

        [HttpGet]
        [Authorize(AuthenticationSchemes ="Cookies")]
        public async Task<IActionResult> GetOrders()
        {
            //1.先取出使用者Id
            var userId = _httpContextAccessor.HttpContext.User.FindFirstValue("userId");
            int UserId = int.Parse(userId);

            //2.透過使用者id 叫出特定訂單列表
            var Orders = await _productRepository.GetOrders(UserId);

            if(Orders == null || Orders.Count() == 0)
            {
                return NotFound("目前沒有訂單");
            }

            var orderForShowDto = _mapper.Map<List<OrderForShowDto>>(Orders);
            return Ok(orderForShowDto);
        }

        [HttpGet("{orderId}")]
        [Authorize(AuthenticationSchemes = "Cookies")]
        public async Task<IActionResult> GetOrderdetailByOrderId([FromRoute] int orderId)
        {
            //透過訂單Id 叫出特定訂單詳情(包含訂單 訂單詳情 商品 商品照片)
            var orderdetail = await _productRepository.GetOrderdetailByOrderId(orderId);
            if (orderdetail == null)
            {
                return NotFound("沒有此訂單詳情");
            }
            var orderdetailForShow = _mapper.Map<OrderForShowDto>(orderdetail);

            return Ok(orderdetailForShow);

        }
    }
}
