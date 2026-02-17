// See https://aka.ms/new-console-template for more information

using System;
using OOPFundamentals.Lab1;
using OOPFundamentals.Lab2;
using OOPFundamentals.Lab3;
using OOPFundamentals.Lab4;
using OOPFundamentals.Lab5;
using System.Collections.Generic;


namespace OOPFundamentals
{
    class Program
    {
        static void Main()
        {
            // creating objects using different constructors
            Person p1 = new Person();
            Person p2 = new Person("Amit");
            Person p3 = new Person("Riya", 25);

            // calling method
            p1.Display();
            p2.Display();
            p3.Display();


            Console.WriteLine("\n--- Lab 2 ---");

            BankAccount acc = new BankAccount("Ravi", 1000);

            acc.Deposit(500);
            acc.Withdraw(2000);

            Console.WriteLine($"Balance: {acc.Balance}");
            Console.WriteLine($"Is Overdrawn: {acc.IsOverdrawn}");

            Console.WriteLine("\n--- Lab 3 ---");


            List<Animal> animals = new List<Animal>
            {
                new Dog("Bruno"),
                new Cat("Mimi")
            };
            foreach (var animal in animals)
            {
                Console.WriteLine(animal);
                animal.Speak();
            }

            Console.WriteLine("\n--- Lab 4 ---");

            IRepository<string> repo = new InMemoryRepository<string>();

            repo.Add("Item 1");
            repo.Add("Item 2");
            repo.Add("Item 3");

            foreach (var item in repo.GetAll())
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("\n--- Lab 5 ---");

            Shape circle = new Circle(5);
            Shape rectangle = new Rectangle(4, 6);

            Console.WriteLine($"Circle Area: {circle.Area()}");
            Console.WriteLine($"Rectangle Area: {rectangle.Area()}");

            ITransformable transformCircle = (ITransformable)circle;
            transformCircle.Scale(2);

            Console.WriteLine($"Scaled Circle Area: {circle.Area()}");


        }
    }
}

