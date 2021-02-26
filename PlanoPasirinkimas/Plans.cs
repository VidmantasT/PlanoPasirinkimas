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
        private int GB;
        private int minutes;
        private int SMS;
        private double price;

        public Plans(string title, int gB, int minutes, int sMS, double price)
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

        public int GetGB()
        {
            return this.GB;
        }

        public int GetMinutes()
        {
            return this.minutes;
        }

        public int GetSMS()
        {
            return this.SMS;
        }

        public double GetPrice()
        {
            return this.price;
        }
    }
}
