namespace Factory.Example
{
    /// <summary>
    /// A 'ConcreteProduct' class
    /// </summary>
    class TitaniumCreditCard : CreditCard
    {
        private readonly string cardType;
        private int creditLimit;
        private int annualCharge;

        public TitaniumCreditCard(int creditLimit, int annualCharge)
        {
            cardType = "Titanium";
            this.creditLimit = creditLimit;
            this.annualCharge = annualCharge;
        }

        public override string CardType
        {
            get { return cardType; }
        }

        public override int CreditLimit
        {
            get { return creditLimit; }
            set { creditLimit = value; }
        }

        public override int AnnualCharge
        {
            get { return annualCharge; }
            set { annualCharge = value; }
        }
    }
}
