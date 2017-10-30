using AppGes.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppGes.Models
{
    public class TrabajoItem
    {
        public int Id { get; set; }
        public ClientItem Cliente { get; set; }
        public DateTime? FechaEntrada { get; set; }
        public DateTime? FechaEntrega { get; set; }
        public List<Factura> Facturas { get; set; }       
        public int NPresupuesto { get; set; }        
        public string Observaciones { get; set; }
        public DateTime? FechaReal { get; set; }
        public bool Finalizado { get; set; }
    }

    public class TrabajosSource
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public int Presupuesto { get; set; }
        public string FechaEntrada { get; set; }
        public string FechaEntrega { get; set; }
        public decimal Total { get; set; }
        public decimal Cuenta { get; set; }
        public decimal Pendiente
        {
            get
            {
                return Total - Cuenta;
            }
        }
        public bool Finalizado { get; set; }
        
        public int Factura { get; set; }

        public static TrabajosSource convertToItem(TrabajoItem item)
        {
            return new TrabajosSource() {
                Id = item.Id,
                Apellidos = item.Cliente.Apellidos,
                Nombre = item.Cliente.Nombre,
                Cuenta = item.Facturas.Count > 0 ? item.Facturas.Sum(x => x.Cuenta) : 0,
                //Factura = item.NFactura,
                FechaEntrada = item.FechaEntrada.HasValue ? item.FechaEntrada.Value.ToShortDateString() : string.Empty,
                FechaEntrega = item.FechaEntrega.HasValue ? item.FechaEntrega.Value.ToShortDateString() : string.Empty,
                Finalizado = item.Finalizado,
                Presupuesto = item.NPresupuesto,
                Total = item.Facturas.Count > 0 ? item.Facturas.Sum(x => x.Importe) : 0   
            };
        }

    }
}
