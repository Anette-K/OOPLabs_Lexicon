using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

namespace Lab2_Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            //Dog dog = new Dog();
            //dog.Eat();
            //dog.Bark();

            //Puppy puppy = new Puppy();
            //puppy.Eat();
            //puppy.Bark();
            //puppy.Weep();

            //Cat cat = new Cat();
            //cat.Eat();
            //cat.Meow();

            //RandomList randlist = new RandomList() { "this", "is", "a", "random", "element" };
            //Console.WriteLine("The randomList contains: ");
            //randlist.ForEach(r => Console.WriteLine(r));

            //Console.WriteLine($"Just popped: {randlist.RandomString()} . Now the list contains: ");
            //randlist.ForEach(r => Console.WriteLine(r));

            var data1 = new List<string>() { "this", "is", "lots", "of", "data" };
            StackOfStrings s = new StackOfStrings(data1);
            s.Push("s1");
            string popped = s.Pop();
            string peeked = s.Peek();
            bool isempty = s.IsEmpty();
            
            


        
        }
    }
}
