// See https://aka.ms/new-console-template for more information
// using Microsoft.Data.SqlClient;


// string query = "SELECT * FROM Employees WHERE Salary > 50000";
// SqlConnection connection = new SqlConnection("YourConnectionStringHere");
// SqlCommand cmd = new SqlCommand(query, connection);
// SqlDataReader reader = cmd.ExecuteReader();
// List<Employee> employees = new List<Employee>();
// while (reader.Read())
// {
//     employees.Add(new Employee { Name = (string)reader["Name"], Salary = (decimal)reader["Salary"] });
// }


// class Employee
// {
//     public string Name { get; set; }
//     public decimal Salary { get; set; }
// }

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;

CrmContext _context = new CrmContext();

var customers = _context.Customers
    .Where(e => e.Age > 20)
    .ToList();

// Without ToList()
// Console.WriteLine("customers.GetType(): " + customers.GetType());
// Console.WriteLine($"Query: {customers.ToQueryString()}");

// With ToList()
// Console.WriteLine("customers.GetType(): " + customers.GetType());

// With AsEnumerable()
// Console.WriteLine("customers.GetType(): " + customers.GetType());

// customers.Add(new Customer { Name = "John Doe", Age = 30 });
// _context.SaveChanges();

Console.WriteLine($"Customers Count: {customers.Count()}");

_context.Customers.Add(new Customer { Name = "Danny Lee", Age = 30 });
_context.SaveChanges();


// Because DbSet is not IList, index operator will not work
// var first = _context.Customers[0];

var john = _context.Customers.FirstOrDefault(c => c.Name == "John Doe");
if (john != null) john.Age = 31;

_context.SaveChanges();

foreach (var customer in customers)
{
    Console.WriteLine($"Id: {customer.Id} Customer: {customer.Name}, Age: {customer.Age}");
}

class CrmContext : DbContext
{
    public DbSet<Customer> Customers { get; set; }
    public DbSet<Order> Orders { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Server=localhost\\SQLExpress;Database=CRMApplicationDB;Trusted_Connection=True;TrustServerCertificate=True");
       
    }
}

public class Order
{
    [Key]
    public int OrderId { get; set; }

    [Required]
    [MaxLength(100)]
    [MinLength(3)]
    public string Product { get; set; } = string.Empty;

    [Required]
    [Precision(18, 2)]
    public decimal Price { get; set; }

    [ForeignKey("CustomerId")]
    public int CustomerId { get; set; }

    [Required]
    public Customer Customer { get; set; } = null!;
}

public class Customer
{
    public int Id { get; set; }

    [Required]
    [MaxLength(100)]
    public string Name { get; set; } = string.Empty;
    public int Age { get; set; }
}