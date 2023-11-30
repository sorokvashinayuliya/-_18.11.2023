using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ДЗ_18._11._2023
{
    internal class Person
    {
        public string Name { get; set; }
        public string Hobby { get; set; }
        internal Person(string name, string hobby)
        {
            Name = name;
            Hobby = hobby;
        }
        public void Event(string hobby, string eventName)
        {
            if (hobby == Hobby)
            {
                Console.WriteLine($"{Name} занимается {eventName}");
            }
        }
    }
}
