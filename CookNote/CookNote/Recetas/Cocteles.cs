using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CookNote
{
    public class Cocteles: Receta
    {
        public override string GenerarMensaje()
        {
            return (Nombre.ToString() + " " + NombreAutor.ToString() + " " + ingredientes.ToString());

        }
    }
}
