using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CookNote
{
    public abstract class Usuario
    {
        public int ID { get; set; }
        public string Nombre { get; set; }
        public string Password { get; set; }
        public string Nickname { get; set; }


    }
}
