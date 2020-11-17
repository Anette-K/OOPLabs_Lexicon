using System;
using System.Diagnostics;
using System.Reflection.Metadata.Ecma335;

namespace _7OOP_UnitTesting
{
    public class Dummy
    {
        private int health;
        private int xp;
        public bool IsDead;
        public event EventHandler<int> GiveXP;

        public Dummy(int health, int xp)
        {
            this.health = health;
            this.xp = xp;
            this.IsDead = false;
        }

        public int Health
        {
            get
            {
                return this.health;
            }
            set
            {
                if (this.IsDead) throw new InvalidOperationException("Can't attack a dead dummy.");

                else if (value > 0) // set new health if dummy is alive
                {
                    this.health = value; //assign new health.
                }
                else //if alive and new health is negative or 0
                {
                    this.health = 0; 
                    this.IsDead = true;
                    OnGiveXP(this.xp);
                }
            }
        }
        public int Xp { get; private set; }

        protected virtual void OnGiveXP(int givenXp)
        {
            GiveXP?.Invoke(this, givenXp);
            
            

        }
    }
}
