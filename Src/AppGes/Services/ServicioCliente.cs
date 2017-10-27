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
            _context.Clients.Add(client);            
        }

        public void deleteClient(int id)
        {
            var item = _context.Clients.Where(x => x.Id.Equals(id)).FirstOrDefault();

           if(item != null)
                _context.Clients.Remove(item);
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

            client.Id = item.Id;

            _context.Clients.Remove(client);
            _context.Clients.Add(client);
        }
      
    }
}
