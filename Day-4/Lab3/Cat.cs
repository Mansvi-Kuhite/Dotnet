using System;

namespace OOPFundamentals.Lab3
{
    public class Cat : Animal
    {
        public Cat(string name) : base(name) { }

        public override void Speak()
        {
            Console.WriteLine($"{Name} says Meow");
        }

        public override string ToString()
        {
            return $"Cat: {Name}";
        }
    }
}
