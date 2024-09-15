namespace DesafioPOO.Models
{
    // Resolvido: Herdar da classe "Smartphone"
    public class Nokia : Smartphone
    {
        public Nokia(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria)
        {

        }

        // Resolvido: Sobrescrever o método "InstalarAplicativo"
        public override void InstalarAplicativo(string nomeApp)
        {
            if (nomeApp != "")
            {
                Console.WriteLine($"Instalando {nomeApp} no Nokia!");
            } else
            {
                Console.WriteLine("Nenhum app encontrado!");
            }
        }
    }
}