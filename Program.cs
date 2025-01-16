using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

Nokia nokia = new Nokia("21999999999", "3110", "SAjiS5fgSZX", 1);
Iphone iphone = new Iphone("218888888889", "15 pro max", "SFUH154SF", 6);

nokia.Ligar();
nokia.InstalarAplicativo("Jogo da cobrinha");
iphone.Ligar();
iphone.InstalarAplicativo("Siri");
