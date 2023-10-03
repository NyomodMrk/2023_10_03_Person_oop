using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2023_10_03_Person_oop
{
    internal class Person
    {

        private string name;
        private int age;
        private string gender;

        public Person(string name, int age, string gender)
        {
            this.name = name;
            this.age = age;
            this.gender = gender;
        }

        public string Name { get => name; set => name = value; }
        public int Age { get => age; set => age = value; }
        public string Gender { get => gender; set => gender = value; }

        public void getGoal()
        {
            Console.WriteLine("My goal is: Live for the moment!");
        }

        public void Introduce()
        {
            Console.WriteLine($"Hi, Im {this.name}, a {this.age} year old {this.gender}");
        }
    }
}
