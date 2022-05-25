using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Project.Models;
using Project.RequestModel;

namespace Project.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        // GET: api/CustomerAddress
        private readonly ProjectContext _projectcontext;
        public CustomerController(ProjectContext project)
        {
            _projectcontext = project;
        }
        [HttpGet]
        public IActionResult Get1()
        {
            var getCostumer = _projectcontext.Customer.ToList();
            return Ok(getCostumer);
        }





        [HttpGet("{id:int}")]
         
        public IActionResult Get2(int id)
        {
            try
            {
                var x = _projectcontext.Customer.First(obj => obj.CustomerId == id);
                if (x == null)
                    return NotFound();
                return Ok(x);
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Error!");
            }
        }

    //public IEnumerable<string> Get()
        //{
        //    return new string[] { "value1", "value2" };
        //}

        // GET: api/CustomerAddress/5
        //[HttpGet("{id}", Name = "Get")]
        //public string Get(int id)
        //{
        //    return "value";
        //}

        // POST: api/CustomerAddress
        [HttpPost]
        public void Post([FromBody] CustomerRequest value)
        {
            Customer obje = new Customer();
            obje.FirstName = value.FirstName;
            obje.LastName = value.LastName;
            obje.CustomerAddress = value.CustomerAddress;
            _projectcontext.Customer.Add(obje);
            _projectcontext.SaveChanges();
        }

        // PUT: api/CustomerAddress/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
