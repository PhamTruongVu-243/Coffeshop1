﻿using Coffeshop.Models.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace coffeeshop.Controllers
{
    public class ProductsController : Controller
    {
        private readonly IProductRepository productRepository;

        public ProductsController(IProductRepository productRepository)
        {
            this.productRepository = productRepository;
        }

        public IActionResult Shop()
        {
            var products = productRepository.GetAllProducts();
            return View(products);
        }
        public IActionResult Detail(int id)
        {
            var product = productRepository.GetProductDetail(id);
            if (product != null)
            {
                return View(product);
            }
            return NotFound();
        }

    }
}
