using eCommerceStarterCode.Data;
using eCommerceStarterCode.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
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
        [HttpGet("{userId}")]
        public IActionResult getCart(string userId)
        {
            var userCart = _context.ShoppingCarts.Include(sc => sc.Product).ToList().Where(sc => sc.UserId == userId);
            return Ok(userCart);
        }

        // POST api/<ShoppingCartsController>
        [HttpPost]
        public IActionResult Post([FromBody] ShoppingCart value)
        {
            _context.ShoppingCarts.Add(value);
            _context.SaveChanges(); 
            return StatusCode(201, value);
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
