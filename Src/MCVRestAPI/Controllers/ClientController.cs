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
    public class ClientController : Controller
    {
        private readonly ApplicationContext _context;
        public ClientController(ApplicationContext context)
        {
            _context = context;
            
            if (_context.ClientItems.Count() == 0)
            {
                _context.ClientItems.Add(new ClientItem {
                    name = "Nombre",
                    address = "Direccion",
                    secondName = "Apellido",
                    email = "Email",
                    telefono = "Telefono"
                    });
                _context.SaveChangesAsync();
            }
        }
        // GET: api/values
        [HttpGet]
        public IEnumerable<ClientItem> Get()
        {
            return _context.ClientItems;
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
        [HttpGet("{id}", Name ="GetClient")]
        public IActionResult GetEmployeeById(int id)
        {
            var item = _context.ClientItems.Where(emp => emp.id.Equals(id)).FirstOrDefault();
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
        public IActionResult Create([FromBody]ClientItem item)
        {
            if (item == null)
            {
                return BadRequest();
            }
            _context.ClientItems.Add(item);
            _context.SaveChangesAsync();

            return CreatedAtRoute("GetClient", new { id = item.id }, item);
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public IActionResult Update(int id, [FromBody]ClientItem item)
        {
            if (item == null)
            {
                return BadRequest();
            }
            var employee = _context.ClientItems.Where(x => x.id.Equals(id)).FirstOrDefault();
            if (employee == null)
            {
                return NotFound();
            }
            employee.address = item.address;
            employee.name = item.name;

            _context.ClientItems.Update(employee);
            _context.SaveChanges();

            return new NoContentResult();

            
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
             var employee = _context.ClientItems.Where(x => x.id.Equals(id)).FirstOrDefault();
            if (employee == null)
            {
                return NotFound();
            }
            _context.ClientItems.Remove(employee);

            _context.SaveChanges();
            return new NoContentResult();
        }
    }
}
