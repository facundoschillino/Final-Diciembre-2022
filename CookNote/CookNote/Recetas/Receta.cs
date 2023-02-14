using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CookNote
{
    public abstract class Receta
    {
        public string NombreAutor { get; set; }
        public List<Ingrediente> ingredientes { get; set; }
        public int ID { get; set; }
        public string Nombre { get; set; }
        public DateTime FechaEliminacion { get; set; }

        public abstract string GenerarMensaje();
        
    }
}
