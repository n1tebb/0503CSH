using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0503CSH
{
    public class Method_Kotik
    {
        private string _name;
        private string _breed;
        private double _weight;
        private double _height;
        private string _catOwner;


        public void SetName(string name) => name = _name;
        public string GetName() => _name;

        public void SetHeight(double height) => height = _height;
        public double GetHeight() => _height;

        public void SetWeight(double weight) => weight = _weight;
        public double GetWeight() => _weight;

        public string GetBreed() => _breed;

        public string GetCatOwner() => _catOwner;

        public string Info() => $"Кличка котика: {_name}, Рост: {_height}, Вес: {_weight}, Порода: {_breed}, Владелец котика: {_catOwner}";

        public Method_Kotik(string name, string breed, double weight, double height, string catOwner)
        {
            _name = name;
            _breed = breed;
            _weight = weight;
            _height = height;
            _catOwner = catOwner;
        }
    }
}
