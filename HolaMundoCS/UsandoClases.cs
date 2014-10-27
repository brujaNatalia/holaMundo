using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClasesPersonas;

namespace HolaMundoCS
{
    class UsandoClases
    {
        public static void Main(string[] args)
        {
            //para crear un main nuevo uso psvn+tabulador 
            //puedo crear objetos de varias formas una de ellas es asi
            //Operaciones.Sumar(5,9);
            Persona.AñoActual = 2015;
            var p = new Persona();
            //se esta yendo a persona al set
            p.Nombre = "Luis";
            p.Edad = 22;

            //tambien puedo asi
            var p2 = new Persona()
            {
                Nombre = "luis",
                Edad = 22
            };
            //Persona.IncrementarAñoActual(8);
            p.Detalles(60, false, true);
            p2.Detalles();
            Console.WriteLine();
        }
    }
}
