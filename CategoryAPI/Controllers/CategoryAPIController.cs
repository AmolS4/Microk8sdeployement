using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using CategoryAPI.Models;
namespace CategoryAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryAPIController : ControllerBase
    {
        CategoriesDb cats;

        public CategoryAPIController()
        {
            cats = new CategoriesDb();
        }
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(cats);
        }
    }
}
