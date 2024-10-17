using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vakanciq.Model;

namespace Vakanciq.View
{
    public class Display
    {
        public double GetBudget()
        {
            Console.WriteLine("Enter your budget:");
            return double.Parse(Console.ReadLine());
        }

        public string GetSeason()
        {
            Console.WriteLine("Enter the season (summer or winter):");
            return Console.ReadLine();
        }

        public void ShowResult(Vacation vacation)
        {
            Console.WriteLine($"Somewhere in {vacation.Destination}");
            Console.WriteLine($"{vacation.VacationType} - {vacation.AmountSpent:F2}");
        }



    }
}
