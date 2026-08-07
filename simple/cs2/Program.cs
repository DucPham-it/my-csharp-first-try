using System;

namespace CS2
{
    class CS2learning {
        static void Main(string[] args)
        {
            Console.Title = "CS2";
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("hello");
            Console.ResetColor();
            Console.WriteLine(18812*2);

            string hoten;
            hoten = Console.ReadLine().Trim();
            Console.WriteLine(hoten);

            int a, b;
            string temp;
            temp = Console.ReadLine().Trim();
            a = int.Parse(temp);
            temp = Console.ReadLine().Trim();
            b = Convert.ToInt32(temp);

            Console.WriteLine("So a = {0}, b = {1}", a, b);

        }}
}