// See https://aka.ms/new-console-template for more information
namespace MethodsAndMembersExercises
{
    class Program
    {
        static void Main()
        {
            var calc = new Calculator();

            Console.WriteLine("Addition : " + calc.Add(2, 3));
            Console.WriteLine(calc.Add(2.5, 3.7));
            Console.WriteLine(calc.Add(2.1m, 3.2m));
            Console.WriteLine("---------------");
            //--------------------------------------------------------
            var paramDemo = new ParameterReturnDemo();
            var result = paramDemo.GetMinMax(new int[] { 8, 3, 5, 1, 9 });

            Console.WriteLine($"Min: {result.min}");
            Console.WriteLine($"Max: {result.max}");
            Console.WriteLine("---------------");
            //--------------------------------------------------------
            var demo = new NamedOptionalDemo();
            demo.Configure();
            demo.Configure(verbose: true);
            demo.Configure(5, verbose: true);
            Console.WriteLine("---------------");
            //----------------------------------------------------------
            var refOutDemo = new RefOutDemo();

            if (refOutDemo.TryGetMax(new int[] { 4, 9, 2, 7 }, out int maxValue))
            {
                Console.WriteLine($" Max value: {maxValue}");
            }
            else
            {
                Console.WriteLine("Array was empty");
            }

            Console.WriteLine("---------------");

            var paramsDemo = new ParamsDemo();

            Console.WriteLine("paramkeyword : " + paramsDemo.Sum(1, 2, 3, 4));
            Console.WriteLine(paramsDemo.Sum(10, 20));
            Console.WriteLine(paramsDemo.Sum());
            Console.WriteLine("---------------");
            //-------------------------------------------------
            var invocationDemo = new InvocationDemo();

            invocationDemo.OnNotify += message => Console.WriteLine(message);

            invocationDemo.Trigger();


            var calculator = new Calculator();
            Console.WriteLine(calc.Add(2, 3));

            Func<int, int, int> addFunc = (x, y) => x + y;
            Console.WriteLine(addFunc(4, 5));
            Console.WriteLine("---------------");
            //-----------------------------------------------------
            var derived = new DerivedClass();
            derived.TestAccess();

            var nonDerived = new NonDerivedClass();
            nonDerived.TestAccess();
            Console.WriteLine("---------------");
            //--------------------------------------------------
            var scopeDemo = new ScopeDemo();
            scopeDemo.Run();
            Console.WriteLine("---------------");
            //--------------------------------------------------
            var mathUtil = MathUtil.Square(5);
            Console.WriteLine($"Square of 5 is: {mathUtil}");
            Console.WriteLine("---------------");
            //--------------------------------------------------
            string value = "123";
            Console.WriteLine(value.ToIntOrNull());
            Console.WriteLine("madam".IsPalindrome());
            Console.WriteLine("---------------");
            //--------------------------------------------------

            var expDemo = new ExpressionDemo();
            Console.WriteLine(expDemo.Square(4));
            Console.WriteLine(expDemo.ToString());

        }
    }
}
