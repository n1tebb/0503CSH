using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0503CSH
{
    public class Popug : Animals
    {
        public override string Info() => $"{base.Info()}";
        public Popug(string name, string breed, string birthDate, double weight) : base(name, breed, birthDate, weight) { }
    }
}
