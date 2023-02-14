using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CookNote
{
    public class Comun: Usuario
    {
        public Comun (int id, string nombre, string pswrd)
        {
            this.ID = id;
            this.Nombre = nombre;
            this.Password = pswrd;
        }
    }
}
