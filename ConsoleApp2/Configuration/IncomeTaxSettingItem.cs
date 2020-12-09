namespace SalaryCalculator.Console.Configuration
{
    public class IncomeTaxSettingItem
    {
        public decimal MinIncome { get; set; }
        public decimal? MaxIncome { get; set; }
        public decimal TaxPercent { get; set; }
        public decimal FlatAmount { get; set; }
        public decimal CapAmount { get; set; }
    }
}