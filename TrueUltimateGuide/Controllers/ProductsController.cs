﻿using Microsoft.AspNetCore.Mvc;

namespace TrueUltimateGuide.Controllers
{
    public class ProductsController : Controller
    {
        //[Route("products/all")]
        //public IActionResult All()
        //{
        //    return View();
        //    //Views/Products/All.cshtml
        //    //Views/Shared/All.cshtml
        //}

        [Route("products")]
        public IActionResult Index()
        {
            return View();
        }

        //Url: /search-products
        //Url: /search-products/1
        [Route("search-products/{ProductID?}")]
        public IActionResult Search(int? ProductID)
        {
            ViewBag.ProductID = ProductID;
            return View();
        }

        [Route("order-product")]
        public IActionResult Order()
        {
            return View();
        }
    }
}
