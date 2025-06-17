using Sistema_de_transporte.Classes;

namespace Sistema_de_transporte
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Auto auto = new Auto("Portofino", "Ferrari");
            Bicicleta bici = new Bicicleta("Espirit", "Reid Bikes");

            Vehiculo[] vehiculos = { auto, bici };

            auto.Descripcion();
            auto.Mover();

            Console.WriteLine("");

            bici.Descripcion();
            bici.Canasto();
        }
    }
}
