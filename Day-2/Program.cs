// See https://aka.ms/new-console-template for more information
using System;
using System.Text;
using System.Diagnostics;


//Section 3 - Primitive Data types
// int a = 42;
// long big = 3_000_000_000L;
// float f = 3.14f;
// double d = 2.71828;
// decimal money = 19.99m;
// bool ok = true;
// char letter = 'A';


// Console.WriteLine(a);
// Console.WriteLine(big);
// Console.WriteLine(f);
// Console.WriteLine(d);
// Console.WriteLine(money);
// Console.WriteLine(ok);
// Console.WriteLine(letter);

//------------------------


//Section 4 - String and StringBuilder
// class Program
// {
//     static void Main()
//     {
//         const int iterations = 100_000;

//         // STRING concatenation
//         var sw1 = Stopwatch.StartNew();
//         string s = "";

//         for (int i = 0; i < iterations; i++)
//         {
//             s += i;
//         }

//         sw1.Stop();
//         Console.WriteLine($"String time: {sw1.ElapsedMilliseconds} ms");

//         // STRINGBUILDER
//         var sw2 = Stopwatch.StartNew();
//         var sb = new StringBuilder();

//         for (int i = 0; i < iterations; i++)
//         {
//             sb.Append(i);
//         }

//         string result = sb.ToString();
//         sw2.Stop();
//         Console.WriteLine($"StringBuilder time: {sw2.ElapsedMilliseconds} ms");
//     }
// }


//Section 5- var and Type Inference
// using System;
// using System.Collections.Generic;

// Console.WriteLine("Section 5 - var and Type Inference");

// // GOOD use of var (type is obvious)
// var x = 10;
// Console.WriteLine(x);

// var name = "Manasvi";
// Console.WriteLine(name);

// var list = new List<string>();
// list.Add("C#");
// list.Add(".NET");

// foreach (var item in list)
// {
//     Console.WriteLine(item);
// }



// // GOOD alternative
// string data = GetSomething();
// Console.WriteLine(data);

// string GetSomething()
// {
//     return "Sample data";
// }

//-----------------------------
//Section 6 - Nullable Types
// Console.WriteLine("Section 6 - Nullable Types");

// int? number = null;
// int result = number ?? -1;
// Console.WriteLine(result);

// string text = null;
// int length = text?.Length ?? 0;
// Console.WriteLine(length);


//----------------------------------
//Section 7 - Control flow - Conditional statements
//First Ex
// int x = 5;

// if (x > 0)
//     Console.WriteLine("positive");
// else if (x < 0)
//     Console.WriteLine("negative");
// else
//     Console.WriteLine("zero");

//Second Ex
// int x = 0;

// switch (x)
// {
//     case 0:
//         Console.WriteLine("zero");
//         break;

//     case 1:
//         Console.WriteLine("one");
//         break;

//     default:
//         Console.WriteLine("other");
//         break;
// }
//-------------------------------------
// int x = -3;

// string result = x switch
// {
//     0 => "zero",
//     > 0 => "positive",
//     < 0 => "negative"
// };

// Console.WriteLine(result);


//----------------------------------
//Section 8 - Pattern Matching
// object o = 5;
// if (o is int i)
// {
//     Console.WriteLine(i + 1);
// }

// var person = new Person { Name = "Manasvi", Age = 22 };
// if (person is { Age: >= 18, Name: var n })
// {
//     Console.WriteLine(n);
// }

// Console.WriteLine(Describe(10));
// Console.WriteLine(Describe("hi"));
// Console.WriteLine(Describe(null));

// string Describe(object? obj) => obj switch
// {
//     null => "none",
//     int x => $"int {x}",
//     string s => $"str({s})",
//     _ => "other"
// };

// class Person
// {
//     public string Name { get; set; }
//     public int Age { get; set; }
// }
//----------------------------------
//section 9 - Logical & Comparison Operators

// int x = 10;
// Console.WriteLine(x > 5 && x < 20);

// string name = null;
// Console.WriteLine(name == null || name.Length == 0);

// bool isAdmin = false;
// bool isUser = true;
// Console.WriteLine(isAdmin || isUser);

//Section 10 - Mathematical Operators

// Console.WriteLine("Section 10 - Mathematical Operators");

// int a = 10;
// int b = 3;

// Console.WriteLine(a + b);
// Console.WriteLine(a - b);
// Console.WriteLine(a * b);
// Console.WriteLine(a / b);

// double div = (double)a / b;
// Console.WriteLine(div);

// int mod = 7 % 3;
// Console.WriteLine(mod);

// int num = 8;
// Console.WriteLine(num % 2 == 0 ? "Even" : "Odd");

//Section 11 - Array and Collections
// Console.WriteLine("Section 11 - Arrays");

// int[] nums = { 1, 2, 3, 4, 5 };

// foreach (int n in nums)
// {
//     Console.WriteLine(n);
// }


// Console.WriteLine("List<T> example");

// List<int> list = new List<int>();
// list.Add(10);
// list.Add(20);
// list.Add(30);

// foreach (int item in list)
// {
//     Console.WriteLine(item);
// }

// list.Remove(20);        // remove by value
// list.RemoveAt(0);       // remove by index
// Console.WriteLine(list.Count); // size

Console.WriteLine("Section 12 - Loops");

int[] arr = { 1, 2, 3 };

for (int i = 0; i < arr.Length; i++)
{
    Console.WriteLine(arr[i]);
}

foreach (var item in arr)
{
    Console.WriteLine(item);
}

int x = 0;
while (x < 3)
{
    Console.WriteLine(x);
    x++;
}

int y = 5;
do
{
    Console.WriteLine(y);
    y++;
} while(y < 3);
