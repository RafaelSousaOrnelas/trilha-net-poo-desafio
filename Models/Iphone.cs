namespace DesafioPOO.Models
{
    // Resolvido: Herdar da classe "Smartphone"
    public class Iphone : Smartphone
    {
        public Iphone(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria)
        {
            
        }
        // Resolvido: Sobrescrever o método "InstalarAplicativo"
        public override void InstalarAplicativo(string nomeApp)
        {
            if (nomeApp != "")
            {
                Console.WriteLine($"Instalando {nomeApp} no Iphone!");
            } else
            {
                Console.WriteLine("Nenhum app encontrado!");
            }
        }
    }
}