using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0503CSH
{
    public class Attracion
    {
        private string _name;
        private double _duration;
        private int _maxSeats;
        private double _price;
        public virtual string Info() => $"Название: {_name}, Продолжительность поездки: {_duration}, Максимальное кол-во мест: {_maxSeats}";
        public virtual double GetRevenue(int people = 0)
        {
            if (people == 0)
            {
                return _price * _maxSeats;
            }
            else
            {
                return people * _price;
            }
        }
        public Attracion(string name, double duration, int maxSeats, double price)
        {
            _name = name;
            _duration = duration;
            _maxSeats = maxSeats;
            _price = price;
        }
    }
}
