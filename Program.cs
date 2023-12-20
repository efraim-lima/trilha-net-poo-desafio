using DesafioPOO.Models;

// IMPLEMENTED
Smartphone nokia = new Nokia(numero: "", modelo: "", imei: "", memoria: 3);
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo(nomeApp: "Nokia joguinho");

Smartphone iphone = new Iphone(numero: "", modelo: "", imei: "", memoria: 3);
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo(nomeApp: "iPhone joguinho");