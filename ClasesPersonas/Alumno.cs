using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesPersonas
{
    public class Alumno:Persona
    {
        public void borrar()
        {
           //no me deja acceder porque es privedo si lo pongo protected me dejaria porque fuera de la estructura tengo acceso
           // _edad = 22;
           //protected es publico en mi estructura de herencia y privado fuera de mi estructura de herencia
            // sobrescritura de metodos consiste en un metodo que tengo definido en una ...
            //Para que un metodo pueda ser sobrescrito tengo que ponerlo en virtual
        }
        // no existe la herencia multiple en C#
        public int Nota { get; set; }
    }
}
