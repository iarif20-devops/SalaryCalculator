using System.Net.Mime;
using SalaryCalculator.Console.GuiHandler;
using SalaryCalculator.Console.Services.TaxCalculator;

namespace SalaryCalculator.Console
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Startup.Run();
            Run();
        }

        private static void Run()
        {
            UserInputHandler.GuiDisplay();
            var paySlip = TaxCalculator.CalculateTax(UserInputHandler.GrossAmount, UserInputHandler.PayFrequency);
            UserOutputHandler.ShowResults(paySlip);
            System.Console.WriteLine("Press any key to end or R to restart: ");
            char key = System.Console.ReadKey().KeyChar;
            if (key == 'R' || key == 'r')
            {
                Run();
            }
        }
    }
}