using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vakanciq.Model
{
    internal class Vacation
    {
        private double budget;
        private string season;
        private string destination;
        private string vacationType;
        private double amountSpent;

        public double Budget
        {
            get { return budget; }
            set { budget = value; }
        }

        public string Season
        {
            get { return season; }
            set { season = value.ToLower(); }
        }

        public string Destination
        {
            get { return destination; }
            private set { destination = value; }
        }

        public string VacationType
        {
            get { return vacationType; }
            private set { vacationType = value; }
        }

        public double AmountSpent
        {
            get { return amountSpent; }
            private set { amountSpent = value; }
        }

        public void CalculateVacation()
        {
            if (Budget <= 100)
            {
                Destination = "Bulgaria";
                if (Season == "summer")
                {
                    VacationType = "Camp";
                    AmountSpent = Budget * 0.30;
                }
                else
                {
                    VacationType = "Hotel";
                    AmountSpent = Budget * 0.70;
                }
            }
            else if (Budget <= 1000)
            {
                Destination = "Balkans";
                if (Season == "summer")
                {
                    VacationType = "Camp";
                    AmountSpent = Budget * 0.40;
                }
                else
                {
                    VacationType = "Hotel";
                    AmountSpent = Budget * 0.80;
                }
            }
            else
            {
                Destination = "Europe";
                VacationType = "Hotel";
                AmountSpent = Budget * 0.90;
            }
        }






    }
}
