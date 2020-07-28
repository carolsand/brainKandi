using System;
using System.Text;

namespace SchoolLibrary
{
    public class School
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
        public string PhoneNumber { get; set; }


        /* Creating Methods */
        private string _twitterAddress;
        public string TwitterAddress
        {
            // make sure the twitter address starts with an @
            get { return _twitterAddress; }
            set
            {
                if (value.StartsWith("@"))
                {
                    _twitterAddress = value;
                } else
                {
                    throw new Exception("The Twitter address must begin with an @");
                }
            }
        }

        /* Constructors: Do not return a value. Run immediately when an object is instantiated. 
         * Define initial value for fields defined in class. Can have as many as required. Named */

        public School()
        {
            // no return type because constructors dont return anything
            Name = "Untitled School";
            PhoneNumber = "555-1234";
        }

        public School(string SchoolName, string SchoolPhoneNumber)
        {
            Name = SchoolName;
            PhoneNumber = SchoolPhoneNumber;
        }

        public float AverageThreeScores(float a, float b, float c)
        {
            var result = (a + b + c) / 3;
            return result;
        }

        /* Static Methods: Functions you can use without instantiating the class. 
         Example Math functions from the math library are static functions */

        public static int AverageThreeScores(int a, int b, int c)
        {
            var result = (a + b + c) / 3;
            return result;
        }

        /* Function Bodied Expression otherwise know as arrow functions. 
         * The arrow points to the return value - type in what you want to return. Supports simple expressions */

        public static float AverageThreeScores(long a, long b, long c) => (a + b + c) / 3;

        /* Overriding ToString method */
        public override string ToString()
        {
            var sb = new StringBuilder();

            sb.AppendLine(this.Name);
            sb.AppendLine(this.Address);
            sb.AppendLine(this.City);
            sb.AppendLine(this.State);
            sb.AppendLine(" ");
            sb.AppendLine(Zip);
            sb.AppendLine("  ");


            return sb.ToString();
        }
    }
}
