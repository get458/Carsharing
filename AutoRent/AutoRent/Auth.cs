using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace AutoRent
{

    public class Auth
    {
        AuthWindow authWindow = new AuthWindow();


        public static bool ValidateCredentials(string login, string password)
        {
            return (login.Length > 0 && password.Length > 0);
        }

        public static bool Authorization(string login, string password, out int role)
        {
            int defaultRole = -1;
            using (Context context = new Context())
            {
                string passwordHash;
                using (MD5 md5 = MD5.Create())
                {
                    byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(password);
                    byte[] hashBytes = md5.ComputeHash(inputBytes);

                    passwordHash = Convert.ToHexString(hashBytes);
                }

                var users = context.autoRent_Users
                    .Where(u => u.Login == login)
                    .Where(u => u.Password == passwordHash)
                    .Select(
                        u => new
                        {
                            ID = u.ID,
                            Surname = u.Surname,
                            Name = u.Name,
                            LastName = u.Lastname,
                            RoleID = u.RoleID,
                            Login = u.Login,
                            Password = u.Password,
                            PhoneNumber = u.PhoneNumber,
                            DriverLicenseNumber = u.DriverLicenseNumber,
                            PassportID = u.PassportID
                        })
                    .ToList();
                if (users.Count == 1)
                {
                    role = (int)users[0].RoleID;
                    return true;
                }
            }
            role = defaultRole;
            return false;
        }
    }
}
