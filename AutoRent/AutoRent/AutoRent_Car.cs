using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace AutoRent
{
    public class AutoRent_Car
    {
        public int ID { get; set; }
        public int Name { get; set; }
        public decimal PriceForContract { get; set; }
        public int? TypeID { get; set; }
        [ForeignKey("TypeID")]
        public AutoRent_Type? AutoRent_Type { get; set; }
        public int? FuelID { get; set; }
        [ForeignKey("FuelID")]
        public AutoRent_Fuel? AutoRent_Fuel { get; set; }
        public int TransmissionID { get; set; }
        [ForeignKey("TransmissionID")]
        public AutoRent_Transmission? AutoRent_Transmission { get; set;
        }
    }
}
