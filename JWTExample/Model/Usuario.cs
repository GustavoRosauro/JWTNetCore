using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JWTExample.Model
{
    public class Usuario
    {
        public string Name { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }
        public Usuario FindUsers(Usuario user)
        {
            var lista = new List<Usuario>()
            {
                new Usuario(){Name ="gustavo",Password= "gustavo",Role = "administrador"},
                new Usuario(){Name = "amanda", Password = "amanda", Role = "user" }
            };
            return lista.Find(x => x.Name == user.Name && x.Password == user.Password);
        }
    }
}
