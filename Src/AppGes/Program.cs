using AppGes.Formularios;
using AppGes.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace AppGes
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
#if DEBUG
            CrearClientes();
            CrearTrabajos();
#endif

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new TrabajosForm());


        }

        private static void CrearTrabajos()
        {
            if (!File.Exists("trabajos.json"))
            {
                List<ClientItem> _clientes = new List<ClientItem>();
                _clientes.Add(new ClientItem() { Id = 1, Nombre = "Antonio", Direccion = "Calle de Aquí", Localidad = "Málaga", Email = "a@a.com", Apellidos = "Apellido", Telefono = 666006660 });
                _clientes.Add(new ClientItem() { Id = 2, Nombre = "Paco", Direccion = "Calle de Aquí", Localidad = "Málaga", Email = "a@a.com", Apellidos = "Apellido", Telefono = 666006660 });
                _clientes.Add(new ClientItem() { Id = 3, Nombre = "Pepe", Direccion = "Calle de Aquí", Localidad = "Málaga", Email = "a@a.com", Apellidos = "Apellido", Telefono = 666006660 });
                _clientes.Add(new ClientItem() { Id = 4, Nombre = "Luis", Direccion = "Calle de Aquí", Localidad = "Málaga", Email = "a@a.com", Apellidos = "Apellido", Telefono = 666006660 });
                _clientes.Add(new ClientItem() { Id = 5, Nombre = "Alberto", Direccion = "Calle de Aquí", Localidad = "Málaga", Email = "a@a.com", Apellidos = "Apellido", Telefono = 666006660 });

                List<TrabajoItem> _trabajos = new List<TrabajoItem>();
                int id = 0;
                foreach (ClientItem c in _clientes)
                {
                    List<Factura> facturas = new List<Factura>();
                    facturas.Add(new Factura() { id = id, Cuenta = 100, Importe = 150, NFactura = 1309844 });
                    _trabajos.Add(new TrabajoItem()
                    {
                        Cliente = c,
                        FechaEntrada = DateTime.Now,
                        FechaEntrega = DateTime.Now.AddDays(4).AddMonths(3),
                        Finalizado = false,
                        Id = id,
                        Observaciones = "Carga Inicial",
                        Facturas = facturas,
                        NPresupuesto = 2324359
                    });
                    id++;
                }

                StreamWriter swTR = new StreamWriter("trabajos.json");
                swTR.WriteLine(JsonConvert.SerializeObject(_trabajos));
                swTR.Close();
            }

        }

        private static void CrearClientes()
        {
            List<ClientItem> _clientes = new List<ClientItem>();
            _clientes.Add(new ClientItem() { Id = 1, Nombre = "Antonio", Direccion = "Calle de Aquí", Localidad = "Málaga", Email = "a@a.com", Apellidos = "Apellido", Telefono = 666006660 });
            _clientes.Add(new ClientItem() { Id = 2, Nombre = "Paco", Direccion = "Calle de Aquí", Localidad = "Málaga", Email = "a@a.com", Apellidos = "Apellido", Telefono = 666006660 });
            _clientes.Add(new ClientItem() { Id = 3, Nombre = "Pepe", Direccion = "Calle de Aquí", Localidad = "Málaga", Email = "a@a.com", Apellidos = "Apellido", Telefono = 666006660 });
            _clientes.Add(new ClientItem() { Id = 4, Nombre = "Luis", Direccion = "Calle de Aquí", Localidad = "Málaga", Email = "a@a.com", Apellidos = "Apellido", Telefono = 666006660 });
            _clientes.Add(new ClientItem() { Id = 5, Nombre = "Alberto", Direccion = "Calle de Aquí", Localidad = "Málaga", Email = "a@a.com", Apellidos = "Apellido", Telefono = 666006660 });

            if (!File.Exists("clientes.json"))
            {
                StreamWriter swCl = new StreamWriter("clientes.json");
                swCl.Write(JsonConvert.SerializeObject(_clientes));
                swCl.Close();
            }
        }
    }
}
