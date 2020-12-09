namespace SalaryCalculator.Console.Services.Models
{
    /// <summary>
    /// Model representing the complete Pay Slip
    /// </summary>
    public class PaySlip
    {
        public decimal GrossPackage { get; set; }
        public decimal Superannuation { get; set; }
        public decimal TaxableIncome { get; set; }
        public decimal MedicareLevy { get; set; }
        public decimal BudgetRepairLevy { get; set; }
        public decimal IncomeTax { get; set; }
        public decimal NetIncome { get; set; }
        public decimal PayPacket { get; set; }
    }
}