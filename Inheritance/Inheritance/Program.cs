Person[] persons = new Person[2]
{
    new Customer{Name="Emir Burak"}, new Student{Name = "Hasan Emre"}
};
foreach (var person in persons)
{
    Console.WriteLine(person.Name);
}

Console.ReadLine();

class Person
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string LastName { get; set; }
}

class Student : Person
{
    public string City { get; set; }
}

class Customer : Person
{
    public string City { get; set; }
}


