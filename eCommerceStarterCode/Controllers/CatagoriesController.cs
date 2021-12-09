using eCommerceStarterCode.Data;
using eCommerceStarterCode.Models;
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
    public class CatagoriesController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        public CatagoriesController(ApplicationDbContext context)
        {
            _context = context;
        }
        // GET: api/<CatagoriesController>
        [HttpGet]
        public IActionResult Get()
        {
            var allCatagories = _context.Catagories;
            return Ok(allCatagories);
        }

        // GET api/<CatagoriesController>/5
        [HttpGet("{id}")]
        public IActionResult Get(int ProductId)
        {
            var singleCatagory = _context.Catagories.Where(p => p.ProductId == Productid).FirstOrDefault();
            return Ok(singleCatagory);
        }

        // POST api/<CatagoriesController>
        [HttpPost]
        public IActionResult Post([FromBody]Catagory value)
        {
            _context.Catagories.Add(value);
            _context.SaveChanges();
            return StatusCode(201, value);
        }

        // PUT api/<CatagoriesController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<CatagoriesController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
