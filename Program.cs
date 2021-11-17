using System;

namespace ConsoleApp6_OOP_C2
{
    //internal class Program
    internal class Account
    {
        private static void Main(string[] args)
        { }


        public string clientName;
        private uint accountNumber;
        private double procent;
        private double amount;

        public Account(string clientName, uint accountNumber, double procent, double amount)
        {
            this.clientName = clientName;
            this.accountNumber = accountNumber;
            this.procent = procent;
            this.amount = amount;
        }

        private void Name(string name) // Имя клиента
        {
            while (string.IsNullOrWhiteSpace(clientName))
            {
                Console.Write("Введите ваше имя: ");

                clientName = Console.ReadLine();

            }
            void Number(uint number) // Номер счёта
            {
                Console.WriteLine("Ведите номер счёта: ");
                while (!uint.TryParse(Console.ReadLine(), out number))

                {

                    accountNumber = number;

                }

            }
            void Procent(double proc) // Процент начисления
            {
                Console.WriteLine("Процент от начисления составит: ");
                while (!double.TryParse(Console.ReadLine(), out proc))

                {

                    procent = proc;
                }

            }
            void Amount(double summa) // Баланс счёта
            {

                Console.WriteLine("Баланс счёта составляет: ");
                while (!double.TryParse(Console.ReadLine(), out summa))

                {

                    amount = summa;
                }

            }
        }
    }
}
