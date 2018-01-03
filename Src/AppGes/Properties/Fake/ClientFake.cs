using AppGes.Interfaces;
using AppGes.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppGes.Fake
{
    public class ClientFake : IServicioCliente
    {
        private List<ClientItem> _clientes;
        public ClientFake()
        {
            string json = new StreamReader("clientes.json").ReadToEnd();
            _clientes = JsonConvert.DeserializeObject<List<ClientItem>>(json);
        }       
        
        public void addClient(ClientItem client)
        {
            client.Id = _clientes.Count() + 1;
            _clientes.Add(client);
        }

        public void deleteClient(int id)
        {
            var item = _clientes.Where(x => x.Id.Equals(id)).FirstOrDefault();

            _clientes.Remove(item);
           
        }

        public IEnumerable<ClientItem> getClient()
        {
            return _clientes;
        }

        public ClientItem getClientById(int id)
        {
            var item = _clientes.Where(x => x.Id.Equals(id)).FirstOrDefault();

            return item;

        }

        public void updateClient(ClientItem client)
        {
            var item = _clientes.Where(x => x.Id.Equals(client.Id)).FirstOrDefault();

            _clientes.Remove(item);

            client.Id = item.Id;

            
            _clientes.Add(client);
        }
    }
}
