namespace AppGes.Models
{
    public class Factura
    {
        public int id { get; set; }
        public decimal Importe { get; set; }
        public decimal Cuenta { get; set; }
        public decimal Pendiente
        {
            get
            {
                return Importe - Cuenta;
            }
        }
        
        public int NFactura { get; set; }
    }
}