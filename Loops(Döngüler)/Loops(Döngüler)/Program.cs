//FOR Loop(FOR Döngüsü)

//for (int i = 100; i >=0; i-=2)
//{
//    Console.WriteLine(i);
//}
//Console.WriteLine("It's Over.");
//Console.WriteLine("----------");

//------------------------------------------------------------------------

//While Loop(While Döngüsü)

//int sayi = 100;
//while (sayi>=0)
//{
//    Console.WriteLine(sayi);
//    sayi -= 2;

//}
//Console.WriteLine("It's Over.");
//Console.WriteLine("----------");

//------------------------------------------------------------------------

//foreach loop(foreach döngüsü)
//string[] students = new string[3] {"Ahmet","Mehmet","Fahri"};
//foreach (string student in students)
//{
//    Console.WriteLine(student); 
//}

//------------------------------------------------------------------------

// Asal mı değil mi?


bool sonuc=false;
Console.Write("Bir sayı giriniz : ");
int eNum = int.Parse(Console.ReadLine());
for (int i = 2; i < eNum; i++)
{

	if (eNum % i != 0)
	{
		sonuc = true;
	}
	else
	{
		sonuc = false;
		i = eNum+1;	
	}
}
if (sonuc==true)
{
	Console.WriteLine(eNum + " asal sayıdır.");
}
else
{
	Console.WriteLine(eNum + " asal sayı değildir.");
}
Console.ReadLine();