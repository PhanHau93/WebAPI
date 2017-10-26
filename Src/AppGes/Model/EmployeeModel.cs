using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace AppGes.Models
{
    public class EmployeeItem 
    {
        public int id { get; set; }
        public string name { get; set; }
        public string secondName { get; set; }
        public string address { get; set; }        
        public DateTime dateOfBird { get; set; }
        public DateTime startDate { get; set; }
        public DateTime? endDate { get; set; }

    }

    
}
