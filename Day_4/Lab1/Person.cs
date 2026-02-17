namespace OOPFundamentals.Lab1
{
    public class Person
    {
        private int _age;

        public string Name {get; set;}

        public int Age
        {
            get => _age;
            set
            {
                if(value < 0 || value > 120)
                throw new ArgumentException("Invalid age");
                _age = value;
            }
        }

        public Person()
        {
            Name = "Unknown";
            Age = 0;
        }

        public Person(string name)
        {
            Name = name;
            Age = 0;
        }

        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public void Display()
        {
            Console.WriteLine($"Name: {Name}, Age: {Age}");
        }
    }
}