using CodeShop.Common.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodeShop.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : Controller
    {
        [HttpGet]
        public IActionResult Get()
        {
            return View();
        }

        [HttpPost]
        public IProduct Create([FromBody]IProductCreation data)
        {
            if (!ModelState.IsValid) { throw new Exception("bad data dude"); }
            //lets get the core api and create a product

        }


    }
}
