using System;

namespace OOPFundamentals.Lab3
{
    public class Dog : Animal
    {
        public Dog(string name) : base(name) { }

        public override void Speak()
        {
            Console.WriteLine($"{Name} says Woof");
        }

        public override string ToString()
        {
            return $"Dog: {Name}";
        }
    }
}
