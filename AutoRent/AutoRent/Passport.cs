using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace AutoRent
{
    public class Passport
    {
        PassportWindow passportWindow = new PassportWindow();

        public static bool ValidateCredentials(string series, string number, string issueplace, string issuedate)
        {
            return (series.Length > 0 && number.Length > 0 && issueplace.Length > 0 && issuedate.ToString().Length > 0);
        }

        public static bool AddPasport(string series, string number, string issueplace, DateTime issuedate)
        {
            using (Context context = new Context())
            {
                var passportCheck = context.autoRent_Passports
                    .Where(p => p.Series == series)
                    .Where(p => p.Number == number)
                    .Select(
                        p => new
                        {
                            passportID = p.ID
                        })
                    .ToList();

                if (passportCheck.Count == 0)
                {
                    var passports = context.Set<AutoRent_Passport>();
                    passports.Add(new AutoRent_Passport { Series = series, Number = number, IssuePlace = issueplace, IssueDate = issuedate });
                    context.SaveChanges();
                }
                else
                {
                    MessageBox.Show("Данный паспорт имеется в базе данных.");
                }
            }
            return true;
        }

        public static int GetPassportID(string series, string number)
        {
            int passportID;

            using (Context context = new Context())
            {

                var passports = context.autoRent_Passports
                    .Where(p => p.Series == series)
                    .Where(p => p.Number == number)
                    .Select(
                        p => new
                        {
                            passportID = p.ID
                        })
                    .ToList();

                return passportID = passports.First().passportID;
            }
        }
    }
}
