using SalaryCalculator.Console.Configuration;

namespace SalaryCalculator.Console
{
    /// <summary>
    /// Startup class to load data or services need for the application to run. 
    /// </summary>
    public static class Startup
    {
        /// <summary>
        /// Central method to be called in the application init or early in the app lifecycle.
        /// </summary>
        public static void Run()
        {
            ApplicationSettings.LoadSettings();
        }
    }
}