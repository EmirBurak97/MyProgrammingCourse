string sentence = "Emir Burak Ocakcı";

var result = sentence.Length; //Karakter uzunluğu
var result2 = sentence.EndsWith("akcı"); //yazılan karakterler ile bitiyor mu
var result3 = sentence.StartsWith("Em"); //yazılan karakterler ile başlıyor mu
var result4 = sentence.IndexOf("Bur"); //yazılan karakterler cümlede varsa kaçıncı karakterden başlıyor yazar yoksa -1 değerini verir.
var result5 = sentence.LastIndexOf("Bur"); //yazılan karakterler cümlede varsa kaçıncı karakterden başlıyor yazar yoksa -1 değerini verir fakat kontrolü tersten yapar.
var result6 = sentence.Substring(5, 5); //Metnin 5. indexinden alıp 5 karakter seçiyor
var result7 = sentence.ToLower(); // Metnin tüm karakterlerini küçültür.
var result8 = sentence.ToUpper(); // Metnin tüm karakterlerini büyültür.
var result9 = sentence.Replace(" ","-"); //Cümledeki tüm boşlukları - ye çevirir.
var result10 = sentence.Remove(0, 4); //başlangıç indexinden 4 karakteri cümleden siler.

Console.WriteLine(result);
Console.WriteLine(result2);
Console.WriteLine(result3);   
Console.WriteLine(result4);   
Console.WriteLine(result5);   
Console.WriteLine(result6);
Console.WriteLine(result7);
Console.WriteLine(result8);
Console.WriteLine(result9); 
Console.WriteLine(result10);

Console.ReadLine();
