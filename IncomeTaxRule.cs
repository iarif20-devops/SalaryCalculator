using System;

public class IncomeTaxRulesConfig
{
    public class IncomeTaxRule
    {
        public int MinIncome = 0;
        public int MaxIncome = 0;
        public float TaxPercent = 0;
        public int FlatAmount = 0;
    }
}
