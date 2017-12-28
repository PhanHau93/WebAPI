using AppGes.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppGes.Models;

namespace AppGes.Services
{
    public class ServicioCliente : IServicioCliente
    {
        private Context _context = new Context();
        public ServicioCliente()
        {

        }
        public void addClient(ClientItem client)
        {
            if (_context.Clients.Count() > 0)
                client.Id = _context.Clients.Max(x => client.Id) + 1;
            else
                client.Id = 1;

            var item = _context.Clients.Add(client);

            _context.SaveChanges();
        }

        public void deleteClient(int id)
        {
            var item = _context.Clients.Where(x => x.Id.Equals(id)).FirstOrDefault();

           if(item != null)
                _context.Clients.Remove(item);

            _context.SaveChanges();
        }

        public IEnumerable<ClientItem> getClient()
        {
            return _context.Clients;
        }

        public ClientItem getClientById(int id)
        {
            var item = _context.Clients.Where(x => x.Id.Equals(id)).FirstOrDefault();

            return item;

        }

        public void updateClient(ClientItem client)
        {
            var item = _context.Clients.Where(x => x.Id.Equals(client.Id)).FirstOrDefault();

            _context.Clients.Remove(item);

            client.Id = item.Id;

            _context.Clients.Add(client);

            _context.SaveChanges();

        }
      
    }
}
