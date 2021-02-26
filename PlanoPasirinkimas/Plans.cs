using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlanoPasirinkimas
{
    public class Plans
    {
        private string title;
        private string GB;
        private string minutes;
        private string SMS;
        private double price;

        public Plans(string title, string gB, string minutes, string sMS, double price)
        {
            this.title = title;
            GB = gB;
            this.minutes = minutes;
            SMS = sMS;
            this.price = price;
        }

        public string GetTitle()
        {
            return this.title;
        }

        public string GetGB()
        {
            return this.GB;
        }

        public string GetMinutes()
        {
            return this.minutes;
        }

        public string GetSMS()
        {
            return this.SMS;
        }

        public double GetPrice()
        {
            return this.price;
        }
    }
}
