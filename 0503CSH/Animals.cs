using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0503CSH
{
    public class Animals
    {
        private string _name;
        private string _breed;
        private string _birthDate;
        private double _weight;
        public virtual string Info() => $"Имя: {_name}, Порода: {_breed}, Вес: {_weight}, Дата рождения: {_birthDate}";
        public Animals(string name, string breed, string birthDate, double weight)
        {
            _name = name;
            _breed = breed;
            _birthDate = birthDate;
            _weight = weight;
        }
    }
}
