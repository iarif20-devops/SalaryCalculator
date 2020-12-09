using System.Collections.Generic;
using Microsoft.Extensions.Configuration;

namespace SalaryCalculator.Console.Configuration
{
    public static class ApplicationSettings
    {
        public static List<IncomeTaxSettingItem> MedicareLevyRulesCollection { get; set; } =
            new List<IncomeTaxSettingItem>();

        public static List<IncomeTaxSettingItem> BudgetRepairLevyRulesCollection { get; set; } =
            new List<IncomeTaxSettingItem>();

        public static List<IncomeTaxSettingItem> IncomeTaxRulesCollection { get; set; } =
            new List<IncomeTaxSettingItem>();

        public static decimal SuperContributionPercentage { get; set; }

        public static void LoadSettings()
        {
            ConfigurationManager.Instance.Bind("IncomeTaxRules:MedicareLevyRules", MedicareLevyRulesCollection);
            ConfigurationManager.Instance.Bind("IncomeTaxRules:BudgetRepairLevyRules", BudgetRepairLevyRulesCollection);
            ConfigurationManager.Instance.Bind("IncomeTaxRules:IncomeTaxRules", IncomeTaxRulesCollection);
            SuperContributionPercentage =
                ConfigurationManager.Instance.GetValue<decimal>("SuperContributionPercentage");
        }
    }
}