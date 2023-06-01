using System.Security.Cryptography.X509Certificates;

CustomerManager customerManager = new CustomerManager();
customerManager.Logger = new FileLogger();
customerManager.Add();

Console.ReadLine();

class CustomerManager
{
    public ILogger Logger { get; set; }
    public void Add()
    {
        Logger.Log();
        Console.WriteLine("Customer Added.");
    }
}

class DatabaseLogger: ILogger
{
    public void Log()
    {
        Console.WriteLine("Logged to database!");
    }
}

class FileLogger : ILogger
{
    public void Log()
    {
        Console.WriteLine("Logged to file!");
    }
}

interface ILogger
{
    void Log();
}