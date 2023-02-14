using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CookNote
{
    public class Class1
    {
        public List<Ingrediente> Ingrediente = new List<Ingrediente> { };
        public List<Receta> Recetas = new List<Receta> { };
        public List<Usuario> Usuarios = new List<Usuario> { };
        
        public void CargarUsuario(string Nombre, string pswrd)
        {
            Comun comun = new Comun(Usuarios.Count() + 1, Nombre, pswrd);
            Usuarios.Add(comun);
        }
        public void CargarUsuario (string Nombre, string pswrd, List<int> ingredientes, string pais)
        {        
            if(pais == Paises.paises.Argentina.ToString())// Asi con todos
            {
                List<int> recetavacia = new List<int> { };
                List<string> usuariovacio = new List<string> { };
                VIP vip = new VIP(Usuarios.Count() + 1, Nombre, pswrd, ingredientes, recetavacia, usuariovacio, pais);
            }            
        }
        public bool UserCheck(string name, string pswrd, Usuario usuario)
        {
            if (usuario.Nombre == name && usuario.Password == pswrd)
            {
                return true;
            }
            else return false;
        }
        public void AgregarReceta (string Usuario, string pswrd, Receta receta)
        {
            if (Recetas.Contains(receta))
            {
                foreach (VIP usuario in Usuarios)
                {
                    if (UserCheck(Usuario, pswrd, usuario))
                    {
                        usuario.RecetasFavoritas.Add(receta.ID);
                    }
                }
            }
        }
        public void AddUserFav (string name, string pswrd, Usuario usuario)
        {
            foreach (VIP Usuario in Usuarios)
            {
                if (UserCheck(name, pswrd, usuario))
                {
                    Usuario.UsuariosFavoritos.Add(usuario.Nickname);
                }
            }
        }
        public List<string> FiltrarRecetas( string texto)
        {
            //no hace falta revisar que el usuario sea valido
            List<string> recetasaux = new List<string>();
            foreach (Receta receta in Recetas)
            {
                if (receta.Nombre.ToUpper().Contains(texto.ToUpper()))
                {
                    recetasaux.Add(receta.Nombre);
                }
                else
                {
                    foreach(Ingrediente ingrediente in receta.ingredientes)
                    {
                        if (ingrediente.Nombre.ToUpper().Contains(texto.ToUpper()))
                        {
                            recetasaux.Add(receta.Nombre);
                        }
                        break;
                    }
                }
            }
            return recetasaux;
        }
        public List<string>FiltrarRecetas(string name, string pswrd, string texto)
        {
            List<string> aux = new List<string>();
            foreach (Usuario usuario in Usuarios)
            {
                if (UserCheck(name, pswrd, usuario))
                {
                    aux = FiltrarRecetas(texto);
                }
            }
            return aux;
        }

        //  Me falto hacer el ulitmo metodo, peor es solo retornar una lista de strings
    }
}
