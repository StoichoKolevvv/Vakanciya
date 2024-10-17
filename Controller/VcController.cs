using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vakanciq.Model;
using Vakanciq.View;

namespace Vakanciq.Controller
{
    public class VcController
    {
        private Vacation vacation;
        private Display display;

        public VcController()
        {
            vacation = new Vacation();
            display = new Display();
        }

        public void Run()
        {
            vacation.Budget = display.GetBudget();
            vacation.Season = display.GetSeason();

            vacation.CalculateVacation();

            display.ShowResult(vacation);
        }







    }
}
