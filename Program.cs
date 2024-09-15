using DesafioPOO.Models;

// Resolvido: Realizar os testes com as classes Nokia e Iphone


Console.WriteLine("Smartphone Iphone");
var iphone = new Iphone(numero: "123456789", modelo: "Modelo 1", imei: "111111111", memoria: 32);
iphone.Ligar();
Console.Write("Instalar o App: ");
var appIphone = Console.ReadLine();
iphone.InstalarAplicativo(appIphone);

Console.WriteLine("-----------------");

Console.WriteLine("Smartphone Nokia");
var nokia = new Nokia(numero: "321456789", modelo: "Modelo 2", imei: "123456789", memoria: 64);
nokia.Ligar();
Console.Write("Instalar o App: ");
var appNokia = Console.ReadLine();
nokia.InstalarAplicativo(appNokia);
