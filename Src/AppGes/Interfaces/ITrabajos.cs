using AppGes.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppGes.Interfaces
{
    public interface ITrabajos
    {
        IEnumerable<TrabajoItem> Get();
        IEnumerable<TrabajoItem> GetByClientId(int clientId);
        TrabajoItem Get(int id);        
        void Add(TrabajoItem trabajo);
        void Update(TrabajoItem trabajo);
        void Delete(int id);        
    }
}
