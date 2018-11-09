using System;

namespace task_3
{
    class Program
    {
        static void Main()
        {
            decimal number1 = 5.25745243896m;
            decimal number2 = 9.8544531763m;
            number1 += number2;
            Console.WriteLine(number1.ToString("#.######"));
        }
    }
}
