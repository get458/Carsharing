using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoRent
{
    public class GetInf
    {

         public static List<AutoRent_User> GetUserInformation(int id)
         {
             using (Context context = new Context())
             {
                var userInf = context.autoRent_Users.Where(u => u.ID == id).ToList();
                return userInf;
             }
         }

        public static List<AutoRent_User> GetUsersInformation()
        {
            using (Context context = new Context())
            {
                var usersInf = context.autoRent_Users.Where(u => u.RoleID != 1).ToList();
                return usersInf;
            }
        }

        public static List<AutoRent_Car> GetCarInformation()
        {
            using (Context context = new Context())
            {

                var carInf = context.autoRent_Cars.
                    Select()

            }
        }

    }
}
