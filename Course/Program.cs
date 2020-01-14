using System;
using Course.Entities;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            Account acc1 = new Account(1001, "Bob", 100.0);
            BusinessAccount bacc = new BusinessAccount(1002, "David", 0.0, 100.0);

            //UPCASTING

            Account acc2 = bacc;
            Account acc3 = new BusinessAccount(1003, "Silvia", 150.0, 100.0);
            Account acc4 = new SavingsAccount(1004, "Mauro", 200.0, 0.20);

            //DOWNCASTING

            BusinessAccount acc5 = (BusinessAccount)acc3; //Como acc3 foi instanciado como BusinessAccount, ela pode ser convertida para este mesmo tipo
            acc5.Loan(100.0);

            //SavingsAccount acc6 = (SavingsAccount)acc3; (ERRO)
            if(acc4 is SavingsAccount)
            {
                //SavingsAccount acc6 = (SavingsAccount)acc4;
                SavingsAccount acc6 = acc4 as SavingsAccount;
                acc6.UpdateBalance();
                Console.WriteLine("Update!");
            }

            if(acc4 is BusinessAccount)
            {
                //BusinessAccount acc6 = (BusinessAccount)acc4;
                BusinessAccount acc6 = acc4 as BusinessAccount;
                acc6.Loan(100.0);
                Console.WriteLine("Loan!");
            }
        }
    }
}
