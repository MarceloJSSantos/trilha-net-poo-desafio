namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        public string Numero { get; set; }
        // TODO: Implementar as propriedades faltantes de acordo com o diagrama
        private string Modelo;
        private string Imei;
        private int Memoria;

        public Smartphone(string numero, string modelo, string imei, int memoria)
        {
            Numero = numero;
            Modelo = modelo;
            Imei = imei;
            Memoria = memoria;
        }

        public void Ligar()
        {
            Console.WriteLine(">>> Ligando...");
        }

        public void ReceberLigacao()
        {
            Console.WriteLine(">>> Recebendo ligação...");
        }

        public abstract void InstalarAplicativo(string nomeApp);

        public string ExibeModelo()
        {
            return Modelo;
        }

        public string ExibeImei()
        {
            return Imei;
        }

        public int ExibeMemoria()
        {
            return Memoria;
        }
    }
}