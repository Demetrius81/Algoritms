using System;
using System.Collections.Generic;
using System.Text;

namespace Algoritms.Lesson12
{
    internal class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public int Gender { get; set; }
        public Person(string name, int age, int gender)
        {
            Name = name;
            Age = age;
            Gender = gender;
        }
    
        public override string ToString()
        {
            return Name + " " + Age.ToString();
        }
        public override int GetHashCode()
        {
            return Name.Length + Age + Gender + (int)Name[0];
        }
    }
}
