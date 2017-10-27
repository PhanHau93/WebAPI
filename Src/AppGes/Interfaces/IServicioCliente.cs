using AppGes.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppGes.Interfaces
{
    public interface IServicioCliente
    {
        IEnumerable<ClientItem> getClient();
        ClientItem getClientById(int id);
        void addClient(ClientItem client);
        void updateClient(ClientItem client);
        void deleteClient(int id);

    }
}
