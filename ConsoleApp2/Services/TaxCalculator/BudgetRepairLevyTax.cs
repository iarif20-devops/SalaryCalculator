using System;
using SalaryCalculator.Console.Configuration;
using SalaryCalculator.Console.Utilities;

namespace SalaryCalculator.Console.Services.TaxCalculator
{
    /// <summary>
    /// Handles the calculation for the budget repair levy component in the tax.
    /// </summary>
    public class BudgetRepairLevyTax : IncomeTaxBase
    {
        /// <summary>
        /// Calculates the applicable tax on the given amount.
        /// </summary>
        /// <param name="aAmount">Taxable income amount</param>
        /// <returns>Total deduction amount.</returns>
        public decimal Calculate(decimal aAmount)
        {
            try
            {
                return base.CalculateTax(ApplicationSettings.BudgetRepairLevyRulesCollection, aAmount);
            }
            catch
            {
                throw new Exception(ErrorMessage.E100);
            }
        }
    }
}