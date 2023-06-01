CustomerManager customer = new CustomerManager(10);
Product product = new Product { Id = 1,Name = "Laptop"};
Product product2 = new Product { Id = 2, Name = "Computer" };
EmployeeManager employeeManager = new EmployeeManager ( new FileLogger());
PersonManager personManager = new PersonManager("Product");
customer.List();
customer.Add();
employeeManager.Add();
personManager.Add();

Console.ReadLine();

class CustomerManager
{
    private int _count;

    public CustomerManager(int count)
    {
        _count = count;
    }
    public void List()
    {
        Console.WriteLine("Listed! {0} items", _count);
    }
    public void Add()
    {
        Console.WriteLine("Added!");
    }
}

class Product
{
    public Product()
    {
        
    }

    private int _id;
    private string _name;
    public Product(int id, string name)
    {
        _id = id;

        _name = name;

    }
    public int Id { get; set; }
    public string Name { get; set; }
}

interface ILogger
{
    void Log();
}

class DatabaseLogger:ILogger
{
    public void Log()
    {
        Console.WriteLine("Logged to database.");
    }
}

class FileLogger : ILogger
{
    public void Log()
    {
        Console.WriteLine("Logged to file.");
    }
}

class EmployeeManager
{
    private ILogger _logger;
    public EmployeeManager(ILogger logger)
    {
        _logger= logger;
    }
    public void Add()
    {
        _logger.Log();
        Console.WriteLine("Added!");
    }
}

class BaseClass
{
    private string _entity;
    public BaseClass(string entity)
    {
        _entity = entity;
    }
    public void Message()
    {
        Console.WriteLine("{0} message",_entity);
    }
}

class PersonManager:BaseClass
{
    public PersonManager (string entity):base(entity)
    {

    }

    public void Add()
    {
        Console.WriteLine("Added!");
        Message();
    }
}