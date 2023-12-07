using DesafioPOO.Models;

Console.WriteLine("Smartphone Nokia:");
Smartphone nokia = new Nokia(numero: "", modelo: "", imei: "", memoria: 128);
nokia.Ligar();
nokia.InstalarAplicativo("Whatsapp");

Console.WriteLine("\n");

Console.WriteLine("Smartphone IPhone:");
Smartphone iphone = new Iphone(numero: "", modelo: "", imei: "", memoria: 64);
iphone.Ligar();
iphone.InstalarAplicativo("Telegram");

