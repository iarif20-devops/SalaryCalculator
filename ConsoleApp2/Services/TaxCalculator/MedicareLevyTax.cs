using System;
using SalaryCalculator.Console.Configuration;
using SalaryCalculator.Console.Utilities;

namespace SalaryCalculator.Console.Services.TaxCalculator
{
    /// <summary>
    /// Handles the calculation for the medicare levy component in the tax.
    /// </summary>
    public class MedicareLevyTax : IncomeTaxBase
    {
        /// <summary>
        /// Calculates the applicable tax on the given amount.
        /// </summary>
        /// <param name="aAmount">Taxable income amount</param>
        /// <returns>Total medicare levy deduction amount.</returns>
        public decimal Calculate(decimal aAmount)
        {
            try
            {
                return base.CalculateTax(ApplicationSettings.MedicareLevyRulesCollection, aAmount);
            }
            catch
            {
                throw new Exception(ErrorMessage.E100);
            }
        }
    }
}