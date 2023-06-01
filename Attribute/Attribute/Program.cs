using System.Runtime.CompilerServices;

Customer customer=new Customer { Id=1,LastName="Ocakci",Age=26};
CustomerDal customerDal = new CustomerDal();
customerDal.Add(customer);

Console.ReadLine();

class Customer
{
    public int Id { get; set; }
    [RequiredProperty]
    public string Name { get; set; }
    public string LastName { get; set; }
    public int Age { get; set; }
}

class CustomerDal
{
    public void Add(Customer customer)
    {
        Console.WriteLine("{0},{1},{2},{3}",customer.Id,customer.Name,customer.LastName,customer.Age);
    }
}

[AttributeUsage(AttributeTargets.Property,AllowMultiple = true)] // Required Property Attribute'una bir Attribute ekledik. Sadece nesnelerde kullanılmasını sağladık ve iki kere kullanılabilir olmasına izin verdik.
class RequiredPropertyAttribute : Attribute
{

}