using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CookNote
{
    public class VIP: Usuario
    {
        public string Pais { get; set; }
        public List<int> IngredientesFavoritos { get; set; }
        public List<int> RecetasFavoritas { get; set; }
        public List<string> UsuariosFavoritos { get; set; }

        public VIP(int id, string nombre, string pswrd, List<int> ingredientesfav, List<int> recetasfav, List<string> usuariosfav, string Pais)
        {
            this.ID = id;
            this.Nombre = nombre;
            this.Password = pswrd;
            this.Pais = Pais;
            this.IngredientesFavoritos = ingredientesfav;
            this.RecetasFavoritas = recetasfav;
            this.UsuariosFavoritos = usuariosfav;
        }

    }
}
