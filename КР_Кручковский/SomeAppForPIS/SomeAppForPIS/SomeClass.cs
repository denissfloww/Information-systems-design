using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomeAppForPIS
{
    class SomeClass
    {
        private readonly string name;

        private static readonly List<string> names = new List<string>();

        private SomeClass(string name)=>this.name = name;

        public static SomeClass Create(string name)
        {
            if (names.Contains(name)) throw new ArgumentException("Такое имя уже используется ");
            names.Add(name);
            return new SomeClass(name);
        }
    }
}
