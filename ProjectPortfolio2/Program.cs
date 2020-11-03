using System;

namespace ProjectPortfolio2
{
    class Program
    {
        static void Main(string[] args)
        {    
            var dataService = new DataService();

            foreach (var elem in dataService.GetGenres())
            {
                Console.Write(elem);
            }
        }
    }
}