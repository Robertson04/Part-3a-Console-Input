using System;

namespace Part_3a_Console_Input
{
    class Program
    {
        static void Main(string[] args)
        {
            //Greetings

            int age;
            string name;
            DateTime now = DateTime.Today;
            int year = Convert.ToInt32(now.ToString("yyyy"));
          
            Console.WriteLine("Hello what is your name?");
            name = Console.ReadLine();
            Console.WriteLine($"Hello, {name}, how old are you?");
            age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Wow so you're {age} years old,");
            Console.WriteLine($"So your name is {name}, the year is currently {year}, you are {age} years old and you were born in {year - age}");

            //Adder

            int firstnumber;
            int secondnumber;
            int thirdnumber;
            Console.WriteLine("Please give me three numbers");
            firstnumber = Convert.ToInt32(Console.ReadLine());
            secondnumber =Convert.ToInt32(Console.ReadLine());
            thirdnumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"the total of the three number you entered is {firstnumber+ secondnumber + thirdnumber}");

            //Distance

            Double km1;
            Double km2;
            Double km3;
           
            Console.WriteLine("How many kilometers are there in 2000 meters");
            km1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("What is the distance betewen your house and the school in kilometers");
            km2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("How many kilometers would you be willing to walk for ice creem");
            km3 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"the average distance from your anwsers is {Math.Round((km1 + km2 + km3) / 3, 2)} kilometers");
        }
    }
}
