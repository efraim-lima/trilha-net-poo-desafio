namespace DesafioPOO.Models
{
    // IMPLEMENTED
    public class Nokia : Smartphone
    {
        public Nokia(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria){

        }
        // IMPLEMENTED
        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Installed: {nomeApp}");
        }
    }
}