namespace Factory.Example
{
    /// <summary>
    /// A 'ConcreteCreator' class
    /// </summary>
    class PlatinumFactory : CardFactory
    {
        private int creditLimit;
        private int annualCharge;

        public PlatinumFactory(int creditLimit, int annualCharge)
        {
            this.creditLimit = creditLimit;
            this.annualCharge = annualCharge;
        }

        public override CreditCard GetCreditCard()
        {
            return new PlatinumCreditCard(creditLimit, annualCharge);
        }
    }
}
