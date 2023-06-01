string[] students = new string[3];
students[0] = "Ahmet";
students[1] = "Mehmet";
students[2] = "Emir";

//for (int i = 0; i < students.Length; i++)
//{
//    Console.WriteLine(students[i]);
//}

foreach (string student in students)
{
    Console.WriteLine(student);
}
Console.WriteLine("___________________________");
//Multiple arrays(Çok Boyutla Diziler)
string[,] regions = new string[4,3]
{
    {"Istanbul","Kocaeli","Sakarya" },
    {"Izmir","Mugla","Aydin" },
    {"Rize","Trabzon","Artvin" },
    {"Mardin","Diyarbakir","Elazig" }
};

for (int i = 0; i <= regions.GetUpperBound(0); i++) //GetUpperBound(0) dizinin satırının en yüksek sınırını alır bu örnek için 3 veri olduğu için 2'dir.
{
    for (int j = 0; j <= regions.GetUpperBound(1); j++) //GetUpperBound(1) dizinin sütununun en yüksek sınırını alır bu örnek için 3 veri olduğu için 2'dir.
    {
        Console.WriteLine(regions[i,j]);
    }
    Console.WriteLine("___________________________");
}

Console.WriteLine(regions.GetUpperBound(0)); //dizinin satırının eleman sayısı
Console.WriteLine(regions.GetUpperBound(1)); //dizinin sütununun eleman sayısı
Console.ReadLine();