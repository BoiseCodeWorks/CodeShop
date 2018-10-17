using CodeShop.Common.Entities;
using CodeShop.Common.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CodeShop.Business;

namespace CodeShop.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : Controller
    {
        ProductService _productService;
        [HttpGet]
        public IActionResult Get()
        {
            return View();
        }

        [HttpGet("create")]
        public IActionResult CreateProduct()
        {
            return View();
        }

        [HttpPost("create")]
        public IProduct CreateProduct([FromBody]Product data)
        {
            if (!ModelState.IsValid) { throw new Exception("bad data dude"); }
            //lets get the core api and create a product
            return _productService.CreateProduct(data);
        }



        public ProductsController(ProductService ps)
        {
            _productService = ps;
        }



    }
}
