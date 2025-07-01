using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0503CSH
{
    public class Features_Kotik
    {
        private string _name;
        private string _breed;
        private double _weight;
        private double _height;
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public double Height
        {
            get { return _height; }
            set { _height = value; }
        }
        public double Weight
        {
            get { return _weight; }
            set { _weight = value; }
        }
        public string Breed { get; }
        public string CatOwner { get; }
        public string Info() => $"Кличка котика: {Name}, Рост: {Height}, Вес: {Weight}, Порода: {Breed}, Владелец котика: {CatOwner}";
        public Features_Kotik(string name, string breed, double weight, double height, string catOwner)
        {
            Name = name;
            Breed = breed;
            Weight = weight;
            Height = height;
            CatOwner = catOwner;
        }
    }
}
