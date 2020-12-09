using System;
using SalaryCalculator.Console.Configuration;
using SalaryCalculator.Console.Services.Formatting;
using SalaryCalculator.Console.Services.Models;
using SalaryCalculator.Console.Utilities;

namespace SalaryCalculator.Console.Services.TaxCalculator
{
    /// <summary>
    /// A class handles tax calculation.
    /// </summary>

    public static class TaxCalculator
    {
        /// <summary>
        /// Calculates tax and prepare the payment summary.
        /// </summary>
        /// <param name="aGrossAmount">A gross amount value.</param>
        /// <param name="aPayFrequency"></param>
        /// <returns>Returns an instance of PaySlip which contains the details for the payment.</returns>
        public static PaySlip CalculateTax(decimal aGrossAmount, string aPayFrequency)
        {
            var result = new PaySlip();
            try
            {
                result.GrossPackage = aGrossAmount;
                result.TaxableIncome = (aGrossAmount - CalculateSuper(aGrossAmount)).ScRound();
                result.Superannuation = CalculateSuper(aGrossAmount).ScRound();
                result.MedicareLevy = new MedicareLevyTax().Calculate(result.TaxableIncome).ScRound();
                result.BudgetRepairLevy = new BudgetRepairLevyTax().Calculate(result.TaxableIncome).ScRound();
                result.IncomeTax = new IncomeTax().Calculate(result.TaxableIncome).ScRound();

                result.NetIncome = result.GrossPackage - result.Superannuation -
                                   result.MedicareLevy - result.BudgetRepairLevy - result.IncomeTax;
                result.PayPacket = GetPayPacket(result.NetIncome, aPayFrequency);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return result;
        }
        /// <summary>
        /// Internal method to compute pay packet based on the pay frequency
        /// </summary>
        /// <param name="aNetIncome">A net income amount</param>
        /// <param name="aPayFrequency">A value from the group (W,F,M) representing the pay cycle.</param>
        /// <returns>A computed payment amount.</returns>
        private static decimal GetPayPacket(decimal aNetIncome, string aPayFrequency)
        {
            if (aPayFrequency == "W")
                return (aNetIncome / 52.0m).ScRound();
            if (aPayFrequency == "F")
                return (aNetIncome / 26.0m).ScRound();
            if (aPayFrequency == "M")
                return (aNetIncome / 12.0m).ScRound();
            return 0;
        }
        /// <summary>
        /// Internal method that calculates a super amount from the passed gross amount.
        /// </summary>
        /// <param name="aGrossAmount">A gross pay amount.</param>
        /// <returns>Computed super contribution amount</returns>
        private static decimal CalculateSuper(decimal aGrossAmount)
        {
            var result = 0m;
            try
            {
                result = aGrossAmount - aGrossAmount / ApplicationSettings.SuperContributionPercentage;
            }
            catch 
            {
                throw new Exception(ErrorMessage.E900);
            }

            return result;
        }
    }
}