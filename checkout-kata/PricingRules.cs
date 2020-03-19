using System;
using System.Collections.Generic;

namespace checkout_kata
{
    public class PricingRules
    {
        private Dictionary<string, int> _rules = new Dictionary<string, int>();

        public PricingRules(Dictionary<string, int> rules)
        {
            _rules = rules;
        }

        public int? LookupPrice(string sku, int units)
        {
            string key = String.Format("{0}:{1}", sku, units);
            return _rules.ContainsKey(key) ? (int?)_rules[key] : null;
        }
    }
}
