using System;
using System.Text;

namespace practice_learing_csharp
{
    class MainClass
    {
        public static void Main(string[] args) { 
            Console.WriteLine("Hello World!");
            string mywords = Console.ReadLine();
            mywords.Trim();
            mywords.ToUpper();

            var myNewWord = 34;
            myNewWord.CompareTo(45);

            var challenge = "  Text prcessing in c# is really great!   ";
            challenge.Trim().Substring(24, challenge.Trim().Length - 25).ToUpper().Trim();

            //string builder versus string concatenation
            var sb = new StringBuilder();
            sb.Append("It was the best of times, it was the worst of times");
            sb.Append("It was the age of wisdom.");
            sb.Append("It was the age of foolishness.");
            sb.ToString();  // converts 

            var sb1 = new StringBuilder("It was the best of times, it was the worst of times");
            sb1.AppendLine("It was the age of wisdom.");
            sb1.AppendLine("It was the age of foolishness.");

            Console.WriteLine(mywords);
            Console.WriteLine(sb);
            Console.WriteLine(sb1);


            var city = "San Francisco";
            var temperature = 75.4f;
            var currentDt = DateTime.Now;
            Console.WriteLine(string.Format("Welcome to {0}. The time is {1:t}. The temperature is {2:0.00}. ", city, currentDt, temperature));

            // Parsing Strings
            var testStringNum = "15,234";
            Console.WriteLine(int.Parse(testStringNum.Replace(",", "")));

            int myResult;
            Console.WriteLine(int.TryParse("15,234", out myResult));  // Answer should be False
            Console.WriteLine(int.TryParse("15234", out myResult));   // Answer should be True
            Console.WriteLine(myResult);

            // Math in CSharp
            Console.WriteLine(Math.Abs(-35.678));
            Console.WriteLine(Math.Acos(35));
            Console.WriteLine(Math.Asin(35));
            Console.WriteLine(Math.PI);
            Console.WriteLine(5 + 5);
            Console.WriteLine(5 % 2);
            Console.WriteLine(25 / 5);
            var test = 5;
            test += 5;
            Console.WriteLine(test);
            test -= 3;
            Console.WriteLine(test);
            // Using Constants
            const float pi = 3.14f;
            Console.WriteLine(pi);
            //enum weekDays { Monday, Tuesday, Wednesday, Thursday, Friday, Saturday, Sunday };
            // var someDay = weekDays.Monday;
            // enum weekDays { Monday = 1, Tuesday, Wednesday, Thursday } ; // Assigning Monday to first index or 1
            // var someDay = weekDays.Wednesday


            // Dates and Times
            Console.WriteLine(DateTime.Now);
            var birthday = new DateTime(1965, 3, 22 );
            var difference = DateTime.Now - birthday;
            Console.WriteLine(difference);
            Console.WriteLine(difference.Days);
            Console.WriteLine(difference.Days / 365);
            Console.WriteLine(DateTime.Now);
            var someTime = new DateTime(2020, 7, 17, 11, 47, 56) ;
            Console.WriteLine(someTime.AddMinutes(134));
            Console.WriteLine(someTime.TimeOfDay );
        }
    }
}
