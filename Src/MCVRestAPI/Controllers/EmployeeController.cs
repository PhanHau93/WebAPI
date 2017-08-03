using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MCVRestAPI.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MCVRestAPI.Controllers
{
    [Route("api/[controller]")]
    public class EmployeeController : Controller
    {
        private readonly EmployeeContext _context;
        public EmployeeController(EmployeeContext context)
        {
            _context = context;

            if (_context.EmployeeItems.Count() == 0)
            {
                _context.EmployeeItems.Add(new EmployeeItem { name = "Nombre", adress = "Direccion" });
                _context.SaveChangesAsync();
            }
        }
        // GET: api/values
        [HttpGet]
        public IEnumerable<EmployeeItem> Get()
        {
            return _context.EmployeeItems;
        }

        // GET api/values/5
        //[HttpGet("{id}")]
        //public EmployeeItem Get(int id)
        //{
        //    var item = _context.EmployeeItems.Where(emp => emp.id.Equals(id)).FirstOrDefault();
        //    if (item == null)
        //    {
        //        return null;
        //    }
        //    else
        //    {
        //        return item;
        //    }
        //}

        // GET api/values/5
        [HttpGet("{id}", Name ="GetEmployee")]
        public IActionResult GetEmployeeById(int id)
        {
            var item = _context.EmployeeItems.Where(emp => emp.id.Equals(id)).FirstOrDefault();
            if (item == null)
            {
                return NotFound();
            }
            else
            {
                return new ObjectResult(item);
            }
        }

        // Post api/employee
        [HttpPost]
        public IActionResult Create([FromBody]EmployeeItem item)
        {
            if (item == null)
            {
                return BadRequest();
            }
            _context.EmployeeItems.Add(item);
            _context.SaveChangesAsync();

            return CreatedAtRoute("GetEmployee", new { id = item.id }, item);
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
