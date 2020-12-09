using System;
using SalaryCalculator.Console.Services.Formatting;
using SalaryCalculator.Console.Services.Models;

namespace SalaryCalculator.Console.GuiHandler
{
    /// <summary>
    /// Class constructs the output.
    /// </summary>
    public static class UserOutputHandler
    {
        public static void ShowResults(PaySlip aPaySlip)
        {
            System.Console.WriteLine("Calculating salary details...");
            System.Console.WriteLine(Environment.NewLine);
            System.Console.WriteLine(Environment.NewLine);
            System.Console.WriteLine($"Gross package: {aPaySlip.GrossPackage.ScCurrency()}");
            System.Console.WriteLine($"Superannuation: {aPaySlip.Superannuation.ScCurrency()}");
            System.Console.WriteLine($"Taxable income: {aPaySlip.TaxableIncome.ScCurrency()}");
            System.Console.WriteLine(Environment.NewLine);
            System.Console.WriteLine("Deductions:");
            System.Console.WriteLine(Environment.NewLine);
            System.Console.WriteLine(Environment.NewLine);
            System.Console.WriteLine($"Medicare Levy: {aPaySlip.MedicareLevy.ScCurrency()}");
            System.Console.WriteLine($"Budget Repair Levy: {aPaySlip.BudgetRepairLevy.ScCurrency()}");
            System.Console.WriteLine($"Income Tax Levy: {aPaySlip.IncomeTax.ScCurrency()}");


            System.Console.WriteLine($"Net income: {aPaySlip.NetIncome.ScCurrency()} ");
            System.Console.WriteLine($"Pay packet: {aPaySlip.PayPacket.ScCurrency()} ");
        }
    }
}