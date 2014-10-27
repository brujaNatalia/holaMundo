using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace ClasesPersonas
{
    //PONER PUBLICA!!!!
    public class Telefono
    {
        public String Marca { get; set; }
        public String Modelo { get; set; }
        public double Precio { get; set; }

        public double PrecioIva()
        {
            return Precio*1.21;

        }
    }
}
