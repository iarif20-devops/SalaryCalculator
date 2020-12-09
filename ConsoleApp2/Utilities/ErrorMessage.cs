namespace SalaryCalculator.Console.Utilities
{
    /// <summary>
    /// Contains error messages to be displayed to the screen.
    /// </summary>
    public static class ErrorMessage
    {
        public static string E100 = "Couldn't found an appropriate tax bracket for the entered Gross Pay.";

        public static string E900 =
            "Couldn't calculate super contribution. See settings for the super contribution percentage.";
    }
}