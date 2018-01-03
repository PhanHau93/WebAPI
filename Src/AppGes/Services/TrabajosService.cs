using AppGes.Interfaces;
using AppGes.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace AppGes.Services
{
    public class TrabajosService : ITrabajos
    {
        private Context _context = new Context();
        public TrabajosService()
        {

        }
        public void Add(TrabajoItem trabajo)
        {
            if (_context.Trabajos.Count() > 0)
                            trabajo.Id = _context.Trabajos.Max(x => x.Id) + 1;
            else
                trabajo.Id = 1;

            _context.Trabajos.Add(trabajo);

            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            var item = _context.Trabajos.Where(x => x.Id.Equals(id)).FirstOrDefault();

            if (item != null)
                _context.Trabajos.Remove(item);

            _context.SaveChanges();
        }

        public IEnumerable<TrabajoItem> Get()
        {
            return _context.Trabajos;
        }

        public TrabajoItem Get(int id)
        {
            return _context.Trabajos.Where(x => x.Id.Equals(id)).FirstOrDefault();
        }

        public IEnumerable<TrabajoItem> GetByClientId(int clientId)
        {
            return _context.Trabajos.Where(x => x.Cliente.Id.Equals(clientId));
        }

        public void Update(TrabajoItem trabajo)
        {
            var item = _context.Trabajos.Find(trabajo.Id);

            if (item != null)
            {
                //item = trabajo;

                _context.Trabajos.Attach(trabajo);
                _context.Entry(trabajo).State = EntityState.Modified;
                _context.SaveChanges();

            }
            
            //_context.SaveChanges();
        }
    }
}
