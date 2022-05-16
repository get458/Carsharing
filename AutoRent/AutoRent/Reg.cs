using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoRent
{
    public class Reg
    {
        RegWindow regWindow = new RegWindow();
        PassportWindow passportWindow = new PassportWindow();

        public static bool ValidateCredentials(string surname, string name, string lastname, string login, string password, string phonenumber, string driverlicense)
        {
            return (surname.Length > 0 && name.Length > 0 && lastname.Length > 0 && login.Length > 0 && password.Length > 0 && phonenumber.Length > 0 && driverlicense.Length > 0);
        }

        public static bool Registration(string surname, string name, string lastname, string login, string password, string phonenumber, string driverlicense, int passportId)
        {
            int defaultRole = 2;
            using (Context context = new Context())
            {
                string passwordHash;
                using (System.Security.Cryptography.MD5 md5 = System.Security.Cryptography.MD5.Create())
                {
                    byte[] inputBytes = Encoding.ASCII.GetBytes(password);
                    byte[] hashBytes = md5.ComputeHash(inputBytes);

                    passwordHash = Convert.ToHexString(hashBytes);
                }

                var users = context.Set<AutoRent_User>();
                users.Add(new AutoRent_User { Surname = surname, Name = name, Lastname = lastname, Login = login, Password = passwordHash, PhoneNumber = phonenumber, DriverLicenseNumber = driverlicense, RoleID = defaultRole, PassportID = passportId });
                context.SaveChanges();
            }
            return true;
        }

    }
}
