using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CookNote
{
    public class Cocina: Receta
    {
        public override string GenerarMensaje()
        {
            return (Nombre.ToString() + " " + NombreAutor.ToString() +" "+ ingredientes[0] + "," + ingredientes[1] + "," + ingredientes[2]);
            
        }
    }
}
