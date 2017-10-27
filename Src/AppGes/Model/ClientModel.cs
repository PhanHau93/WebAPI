using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace AppGes.Models
{
    public class ClientItem 
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public string NIF { get; set; }
        public string Direccion { get; set; }  
        public string Localidad { get; set; }
        public string Email { get; set; }
        public int Telefono { get; set; }   
        public int CP { get; set; }      
        public string Observaciones { get; set; }

    }

    
}
