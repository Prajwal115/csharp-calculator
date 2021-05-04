using System;
namespace Calculator
{

    class Calculor
    {

        public static void Main()
        {

            Console.WriteLine("Welcome to the calculator , This is Prajwal . '\n' Here you have to enter the following for the operations applicable to 2 numbers .'\n' For Addition - Enter SUM .'\n' For Division - Enter DIV .'\n' For Subtraction - Enter SUB.'\n' For Multiplication - Enter MUL.");
            string first = Convert.ToString(Console.ReadLine());
            if (first == "MUL")
            {
                Console.WriteLine("Enter the first number - you want to multiply");
                int a = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter the second number - you want to multiply");
                int b = Convert.ToInt32(Console.ReadLine());
                int c = a * b;
                Console.WriteLine($"The Product of Numbers you entered : {c}");
            }
            if (first == "DIV")
            {
                Console.WriteLine("Enter the DIVIDEND");
                int aa = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter the DIVISOR");
                int bb = Convert.ToInt32(Console.ReadLine());
                int cc = aa / bb;
                int dd = aa % bb;
                Console.WriteLine($"The Quotient is {cc} and the Remainder is {dd}");
            }
            if (first == "SUM")
            {
                Console.WriteLine("Enter the First Number to Sum");
                int sa = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter the Second Number to Sum");
                int sb = Convert.ToInt32(Console.ReadLine());
                int sc = sa + sb;
                Console.WriteLine($"The Sum of numbers you entered is {sc}");
            }
            if (first == "SUB")
            {
                Console.WriteLine("Enter the number you want to SUBTRACT FROM");
                int ba = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter the nummer you want to SUBTRACT");
                int ca = Convert.ToInt32(Console.ReadLine());
                int da = ba - ca;
                Console.WriteLine($"The Difference is {da}");
            
            }
            
        }


    }

}
