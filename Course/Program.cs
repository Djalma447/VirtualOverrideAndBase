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

            acc1.WithDraw(50.0); // Fazendo saque da Conta Comum
            acc2.WithDraw(50.0); // Fazendo saque da Conta Poupança

            Console.WriteLine(acc1.Balance); // Valor do Saldo após o saque - Conta Comum
            Console.WriteLine(acc2.Balance); // Valor do Saldo após o saque - Conta Poupança
        }
    }
}
