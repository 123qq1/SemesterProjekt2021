using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace InputValidation
{
    public class Result
    {
        private bool error = false;
        private string type;
        private string message;


        public bool Error { get => this.error; set => this.error = value; }
        public string Type { get => this.type; set => this.type = value; }
        public string Message { get => this.message; set => this.message = value; }


        public Result() { }

        public Result(string type, string message)
        {
            this.error = true;
            this.type = type;
            this.Message = type + message;
        }
    }

    public static class StdErr
    {
        public static string regex = " does not match Regex resctrictions";
        public static string dig4 = " needs to be 4 digits long.";
        public static string lng = " is too long.";
        public static string blckList = " cannot contain character such as: \"<>*'{}:;-\" or newlines.";

        public static string length(int number, string type)
        {
            return $" needs to be exactly {number} {type} long.";
        }
    }

    public static class RegExes
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

        // Blacklist
        public static string name = @"([\n<>*'{}:;-]+)";
    }

    public static class Generic
    {
        public static Result ID(string input)
        {
            Regex reg = new Regex(RegExes.pureInt);
            Result r = null;
            string type = "Generic_ID";

            if (!reg.IsMatch(input))
                r = new Result(type, StdErr.regex);
            else
                r = new Result();

            return r;
        }

        public static Result Address(string input)
        {
            Regex reg = new Regex(RegExes.address);
            Result r = null;
            string type = "Generic_Address";

            if (!reg.IsMatch(input))
                r = new Result(type, StdErr.regex);
            else
                r = new Result();

            return r;
        }

        public static Result City(string input)
        {
            Regex reg = new Regex(RegExes.city);
            Result r = null;
            string type = "Generic_City";

            if (!reg.IsMatch(input))
                r = new Result(type, StdErr.regex);
            else
                r = new Result();

            return r;
        }

        public static Result Zip(string input)
        {
            Regex reg = new Regex(RegExes.pureInt);
            Result r = null;
            string type = "ZIP";

            if (!reg.IsMatch(input))
                r = new Result(type, StdErr.regex);

            else if (input.Length != 4)
                r = new Result(type, StdErr.dig4);

            else
                r = new Result();

            return r;
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
                }
            }

            return output;
        }

        public static Result Type(string input)
        {
            Regex reg = new Regex(RegExes.boligType);
            Result r = null;
            string type = "Type";

            if (!reg.IsMatch(input))
                r = new Result(type, StdErr.regex);

            else if (!checkTypes(input))
                r = new Result(type, " is not a known Bolig type");

            else
                r = new Result();

            return r;
        }

        public static Result Rooms(string input)
        {
            Regex reg = new Regex(RegExes.pureInt);
            Result r = null;
            string type = "Rooms";

            if (!reg.IsMatch(input))
                r = new Result(type, StdErr.regex);

            else if (input.Length > 3)
                r = new Result(type, StdErr.lng + "\nCannot excede 3 digits");

            else
                r = new Result();

            return r;
        }

        public static Result Area(string input)
        {
            Regex reg = new Regex(RegExes.pureInt);
            Result r = null;
            string type = "In/Out_Area";

            if (!reg.IsMatch(input))
                r = new Result(type, StdErr.regex);
            else
                r = new Result();

            return r;
        }

        public static Result EnergyLabel(string input)
        {
            Regex reg = new Regex(RegExes.energyLabel);
            Result r = null;
            string type = "EnergyLabel";

            if (!reg.IsMatch(input))
                r = new Result(type, StdErr.regex);

            else if (input.Length > 3)
                r = new Result(type, StdErr.lng + "\nCannot excede 3 characters.");

            else
                r = new Result();

            return r;
        }

        public static Result Built(string input)
        {
            Regex reg = new Regex(RegExes.pureInt);
            Result r = null;
            string type = "Built";

            if (!reg.IsMatch(input))
                r = new Result(type, StdErr.regex);
            else
            {
                if (input.Length != 4)
                    r = new Result(type, StdErr.lng + "\nCannot excede 3 characters.");
                else
                    r = new Result();
            }

            return r;
        }

        public static Result Price(string input)
        {
            Regex reg = new Regex(RegExes.pureInt);
            Result r = null;
            string type = "Price";

            if (!reg.IsMatch(input))
                r = new Result(type, StdErr.regex);
            else
                r = new Result();

            return r;
        }
    }

    public static class Person
    {
        public static Result Name(string input)
        {
            Regex reg = new Regex(RegExes.name);
            Result r = null;
            string type = "Person_Name";

            // This is a blacklist scenarie
            if (reg.IsMatch(input))
                r = new Result(type, StdErr.blckList);
            else
                r = new Result();

            return r;
        }

        public static Result CPR(string input)
        {
            Regex reg = new Regex(RegExes.pureInt);
            Result r = null;
            string type = "Person_CPR";

            if (!reg.IsMatch(input))
                r = new Result(type, StdErr.regex);
            else
            {
                if (input.Length != 10)
                    r = new Result(type, StdErr.length(10, "digits"));
                else
                    r = new Result();
            }

            return r;
        }

        public static Result PhoneNr(string input)
        {
            // aktuel
            Regex reg = new Regex(RegExes.pureInt);
            Result r = null;
            string type = "Person_PhoneNumber";

            if (!reg.IsMatch(input))
                r = new Result(type, StdErr.regex);
            else
                r = new Result();

            return r;
        }

        public static Result Email(string input)
        {
            Regex reg = new Regex(RegExes.email);
            Result r = null;
            string type = "Person_Email";

            if (!reg.IsMatch(input))
                r = new Result(type, StdErr.regex);
            else
                r = new Result();

            return r;
        }
    }
}
