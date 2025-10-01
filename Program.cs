using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
var nokia = new Nokia("123456789", "Nokia 1", "64f4cf52-82a0-462e-aeb4-bf13bff9df19", 128);
MostrarFichaAparelho(nokia);
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("Whatsapp");
Console.WriteLine(Global.linhaDivisoria);

Console.WriteLine();

var iphone = new Iphone("987654321", "Iphone 1", "316cefd0-65e5-49a8-b347-9b3f7507b5a3", 256);
MostrarFichaAparelho(iphone);
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Bluesky");
Console.WriteLine(Global.linhaDivisoria);

static void MostrarFichaAparelho(Smartphone tipo)
{
    var ficha = $"""
        {Global.linhaDivisoria}
        Numero: {tipo.Numero} - Modelo: {tipo.ExibeModelo()} - IMEI: {tipo.ExibeImei()} - Memória: {tipo.ExibeMemoria()}Gb
        {Global.linhaDivisoria}
        """;
    Console.WriteLine(ficha);
}

public static class Global
{
    public static string linhaDivisoria = new string('-', 120);
}