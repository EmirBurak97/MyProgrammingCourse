using Interfaces;

//InterfaceDemo();

ICustomerDal[] customerDals = new ICustomerDal[2]
{
    new SqlServerCustomerDal(),
    new OracleServerCustomerDal()
};

foreach (var customerDal in customerDals)
{
    customerDal.Add();
}

Console.ReadLine();

static void InterfaceDemo()
{
    CustomerManager customerManager = new CustomerManager();
    customerManager.Add(new SqlServerCustomerDal());
    customerManager.Add(new OracleServerCustomerDal());
}