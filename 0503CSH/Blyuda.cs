using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0503CSH
{
    public class Blyuda : Assortiment_Cafe
    {
        private double _calories;
        private double _weight;
        public override string GetDishPrice()
        {
            return base.GetDishPrice();
        }
        public override string Info()
        {
            return base.Info();
        }
        public Blyuda(double calories, double weight, string dishName, double price, string category) : base(dishName, price, category, weight)
        {
            _calories = calories;
            _weight = weight;
        }
    }
}
