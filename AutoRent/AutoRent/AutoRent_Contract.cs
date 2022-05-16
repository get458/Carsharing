using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace AutoRent
{
    public class AutoRent_Contract
    {
        public int ID { get; set; }
        public int UserID { get; set; }
        [ForeignKey("UserID")]
        public AutoRent_User? AutoRent_User { get; set; }
        public int CarID { get; set; }
        [ForeignKey("CarID")]
        public AutoRent_Car? AutoRent_Car { get; set; }

        [Column(TypeName = "date")]
        public DateTime StartDate { get; set; }

        [Column(TypeName = "date")]
        public DateTime FinishDate { get; set; }


        public decimal ContractPrice { get; set; }
        public int? DeliveryAddressID { get; set; }
        [ForeignKey("DeliveryAddressID")]
        public AutoRent_DeliveryAddress? AutoRent_DeliveryAddress { get; set; }

    }
}
