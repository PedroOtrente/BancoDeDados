using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objetos
{
    public class Usuario
    {
        private int id;
        private string email;
        private string senha;
        private string login;

        public int Id { get => id; set => id = value; }
        public string Email { get => email; set => email = value; }
        public string Senha { get => senha; set => senha = value; }
        public string Login { get => login; set => login = value; }

    }
}
