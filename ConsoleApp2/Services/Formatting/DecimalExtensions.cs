using System.Globalization;

namespace SalaryCalculator.Console.Services.Formatting
{
    public static class DecimalExtensions
    {
        /// <summary>
        ///     Rounds a decimal value to the nearest integral value.
        /// </summary>
        /// <param name="d">A decimal number to be rounded.</param>
        /// <returns>
        ///     The integer nearest parameter . If the fractional component of  is halfway between two integers, one of which
        ///     is even and the other odd, the even number is returned. Note that this method returns a  instead of an
        ///     integral type.
        /// </returns>
        public static decimal ScRound(this decimal d)
        {
            return decimal.Round(d);
        }
        /// <summary>
        /// Formats a decimal amount to a currency display string.
        /// </summary>
        /// <param name="d">A decmial amount</param>
        /// <returns>Displays a formatted amount with the currency information.</returns>
        public static string ScCurrency(this decimal d)
        {
            return d.ToString("C", CultureInfo.CurrentCulture);
        }
    }
}