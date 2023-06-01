using System.Collections;
using System.Runtime.CompilerServices;

//ArrayList();
List<string> cities = new List<string>();
cities.Add("Istanbul");
cities.Add("Ankara");

foreach (string city in cities)
{
    Console.WriteLine(city);
}
// 1. Yazılış şekli
//List<Customer> customers = new List<Customer>();
//customers.Add(new Customer { Id = 1 ,Name="Emir"});
//customers.Add(new Customer { Id = 2, Name = "Cemre" });

//2. yazılış şekli
//List(cities);



Console.ReadLine();

static void ArrayList()
{
    ArrayList cities = new ArrayList();
    cities.Add("Istanbul");
    cities.Add("Izmir");

    cities.Add("Ankara");
    cities.Add(1);
    cities.Add('A');
    foreach (var city in cities)
    {
        Console.WriteLine(city);
    }
}

static void List(List<string> cities)
{
    List<Customer> customers = new List<Customer>
{
    new Customer {Id = 1 , Name = "Emir"},
    new Customer {Id = 2 , Name = "Burak"}
};

    var count = customers.Count;  // Count : Listenin sayısını bulmak için kullanılır.
    var customer2 = new Customer
    {
        Id = 3,
        Name = "Ahmet"
    };
    customers.Add(customer2); // Add : Listeye yeni eleman eklemek için kullanılır.
    customers.AddRange(new Customer[2] // AddRange : Listeye yeni bir Liste eklemek için kullanılır.
    {
    new Customer {Id = 4, Name = "Elif"},
    new Customer {Id = 5, Name = "Selin"}
    });

    //customers.Clear(); // Clear : Listeyi temizlemek için kullanılır.


    foreach (var customer in customers)
    {
        Console.WriteLine(customer.Name);
    }
    Console.WriteLine("Count : {0}", count);
    Console.WriteLine(cities.Contains("İstanbul")); // Contains : Var mı yok mu kontrolü yapar.
    Console.WriteLine(customers.Contains(customer2));
    var index = customers.IndexOf(customer2); // IndexOf : Kaçıncı sırada olduğunu kontrol edip index numarasını verir.
    var index2 = customers.LastIndexOf(customer2);// LastIndexOf : Kaçıncı sırada olduğunu kontrol edip index numarasını verir fakat aramaya sondan başlar.
    customers.Insert(0, customer2); // Insert : İstenilen indexe girilen elemanı ekler diğer elemanları da kaydırır.
    customers.Remove(customer2); // Remove : Bulduğu ilk customer2 değerini siler.
    Console.WriteLine(index);
    Console.WriteLine(index2);
}

class Customer
{
    public int Id { get; set; }

    public string Name { get; set; }
}