using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace AutoRent
{
    public class AutoRent_Passport
    {
        public int ID { get; set; }
        public string Series { get; set; }
        public string Number { get; set; }
        public string IssuePlace { get; set; }


        [Column(TypeName = "date")]
        public DateTime IssueDate { get; set; }

    }
}
