using System;
using System.Runtime.InteropServices.WindowsRuntime;

namespace _3OOP_Interfaces
{
    public class Citizen : IPerson
    {
        private string name;
        private int age;

        public Citizen(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        public string Name => this.name;

        public int Age => this.age;
    }
}
