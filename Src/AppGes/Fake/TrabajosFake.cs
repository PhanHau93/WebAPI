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
    public class TrabajosFake : ITrabajos
    {
        //private Context _context = new Context();
        private List<TrabajoItem> trabajos;

        public TrabajosFake()
        {
            trabajos = new List<TrabajoItem>();
            string json = new StreamReader("trabajos.json").ReadToEnd();
            trabajos = JsonConvert.DeserializeObject<List<TrabajoItem>>(json);
        }
        public void Add(TrabajoItem trabajo)
        {
            if (trabajos.Count() > 0)
                trabajo.Id = trabajos.Max(x => x.Id) + 1;
            else
                trabajo.Id = 1;

            trabajos.Add(trabajo);

        }

        public void Delete(int id)
        {
            var item = trabajos.Where(x => x.Id.Equals(id)).FirstOrDefault();

            if (item != null)
                trabajos.Remove(item);
        }

        public IEnumerable<TrabajoItem> Get()
        {
            return trabajos;
        }

        public TrabajoItem Get(int id)
        {
            return trabajos.Where(x => x.Id.Equals(id)).FirstOrDefault();
        }

        public IEnumerable<TrabajoItem> GetByClientId(int clientId)
        {
            return trabajos.Where(x => x.Cliente.Id.Equals(clientId));
        }

        public void Update(TrabajoItem trabajo)
        {
            var item = trabajos.Where(x => x.Id.Equals(trabajo.Id)).FirstOrDefault();

            trabajos.Remove(item);

            trabajo.Id = item.Id;

            trabajos.Add(trabajo);
        }
    }
}
