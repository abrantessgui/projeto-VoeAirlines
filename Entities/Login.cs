using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VoeAirlines.Entities
{
    public class Login
    {

        public string? Usuario { get; set; }
        public string? Senha { get; set; }
        public int Id { get; set; }


        public Login(string? usuario, string? senha)
        {
            Usuario = usuario;
            Senha = senha;
        }



    }
}