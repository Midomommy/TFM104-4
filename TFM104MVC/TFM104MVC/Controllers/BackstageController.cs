﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TFM104MVC.Controllers
{
    //後台管理
    public class BackstageController : Controller
    {
        //後台登入頁
        public IActionResult Login()
        {
            ViewData["Title"] = "後台登入";
            ViewData["PageTitle"] = "測試文章頁面";
            return PartialView();
        }

        //後台註冊頁
        public IActionResult Register()
        {
            return PartialView();
        }


        //後台總覽儀錶板頁
        public IActionResult Home()
        {
            return View();
        }

        //商品列表頁
        public IActionResult ProductList()
        {
            return View();
        }

        //新增商品
        public IActionResult NewProduct()
        {
            return View();
        }

        //修改商品
        public IActionResult EditProduct()
        {
            return View();
        }

        //管理中心
        public IActionResult Admin()
        {
            return View();
        }

        //訂單列表
        public IActionResult OrderList()
        {
            return View();
        }

        //單筆訂單
        public IActionResult Order()
        {
            return View();
        }

    }
}
