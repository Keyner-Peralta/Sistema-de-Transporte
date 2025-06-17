using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_transporte.Classes
{
    internal class Auto : Vehiculo
    {
        public Auto(string nombre, string marca) : base(nombre, marca)
        {
        }

        public sealed override void Descripcion()
        {
            Console.WriteLine($"Auto marca {base.Marca} , diseñado para comodidad y velocidad en viajes terrestres.");
        }
    }
}
