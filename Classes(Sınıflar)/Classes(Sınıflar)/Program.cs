using Classes_Sınıflar_;

CustomerManager customerManager = new CustomerManager();
customerManager.Add();
customerManager.Update();

ProductManager productManager = new ProductManager();
productManager.Add();
productManager.Update();

Customer customer = new Customer();
customer.Id = 1;
customer.Name = "Emir Burak";
customer.LastName = "Ocakci";
customer.City = "Rize";

//2.kullanım
Customer customer2 = new Customer
{
    Id = 2,
    Name = "Burak",
    LastName = "Kulaber",
    City = "Istanbul"
};

Console.WriteLine(customer.Name);
Console.WriteLine(customer2.City);

Console.ReadLine();

class CustomerManager
{
    public void Add()
    {
        Console.WriteLine("Customer Added!");
    }

    public void Update()
    {
        Console.WriteLine("Customer Updated!");
    }
}

class ProductManager
{
    public void Add()
    {
        Console.WriteLine("Product Added!");
    }

    public void Update()
    {
        Console.WriteLine("Product Updated!");
    }
}