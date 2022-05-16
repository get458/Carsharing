using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace AutoRent
{
    public class Context : DbContext
    {
        public Context() : base("DbConnection")
        { }

        public DbSet<AutoRent_Passport> autoRent_Passports { get; set; }
        public DbSet<AutoRent_Role> autoRent_Roles { get; set; }
        public DbSet<AutoRent_Contract> autoRent_Contracts { get; set; }
        public DbSet<AutoRent_DeliveryAddress > autoRent_DeliveryAddresses { get; set; }
        public DbSet<AutoRent_User > autoRent_Users { get; set; }
        public DbSet<AutoRent_Car> autoRent_Cars { get; set; }
        public DbSet<AutoRent_Transmission> autoRent_Transmissions { get; set; }
        public DbSet<AutoRent_Type> autoRent_Types { get; set; }
        public DbSet<AutoRent_Fuel> autoRent_Fuels { get; set; }
    }
}
