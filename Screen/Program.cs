using System;

namespace Screen
{
    class Program
    {
        static void Main(string[] args)
        {
            Screen sc = new Screen();
            sc.Input();
            sc.Print();

            Console.ReadKey();
        }
    }
}
