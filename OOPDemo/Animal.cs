using System;

namespace OOPDemo
{
    abstract class Animal
    {
        public abstract void Talk();

        public override string ToString()
        {
            Type type = GetType();
            return type.Name;
        }
    }
}