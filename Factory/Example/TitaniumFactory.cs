namespace Factory.Example
{
    /// <summary>
    /// A 'ConcreteCreator' class
    /// </summary>
    class TitaniumFactory : CardFactory
    {
        private int creditLimit;
        private int annualCharge;

        public TitaniumFactory(int creditLimit, int annualCharge)
        {
            this.creditLimit = creditLimit;
            this.annualCharge = annualCharge;
        }

        public override CreditCard GetCreditCard()
        {
            return new TitaniumCreditCard(creditLimit, annualCharge);
        }
    }
}
