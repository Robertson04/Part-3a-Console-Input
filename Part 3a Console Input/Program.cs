using System;

namespace Part_3a_Console_Input
{
    class Program
    {
        static void Main(string[] args)
        {
            //Greetings;

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
            Console.WriteLine("Enter the first number");
            firstnumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter a second number");
            secondnumber =Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter a third number");
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

            //Hypotenuse

            double side1;
            double side2;
            double side3;
            Console.WriteLine("Please give me the two sides of a triangle");
            Console.WriteLine("Enter the first side");
            side1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the second side");
            side2 = Convert.ToDouble(Console.ReadLine());
            side3 = (side1*side1) + (side2*side2);
            Console.WriteLine($"The hypotenuse of the triangle is {Math.Round((Math.Sqrt(side3)), 2)}cm");
        }
    }
}
