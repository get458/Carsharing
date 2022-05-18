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

        public static int GetUserID(string login)
        {
            int userID;

            using (Context context = new Context())
            {

                var user = context.autoRent_Users.Where(u => u.Login == login).Select(u => new { userID = u.ID }).ToList();
                return userID = user.First().userID;

            }
        }

        public static List<AutoRent_Contract> GetContractInformation(int userID)
        {
            using (Context context = new Context())
            {

                var contractInfo = context.autoRent_Contracts.Where(c => c.UserID == userID).ToList();
                return contractInfo;

            }
        }

        public static string GetCar(int carID)
        {
            string? carName;
            using (Context context = new Context())
            {
                carName = context.autoRent_Cars.Where(c => c.ID == carID).Select(c => new { carName = c.Name }).ToString();
                return carName;
            }
        }

    }
}
