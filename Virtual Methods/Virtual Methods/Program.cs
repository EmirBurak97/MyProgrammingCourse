SqlServer sqlServer = new SqlServer();
sqlServer.Add();
OracleServer osqlServer = new OracleServer();
osqlServer.Add();

Console.ReadLine();

class Database
{
    public virtual void Add()
    {
        Console.WriteLine("Added by Default.");
    }

    public virtual void Delete() 
    {
        Console.WriteLine("Deleted by Default.");
    }
}

class SqlServer : Database
{

}

class OracleServer : Database
{

}