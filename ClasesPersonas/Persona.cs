using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesPersonas
{
    public class Persona
    {
        //añadimos public siempre 
        //declaro los miembros de la clase
        //por defecto set y get son publicos puedo ponerlo privado si quiero
        //por defecto hay un costructor, si yo creo uno se anula el que viene por defecto
        //c# me crea los seter y geter el solo pero si necesito hacerr uno de manera personal uso esta forma

        /*public int Edad { get; set; }
        public String Nombre { get; set; }*/

        // C# me crea los setter y getter él sólo pero si necesito hacer uno de manera personal uso esta forma
        //si queremos que haga una operacion al crear el objeto lo hacemos asi
        private int _edad;
        //Una variable estatica es una variable que se comparte en todos los objetos que salgan de esta clase, si quiero cambiarlo en algun objeto concreto lo camb io cuando defino la clase 
        // Persona.AñoActual = 2015;
        public static int AñoActual = 2014;

        public static void IncrementarAñoActual(int n)
        {
            AñoActual += n;
        }
        //ponemos guiones bajos en lo privado para diferenciar

        public int Edad
        {
            get { return _edad; }
            set { _edad = value*365; }
        }
        public String Nombre { get; set; }

        public Persona()
        {

        }

        public Persona(String nombre, int edad)
        {
            Nombre = nombre;
            Edad = edad;
        }

        public void Detalles()
        {
            Console.WriteLine("Nombre: {0} Edad: {1}", Nombre, Edad); 
            Console.ReadLine();
        }
        public void Detalles(int extra, bool unaLinea=true, bool años=false)
    {
        if (años)
        {
            if (unaLinea)
            {
                Console.WriteLine("Nombre:{0} Edad: {1}", Nombre, Edad + extra);
            }
            else
            {
                Console.WriteLine("Nombre:{0}", Nombre);
                Console.WriteLine("Edad:{0}", Edad+extra);
            }
        }
    
       }
    }
}
