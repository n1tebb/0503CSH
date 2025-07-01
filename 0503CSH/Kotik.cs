using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0503CSH
{
    public class Kotik : Animals
    {
        public bool CatchMouse(int num)
        {
            if (num <= 50)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        public override string Info() => $"{base.Info()}, Котик поймал мышку? Ответ: {CatchMouse(100)}";
        public Kotik(string name, string breed, string birthDate, double weight) : base(name, breed, birthDate, weight) { }
    }
}
