
using System;
using System.Collections.Generic;

namespace Lab2_Inheritance
{
    public class RandomList : List<string>
    {

        public string RandomString()
        {
            var randIndex = new Random().Next(this.Count);
            string popped = this[randIndex];
            this.RemoveAt(randIndex);
            return popped;
        }



    }
}
