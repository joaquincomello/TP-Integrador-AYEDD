using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_Integrador_AYEDD
{
    public class Cliente
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Email { get; set; }

        public Cliente(int id, string nombre, string email)
        {
            this.Id = id;
            this.Nombre = nombre;
            this.Email = email;
        }

        public Cliente()
        {
            Id = 0;
            Nombre = string.Empty;
            Email = string.Empty;
        }
    }
}
