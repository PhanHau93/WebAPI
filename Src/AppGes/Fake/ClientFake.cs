using AppGes.Interfaces;
using AppGes.Models;
using System;
using System.Collections.Generic;
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
            _clientes = new List<ClientItem>();
            _clientes.Add(new ClientItem() { Id = 1, Nombre = "Antonio", Direccion = "Calle de Aquí", Localidad = "Málaga", Email = "a@a.com", Apellidos = "Apellido", Telefono = 666006660 });
            _clientes.Add(new ClientItem() { Id = 2, Nombre = "Paco", Direccion = "Calle de Aquí", Localidad = "Málaga", Email = "a@a.com", Apellidos = "Apellido", Telefono = 666006660 });
            _clientes.Add(new ClientItem() { Id = 3, Nombre = "Pepe", Direccion = "Calle de Aquí", Localidad = "Málaga", Email = "a@a.com", Apellidos = "Apellido", Telefono = 666006660 });
            _clientes.Add(new ClientItem() { Id = 4, Nombre = "Luis", Direccion = "Calle de Aquí", Localidad = "Málaga", Email = "a@a.com", Apellidos = "Apellido", Telefono = 666006660 });
            _clientes.Add(new ClientItem() { Id = 5, Nombre = "Alberto", Direccion = "Calle de Aquí", Localidad = "Málaga", Email = "a@a.com", Apellidos = "Apellido", Telefono = 666006660 });

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
