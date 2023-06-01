Add();
var result=Add2(34,53);
Console.WriteLine(result);
Console.WriteLine(Add3(2, 6, 7, 8, 9, 10));

Console.ReadLine();
static void Add()
{
    Console.WriteLine("Added!");
}

// Parametreli method
static int Add2(int n1,int n2)
{
    var result = n1 + n2;
    return result;
}

static int Add3(params int[] numbers)
{
    return numbers.Sum();
}