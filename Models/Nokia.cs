namespace DesafioPOO.Models
{
    // IMPLEMENTED
    public class Nokia : Smartphone
    {
        public string modelo { get; set; }
        public string imei { get; set; }
        public int memoria { get; set; }
        public Nokia(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria){
            this.modelo = modelo;
            this.imei = imei;
            this.memoria = memoria;
        }
        // IMPLEMENTED
        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Installed: {nomeApp}" + 
            $"\nModelo: {modelo}" +
            $"\nImei: {imei}" +
            $"\nMemoria: {memoria}\n\n");
        }
    }
}