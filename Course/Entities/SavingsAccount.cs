namespace Course.Entities
{
    class SavingsAccount : Account
    {
        public double InterestRate { get; set; }

        public SavingsAccount()
        {
        }

        public SavingsAccount(int number, string holder, double balance, double interestRate)
            : base(number, holder, balance)
        {
            InterestRate = interestRate;
        }

        public void UpdateBalance()
        {
            Balance += Balance * InterestRate;
        }

        public override void WithDraw(double amount) // Saque da Conta Poupança cobra a taxa de saque 2.0 a mais do que a Conta Comum
        {
            base.WithDraw(amount);
            Balance -= 2.0;
        }
    }
}
