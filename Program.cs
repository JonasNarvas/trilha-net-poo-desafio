using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

Console.WriteLine("Smartphone Nokia:");
Smartphone nokia = new Nokia(numero:"12345678", modelo:"Modelo NokiaPhone", IMEI: "0001", memoria:32);
nokia.Ligar();
nokia.InstalarAplicativo("Z-lib");
Console.WriteLine("------------------");

Console.WriteLine("Smartphone iPhone:");
Smartphone iphone = new Iphone(numero:"87654321", modelo:"iPhone 8",IMEI:"0002",memoria:64);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Whatsapp");
