using Sistema_de_transporte.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_transporte.Classes
{
    internal abstract class Vehiculo : ITransporte
    {
        string marca;
        string nombre;

        public Vehiculo(string nombre, string marca)
        {
            this.marca = marca;
            this.nombre = nombre;
        }

        public void Mover()
        {
            Console.WriteLine($"{nombre} de la marca {marca} empezo a moverse!");
        }

        public virtual void Descripcion()
        {
            Console.WriteLine("Los Vehiculos son importantes para poder llegar mas rapido");
        }

        public string Marca
        {
            get { return marca; }
        }
    }
}
