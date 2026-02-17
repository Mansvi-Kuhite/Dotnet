using System.Linq.Expressions;
using System.Runtime.ExceptionServices;

try
{
    First();
}
catch( DivideByZeroException ex)
{
    Console.WriteLine($"An error occured: {ex.Message}");
    Console.WriteLine($"Stack Trace: {ex.StackTrace}");


}
catch(Exception ex)
{
    Console.WriteLine($"An error occured: {ex.Message}");
    Console.WriteLine($"Stack Trace: {ex.StackTrace}");
    Console.WriteLine($"Inner Exception: {ex.InnerException}");
}
finally
{
    Console.WriteLine("finally");
}
Console.WriteLine("Program continues after handling the exception");

void First()
{
    Second();
}
void Second()
{
    try
    {
        Third();
    }
    catch(Exception ex)
    {
        Console.WriteLine($"Exception From Third: {ex.Message}");
        throw new Exception("My Exception here", ex);
    }
}
void Third()
{
    var numerator = 10;
    var denominator = 0;

    var result = numerator / denominator;
}

void AcceptPayment(decimal amount, decimal balance)
{
    if(amount > balance)
    {
       throw new NotEnoughBalanceException("Not enough balancd to complete the payment.");
    }
    Console.WriteLine("Payment accepted.");
}

class BankException : ApplicationException
{
    public BankException(string message): base(message)
    {
        
    }

    public BankException(string message, Exception innerException): base(message, innerException)
    {
        
    }
}

class NotEnoughBalanceException : BankException
{
    public NotEnoughBalanceException(string message) : base(message)
    {

    }

    public NotEnoughBalanceException(string message, Exception innerException) : base(message, innerException)
    {
        
    }
}