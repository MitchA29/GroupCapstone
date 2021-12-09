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
    public class ReviewsController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        public ReviewsController(ApplicationDbContext context)
        {
            _context = context;
        }
        // GET: api/<ReviewsController>
        [HttpGet]
        public IActionResult Get()
        {
            var allReviews = _context.Reviews;
            return Ok(allReviews);
        }

        // GET api/<ReviewsController>/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var singleReview = _context.Reviews.Where(i => i.Id == id).FirstOrDefault();
            return Ok(singleReview);
        }

        // POST api/<ReviewsController>
        [HttpPost]
        public IActionResult Post([FromBody] Review value)
        {
            _context.Reviews.Add(value);
            _context.SaveChanges();
            return StatusCode(201, value);
        }

        // PUT api/<ReviewsController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ReviewsController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }

        [HttpGet("ratings{productId}")]
        public IActionResult GetRating(int productId)
        {
            var totalRating = _context.Reviews.Where(r => r.ProductId == productId).Select(a => a.Rating).Sum();
            var numberOfReviews = _context.Reviews.Where(r => r.ProductId == productId).Count();
            var ratingAverage = 0;

            if(totalRating == 0)
            {
                ratingAverage = 0;
            }
            else if(numberOfReviews > 0)
            {
                ratingAverage = totalRating / numberOfReviews;
            }
            return Ok(String.Format("{0:.##}", ratingAverage));
        }
    }
}
