using System;

namespace OOPFundamentals.Lab3
{
    public class Animal
    {
        public string Name { get; set; }

        public Animal(string name)
        {
            Name = name;
        }

        public virtual void Speak()
        {
            Console.WriteLine("Animal makes a sound");
        }

        public override string ToString()
        {
            return $"Animal: {Name}";
        }
    }
}
