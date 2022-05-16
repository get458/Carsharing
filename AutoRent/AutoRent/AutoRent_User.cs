using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace AutoRent
{
    public class AutoRent_User
    {
        public int ID { get; set; }
        public string Surname { get; set; }
        public string Name { get; set; }
        public string Lastname { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public string PhoneNumber { get; set; }
        public string DriverLicenseNumber { get; set; }
        public int? RoleID { get; set; }
        [ForeignKey("RoleID")]
        public AutoRent_Role? AutoRent_Role { get; set; }
        public int? PassportID { get; set; }
        [ForeignKey("PassportID")]
        public AutoRent_Passport? AutoRent_Passport { get; set; }
    }
}
