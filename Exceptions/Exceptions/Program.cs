//ExtecpcionsIntro();
using Exceptions;

try
{
    FindException();
}
catch (RecordNotFoundExceptions exception)
{
    Console.WriteLine(exception.Message);  
}



Console.ReadLine();

static void ExtecpcionsIntro()
{
    try
    {
        string[] students = new string[3];
        students[3] = "Emir";
    }
    catch (Exception ex)
    {
        Console.WriteLine(ex.InnerException);
    }
}

static void FindException()
{
    List<string> students = new List<string>
{
    "Engin","Derin","Ada"
};
    if (!students.Contains("Ahmet"))
    {
        throw new RecordNotFoundExceptions();
    }
    else
    {
        Console.WriteLine("Record Founded.");
    }
}