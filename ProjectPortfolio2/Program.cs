using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace ProjectPortfolio2
{
    class Program
    {
        static void Main(string[] args)
        {
            var config = new ConfigurationBuilder()
            .AddJsonFile("config.json")
            .AddEnvironmentVariables()
            .Build();

            var dataService = new DataService(config["connectionString"]);



            foreach (var elem in dataService.GetActorsKnownForTitles())
            {
                Console.Write(elem);
            }
        }
    }
}