Random rnd = new Random();
int sayi=rnd.Next(0,300);
if (sayi>100 && sayi<200)
{
    Console.WriteLine(sayi + " 100 ile 200 arasındadır.");
}
else if (sayi>200)
{
    Console.WriteLine(sayi + " 200'den büyüktür.");
}
else
{
    Console.WriteLine(sayi + " 100'den küçüktür.");
}
Console.ReadLine();