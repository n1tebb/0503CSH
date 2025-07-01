using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0503CSH
{
    public class Method_Cinema
    {
        private string _movieName;
        private double _price;
        private int _peopleCapacity;
        private string _cinemaHall;
        public void SetMovieName(string movieName) => movieName = _movieName;
        public string GetMovieName() => _movieName;
        public double GetPrice() => _price;
        public string GetCinemaHall() => _cinemaHall;
        public string Info() => $"Название фильма: {_movieName}, Цена билета: {_price}, Вместимось: {_peopleCapacity}, Кинозал: {_cinemaHall}";
        public Method_Cinema(string movieName, double price, int peopleCapacity, string cinemaHall)
        {
            _movieName = movieName;
            _price = price;
            _peopleCapacity = peopleCapacity;
            _cinemaHall = cinemaHall;
        }
    }
}
