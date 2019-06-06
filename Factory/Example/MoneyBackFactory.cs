namespace Factory.Example
{
    /// <summary>
    /// A 'ConcreteCreator' class 
    /// </summary>
    class MoneyBackFactory : CardFactory
    {
        private int creditLimit;
        private int annualCharge;

        public MoneyBackFactory(int creditLimit, int annualCharge)
        {
            this.creditLimit = creditLimit;
            this.annualCharge = annualCharge;
        }

        public override CreditCard GetCreditCard()
        {
            return new MoneyBackCreditCard(creditLimit, annualCharge);
        }
    }
}
