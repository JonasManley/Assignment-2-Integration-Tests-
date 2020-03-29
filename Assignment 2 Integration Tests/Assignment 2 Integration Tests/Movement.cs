using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2_Integration_Tests
{
    public class Movement
    {
        private DateTime datetime;
        private double money;

        public Movement(double money, DateTime dateTime)
        {
            this.money = money;
            this.datetime = datetime;
        }


        public DateTime Datetime
        {
            get { return datetime; }
            set { datetime = value; }
        }
        public double Money
        {
            get { return money; }
            set { money = value; }
        }

    }
}
