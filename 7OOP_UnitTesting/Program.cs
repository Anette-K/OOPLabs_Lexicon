using System;
using System.Collections.Generic;

namespace _7OOP_UnitTesting
{
    class Program
    {
        public static int recievedXp = 0;

        static void Main(string[] args)
        {
            Console.WriteLine("Hello unittestinglab..");
            Axe axe = new Axe(10, 9);
            Dummy dummy = new Dummy(10, 10);
            
            // register with event
            dummy.GiveXP += Dummy_GiveXP; 
            try
            {
                axe.Attack(dummy);
                
            }
            catch (InvalidOperationException x)
            {
                Console.WriteLine(x.Message);
            }
        }
        //handels event it subscribes to
        public static void Dummy_GiveXP(object sender, int givenXp)
        {
            Console.WriteLine($"{sender} gives you {givenXp} xp.");     
            recievedXp += givenXp;

        }
    }
}
