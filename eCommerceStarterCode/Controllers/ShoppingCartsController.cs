using eCommerceStarterCode.Data;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace eCommerceStarterCode.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ShoppingCartsController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        public ShoppingCartsController(ApplicationDbContext context)
        {
            _context = context;
        }
        // GET: api/<ShoppingCartsController>
        [HttpGet]
        public IActionResult Get()
        {
            var allShoppingCarts = _context.ShoppingCarts;
            return Ok(allShoppingCarts);
        }

        // GET api/<ShoppingCartsController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<ShoppingCartsController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<ShoppingCartsController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ShoppingCartsController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
