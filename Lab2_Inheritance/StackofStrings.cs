using System;
using System.Collections.Generic;

namespace Lab2_Inheritance
{
    public class StackOfStrings 
    {
        // composition 
        private List<string> data;
        private Stack<string> stack;

        public StackOfStrings(List<string> data)
        {
            //could skip saving data and just use it to populate stack
            this.data = data;
            this.stack = new Stack<string>(data);

        }

        public void Push(string item)
        {
            this.stack.Push(item);
        }

        public string Pop()
        {
            return this.stack.Pop();
        }

        public string Peek()
        {
            return this.stack.Peek();
        }

        public bool IsEmpty()
        {
            return this.stack == null;
        }
    }
}
