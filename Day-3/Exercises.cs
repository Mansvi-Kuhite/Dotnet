namespace MethodsAndMembersExercises
{
    // 1. Method overloading
    public class Calculator
    {
        public int Add(int x, int y) => x + y;
        public double Add(double x, double y) => x + y;
        public decimal Add(decimal x, decimal y) => x + y;
     
    }
//----------------------------------------------------------------
   //2.Method paramters and return types
    public class ParameterReturnDemo
    {
        
        public (int min, int max) GetMinMax(int[] items)
        {
            if (items == null || items.Length == 0)
                throw new ArgumentException("Array cannot be empty");

            int min = items[0];
            int max = items[0];

            foreach (var i in items)
            {
                if (i < min) min = i;
                if (i > max) max = i;
            }

            return (min, max);
        }
    }
//-------------------------------------------------------------
//4.Named and optional arguments

    public class NamedOptionalDemo
    {
        public void Configure(int retries = 3, bool verbose = false)
        {
            Console.WriteLine($"Retries: {retries}");
            Console.WriteLine($"Verbose: {verbose}");
        }
    }
//------------------------------------------------------------------------
//5.Ref and out parameters
    public class RefOutDemo
    {
        public bool TryGetMax(int[] items, out int max)
        {
            if (items == null || items.Length == 0)
            {
                max = 0;      // mandatory assignment before return
                return false;
            }

            max = items[0];

            foreach (var i in items)
            {
                if (i > max)
                    max = i;
            }

            return true;
        }
    }

    //----------------------------------------
    //6. params keyword
    public class ParamsDemo
    {
        public int Sum(params int[] values)
        {
            int total = 0;

            foreach (var v in values)
            {
                total += v;
            }

            return total;
        }
    }

    // 7.Method Invocation
    public class InvocationDemo
    {
        public delegate void Notify(string message);

        public event Notify? OnNotify;

        public void Trigger()
        {
            OnNotify?.Invoke("Event triggered successfully");
        }
    }
    //8 . Access Modifiers 
    public class BaseClass
    {
        protected internal void ProtectedInternalMethod()
        {
            Console.WriteLine("Protected Internal method called");
        }

        private protected void PrivateProtectedMethod()
        {
            Console.WriteLine("Private Protected method called");
        }
    }

    public class DerivedClass : BaseClass
    {
        public void TestAccess()
        {
            ProtectedInternalMethod();   
            PrivateProtectedMethod();    
        }
    }
    public class NonDerivedClass
    {
        public void TestAccess()
        {
            var obj = new BaseClass();

            obj.ProtectedInternalMethod(); 
        }
    }

// 9.Method scope
public class ScopeDemo
{
    public void Run()
    {
        int x = 10;

        static void Local(int value)
        {
            Console.WriteLine($"Value: {value}");
        }

        Local(x);
    }
}
//10 Static methods
public static class MathUtil
    {
        public static int Square(int x) => x * x;
    }
}
//11. Expression-bodied Menbers
public class ExpressionDemo
{
    public int Square(int x) => x * x;

    public string Name => "Methods Demo";

    public override string ToString() => $"Demo: {Name}";
}

