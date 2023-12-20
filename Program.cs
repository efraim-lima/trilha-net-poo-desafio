using DesafioPOO.Models;

// IMPLEMENTED
Smartphone nokia = new Nokia(numero: "1234", modelo: "heartbitz", imei: "0392101929209202", memoria: 30);
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo(nomeApp: "Nokia joguinho");

Smartphone iphone = new Iphone(numero: "5678", modelo: "popo", imei: "02390329238293493", memoria: 90);
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo(nomeApp: "iPhone joguinho");