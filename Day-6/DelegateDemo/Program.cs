namespace DelegatesDemo;

class Program
{
    public class NewBaseType
    {
        public event Button.OnClickHandler OnClick;
    }

    public class Button : NewBaseType
    {
        public delegate void OnClickHandler();

        public void Click()
        {
            OnClick?.Invoke();
        }
    }

    static void Main(string[] args)
    {
        DelegatesDemoApp app = new DelegatesDemoApp();
        // app.Run();
        // app.HigherOrderFunctionDemo();

        Button button = new Button();
        button.OnClick += () => Console.WriteLine("Bell rings");
        button.OnClick += () => Console.WriteLine("Door opens");
        button.OnClick += () => Console.WriteLine("Light turns on");
        button.OnClick += () => Console.WriteLine("Alarm sounds");

        button.Click();
    
    }
}

//void Add(int a, int b)
// delegate void MathOperation(int a, int b);
//int Add(int a, int b)
delegate int MathOperation(int a, int b);

// Generic Delegate

// delegate TResult GenericTwoParameterFunction<TFirst, TSecond, TResult>(TFirst a, TSecond b);

delegate void GenericTwoParameterAtion<TFirst, TSecond>(TFirst a, TSecond b);

class DelegatesDemoApp
{

    void PrintMessage(string message)
    {
        Console.WriteLine(message);
    }

    bool IsEven(int number)
    {
        return number % 2 == 0;
    }

    public void Run()
    {
        // MathOperation operation = Add;
        // GenericTwoParameterFunction<int, int, int> genericOperation = Add;
        Func<int, int, int> genericOperation = Add;

        Action<string> action = PrintMessage;
        action("Hello from Action delegate!");

        Predicate<int> predicate = IsEven;
        int testNumber = 4;

        Console.WriteLine($"Is {testNumber} even? {predicate(testNumber)}");

        return;

        Func<string, string, string> stringOperation = Concatenate;

        var x = stringOperation("Hello, ", "World!");
        Console.WriteLine($"Concatenation result: {x}");

        // Multicast delegate: adding more methods to the invocation list
        genericOperation += Subtract;
        genericOperation += Multiply;
        genericOperation += Divide;

        genericOperation -= Subtract; // Removing the Subtract method from the invocation list

        var result = genericOperation(5, 3);
        Console.WriteLine($"Final result: {result}");
        HigherOrderFunctionDemo();
    }

    public string Concatenate(string a, string b)
    {
        string result = a + b;
        Console.WriteLine($"Concatenating '{a}' and '{b}' results in: '{result}'");
        return result;
    }

    public int Add(int a, int b)
    {
        Console.WriteLine($"The sum of {a} and {b} is: {a + b}");
        return a + b;
    }

    public int Subtract(int a, int b)
    {
        Console.WriteLine($"The difference between {a} and {b} is: {a - b}");
        return a - b;
    }

    public int Multiply(int a, int b)
    {
        Console.WriteLine($"The product of {a} and {b} is: {a * b}");
        return a * b;
    }

    public int Divide(int a, int b)
    {
        if (b != 0)
        {
            Console.WriteLine($"The quotient of {a} and {b} is: {a / b}");
            return a / b;
        }
        else
        {
            Console.WriteLine("Cannot divide by zero.");
        }
        return 0;
    }


    public void HigherOrderFunctionDemo()
    {
        var result = CalculateArea(AreaofRectangle);
        Console.WriteLine($"Area of the rectangle : {result}");
    }
    int CalculateArea(Func<int, int, int> areaFunction)
    {
        return areaFunction(5,10);
    }

    int AreaofRectangle(int length, int width)
    {
        return length * width;
    }
}