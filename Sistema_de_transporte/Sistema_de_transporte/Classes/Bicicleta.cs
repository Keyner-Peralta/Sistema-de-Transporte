using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_transporte.Classes
{
    internal class Bicicleta : Vehiculo
    {
        public Bicicleta(string nombre, string marca) : base(nombre, marca)
        {
        }

        public void Canasto()
        {
            Console.WriteLine("Esta bicicleta tiene un gran canasto");
        }
    }
}
