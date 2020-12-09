namespace SalaryCalculator.Console.GuiHandler
{
    /// <summary>
    /// Class constructs the UX and takes input  from the user.
    /// </summary>
    public static class UserInputHandler
    {
        public static decimal GrossAmount;
        public static string PayFrequency;

        public static void GuiDisplay()
        {
            AskGrossSalaryFromUser();
            AskPayFrequencyFromUser();
        }

        private static void AskGrossSalaryFromUser()
        {
            System.Console.Write("Enter your salary package amount: ");
            var grossAmountRaw = System.Console.ReadLine();
            if (!decimal.TryParse(grossAmountRaw, out GrossAmount))
            {
                System.Console.WriteLine("Incorrect salary package input");
                AskGrossSalaryFromUser();
            }

            if (GrossAmount <= 0)
            {
                System.Console.WriteLine("Incorrect salary package input");
                AskGrossSalaryFromUser();
            }
        }

        private static void AskPayFrequencyFromUser()
        {
            System.Console.Write("Enter your pay frequency (W for weekly, F for fortnightly, M for monthly): ");
            var payFrequencyRaw = System.Console.ReadLine();
            if (!string.IsNullOrEmpty(payFrequencyRaw))
                if (payFrequencyRaw == "W" || payFrequencyRaw == "F" || payFrequencyRaw == "M" || payFrequencyRaw == "w" || payFrequencyRaw == "f" || payFrequencyRaw == "m")
                    PayFrequency = payFrequencyRaw;

            if (string.IsNullOrEmpty(PayFrequency))
            {
                System.Console.WriteLine("Incorrect pay frequency input");
                AskPayFrequencyFromUser();
            }
        }
    }
}