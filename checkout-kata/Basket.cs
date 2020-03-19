namespace checkout_kata
{
    public class Basket
    {
        private PricingRules _pricingRules;
        private int _total;

        public Basket(PricingRules pricingRules)
        {
            _pricingRules = pricingRules;
        }

        public void Scan(Item item)
        {
            _total += item.Price;
        }


        public int GetTotal()
        {
            return _total;
        }

    }
}