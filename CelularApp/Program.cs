using CelularApp.Models;
// TODO: Realizar os testes com as classes Nokia e Iphone
Console.WriteLine("Smartphone Nokia");
Smartphone s1 = new Nokia("123456", "Modelo_1", "111111111111", 64);
s1.Ligar();
s1.InstalarAplicativo("Whasapp");

Console.WriteLine("\n");

Console.WriteLine("Smartphone Nokia");
Smartphone s2 = new Iphone("654321", "Modelo_2", "22222222222", 128);
s2.ReceberLigacao();
s1.InstalarAplicativo("Telegram");