using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace HolaMundoCS
{
    class Programita
    {
        static void Mai(string[] args)
        {
            var edad = 22;
            var nombre = "Luis";
            var fecha = DateTime.Now;
           
            var texto = String.Format("Hola {0} tienes {1} años. Hoy es {2:d}", nombre, edad, fecha);
            // string.formart me permite construir una variable cogiendo datos de diferentes variables

            var array1 = new int[4];
            array1[0] = 44;
            array1[1] = 22;
            array1[2] = 15;
            array1[3] = 82;

            int[] array2 = {4, 7, 3, 9};

            for (int i = 0; i<array1.Length; i++)
            {
                Console.WriteLine("La posicion {0} vale {1}", i, array1[i]);
            }

            foreach (var i in array2)
            {
                Console.WriteLine("Vale {0}", i);
            }

            Console.WriteLine("Hola mundo soy un programa en C#");
            Console.WriteLine(texto);
            Console.ReadLine();
            // se me ha generado unh fichero .exe que puedo utilizar en cualquier ordenador con windows que tenga instalado en netframework
        }
    }
}
