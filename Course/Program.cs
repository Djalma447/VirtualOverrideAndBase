using System;
using Course.Entities;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            Account acc1 = new Account(1001, "Silvio", 500.0);
            Account acc2 = new SavingsAccount(1002, "Beto", 500.0, 0.05);

            acc1.WithDraw(50.0);
            acc2.WithDraw(50.0);

            Console.WriteLine(acc1.Balance);
            Console.WriteLine(acc2.Balance);
        }
    }
}
