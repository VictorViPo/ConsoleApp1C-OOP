using System;

namespace ConsoleApp2_OOP_C3
{
    class Program
    {
        private static string schet1;
        private static string schet2;

        static void Main(string[] args)
        {

            while (string.IsNullOrWhiteSpace(schet1))
            {
                Console.WriteLine("Введите номер счета с какого перевести средства   ");
                schet1 = Console.ReadLine();
            }

            while (string.IsNullOrWhiteSpace(schet2))
            {
                Console.WriteLine("Введите номер счета на какого перевести средства   ");
                schet2 = Console.ReadLine();
            }
        }
    }
}

