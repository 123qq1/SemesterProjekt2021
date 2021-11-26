using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace InputValidation
{
    public static class Validate
    {
        private static class RegExes
        {
            // Primary types
            public static string pureInt = @"(?!\s*$)([0-9]+$)";
            public static string pureDouble = @"(?!\s*$)(^[0-9,]*)";

            // Generic
            public static string address = @"(?!\s*$)(^(?:[A-Øa-ø.]+[ ])+)([\d., A-Za-z]+)";
            public static string city = @"(?!\s*$)(^[A-Ø a-ø.]+)([A-Ø a-ø.]+$)";

            // Bolig
            public static string boligType = @"(?!\s*$)(^[A-Ø a-ø.]+)([A-Øa-ø]+$)";
            public static string energyLabel = @"(?!\s*$)([A-F])([+]?){1,2}$";

            // Person
            public static string cpr = @"(?!\s*$)^(([\d][\d][\d][\d][\d][\d])([ -])?([\d][\d][\d][\d]))";
            public static string phoneNr = @"(?!\s)^(((?:[+][\d]?[\d]?[\d][ ]?)|(?:[\d][\d][\d][\d][ ]))?([(][\d]+[)][ ]?)?((?:(?:[\d]+[ -]?))+))";
            public static string email = @"(?!\s*$)(?:^[a-z0-9!#$%&'*+/=?^_`{|}~-]+)@(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+).(?:[a-z]+$)";

        }

        public static class Generic
        {
            public static bool Address(string input)
            {
                Regex reg = new Regex(RegExes.address);
                bool output = true;

                if (!reg.IsMatch(input)) output = false;

                return output;
            }

            public static bool City(string input)
            {
                Regex reg = new Regex(RegExes.city);
                bool output = true;

                if (!reg.IsMatch(input)) output = false;

                return output;
            }

            public static bool Zip(string input, ref int container)
            {
                Regex reg = new Regex(RegExes.pureInt);
                bool output = false;

                if (!reg.IsMatch(input)) output = false;
                if (input.Length != 4) output = false;

                return output;
            }
        }

        public static class Bolig
        {
            private static string[] types = { 
                "enfamiliehus",
                "sommerhus",
                "ejerlejlighed",
                "ideel anpart",
                "andelsbolig",
                "lejlighed",
            };

            private static bool checkTypes(string input)
            {
                bool output = false;

                foreach (string type in types)
                {
                    if (input == type)
                    {
                        output = true;
                        break;
                    }
                }

                return output;
            }

            public static bool Type(string input)
            {
                Regex reg = new Regex(RegExes.boligType);
                bool output = true;

                if (!reg.IsMatch(input)) output = false;
                if (checkTypes(input)) output = false;

                return output;
            }

            public static bool Rooms(string input, ref int container)
            {
                Regex reg = new Regex(RegExes.pureInt);
                bool output = false;

                if (!reg.IsMatch(input)) output = false;
                if (input.Length > 3) output = false;

                return output;
            }

            public static bool InArea(string input, ref int container)
            {
                Regex reg = new Regex(RegExes.pureInt);
                bool output = false;

                if (!reg.IsMatch(input)) output = false;

                return output;
            }

            public static bool OutArea(string input, ref int container)
            {
                Regex reg = new Regex(RegExes.pureInt);

                bool output = false;

                if (!reg.IsMatch(input)) output = false;

                return output;
            }

            public static bool EnergyLabel(string input)
            {
                Regex reg = new Regex(RegExes.energyLabel);
                bool output = false;

                if (!reg.IsMatch(input)) output = false;
                if (input.Length > 3) output = false;

                return output;
            }

            public static bool Built(string input, ref int container)
            {
                Regex reg = new Regex(RegExes.pureInt);
                bool output = false;

                if (!reg.IsMatch(input)) output = false;
                if (input.Length != 4) output = false;

                return output;
            }

            public static bool Price(string input, ref int container)
            {
                Regex reg = new Regex(RegExes.pureInt);
                bool output = false;

                if (!reg.IsMatch(input)) output = false;

                return output;
            }
        }

        public static class Person
        {
            public static bool CPR(string input)
            {
                Regex reg = new Regex(RegExes.pureInt);
                bool output = false;

                if (!reg.IsMatch(input)) output = false;
                if (input.Length != 10) output = false;

                return output;
            }

            public static bool PhoneNr(string input)
            {
                Regex reg = new Regex(RegExes.pureInt);
                bool output = false;

                if (!reg.IsMatch(input)) output = false;

                return output;
            }

            public static bool Email(string input)
            {
                Regex reg = new Regex(RegExes.email);
                bool output = false;

                if (!reg.IsMatch(input)) output = false;

                return output;
            }
        }
    }
}
