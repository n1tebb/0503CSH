using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0503CSH
{
    public class American_Gorki : Attracion
    {
        private double _price;
        public override double GetRevenue(int people = 0)
        {
            return base.GetRevenue();
        }
        public override string Info()
        {
            return base.Info();
        }
        public American_Gorki(double price, string name, double duration, int maxSeats) : base(name, duration, maxSeats, price)
        {
            _price = price;
        }
    }
}
