using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_forms
{
    public class User
    {
        public string Name { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }

        public override string ToString()
        {
            return $"{Name} {Login} {Password.First()}{new string('*', Password.Length-2)}{Password.Last()}";
        }
    }
}
