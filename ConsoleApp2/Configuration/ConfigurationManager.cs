using Microsoft.Extensions.Configuration;

namespace SalaryCalculator.Console.Configuration
{
    public sealed class ConfigurationManager
    {
        private static string[] _args;

        private static IConfiguration _instance;

        public ConfigurationManager(string[] aArgs)
        {
            _args = aArgs;
        }

        public static IConfiguration Instance
        {
            get
            {
                if (_instance is null)
                {
                    _instance = new ConfigurationBuilder().AddJsonFile("jsconfig1.json")
                        .AddEnvironmentVariables().Build();
                    ;
                }

                return _instance;
            }
        }
    }
}