using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MCVRestAPI.Models;
using MCVRestAPI.Context;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MCVRestAPI.Controllers
{
    [Route("api/[controller]")]
    public class ProviderController : Controller
    {
        private readonly ApplicationContext _context;
        public ProviderController(ApplicationContext context)
        {
            _context = context;
            
            if (_context.ProviderItems.Count() == 0)
            {
                _context.ProviderItems.Add(new ProviderItem { name = "Nombre", address = "Direccion" });
                _context.SaveChangesAsync();
            }
        }
        // GET: api/values
        [HttpGet]
        public IEnumerable<ProviderItem> Get()
        {
            return _context.ProviderItems;
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
        [HttpGet("{id}", Name ="GetProvider")]
        public IActionResult GetEmployeeById(int id)
        {
            var item = _context.ProviderItems.Where(emp => emp.id.Equals(id)).FirstOrDefault();
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
        public IActionResult Create([FromBody]ProviderItem item)
        {
            if (item == null)
            {
                return BadRequest();
            }
            _context.ProviderItems.Add(item);
            _context.SaveChangesAsync();

            return CreatedAtRoute("GetProvider", new { id = item.id }, item);
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public IActionResult Update(int id, [FromBody]ProviderItem item)
        {
            if (item == null)
            {
                return BadRequest();
            }
            var provider = _context.ProviderItems.Where(x => x.id.Equals(id)).FirstOrDefault();
            if (provider == null)
            {
                return NotFound();
            }
            provider.address = item.address;
            provider.name = item.name;
            provider.email = item.email;
            provider.telefono = item.telefono;
            
            _context.ProviderItems.Update(provider);
            _context.SaveChanges();

            return new NoContentResult();

            
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
             var employee = _context.ProviderItems.Where(x => x.id.Equals(id)).FirstOrDefault();
            if (employee == null)
            {
                return NotFound();
            }
            _context.ProviderItems.Remove(employee);

            _context.SaveChanges();
            return new NoContentResult();
        }
    }
}
