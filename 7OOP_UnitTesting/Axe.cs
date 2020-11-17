using System;
namespace _7OOP_UnitTesting
{
    public class Axe
    {
        //public int DurabilityPoints { get; private set; }
        private int durabilityPoints;
        private int damage;
        public int Damage { get; private set; }
        

        //private int durabilityPoints;
        //private int damage;



        //private bool IsBroken;

        public Axe(int durabilityPoints, int damage)
        {
            this.durabilityPoints = durabilityPoints;
            this.damage = damage;
            //this.IsBroken = false; 
        }

        public void Attack(Dummy dummy)
        {
            
            this.DurabilityPoints -= 1;
            dummy.Health -= this.damage;
        }

        public int DurabilityPoints
        {
            get
            {
                return this.durabilityPoints;
            }
            private set
            {
                if (value >= 0)
                {
                    this.durabilityPoints = value;
                }

            }

        }




    }

    
    
}