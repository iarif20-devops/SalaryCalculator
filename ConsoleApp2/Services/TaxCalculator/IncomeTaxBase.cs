using System;
using System.Collections.Generic;
using System.Linq;
using SalaryCalculator.Console.Configuration;
using SalaryCalculator.Console.Utilities;

namespace SalaryCalculator.Console.Services.TaxCalculator
{
    /// <summary>
    /// Base class for a tax deduction type i.e. Medicare Levy, Budget Repair Levy, Income Tax Repair Levy etc.   
    /// </summary>
    public abstract class IncomeTaxBase
    {
        /// <summary>
        /// Method to compute a tax for the child type.
        /// </summary>
        /// <typeparam name="T">A list collection reference to IncomeTaxSettingItem.</typeparam>
        /// <param name="aTaxRules">Tax rules for the child deduction type</param>
        /// <param name="aAmount">Taxable amount value</param>
        /// <returns>Total deduction amount.</returns>
        public virtual decimal CalculateTax<T>(T aTaxRules, decimal aAmount) where T : List<IncomeTaxSettingItem>
        {
            var result = 0m;
            try
            {
                var taxBracket = aTaxRules.FirstOrDefault(aX =>
                    aAmount >= aX.MinIncome && (aAmount <= aX.MaxIncome || aX.MaxIncome is null));
                if (taxBracket != null && taxBracket.TaxPercent > 0)
                    result = (aAmount - taxBracket.CapAmount) * taxBracket.TaxPercent + taxBracket.FlatAmount;
            }
            catch
            {
                throw new Exception(ErrorMessage.E100);
            }

            return result;
        }
    }
}