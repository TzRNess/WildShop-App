using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace WildShop.Models
{
    public class Usuarios
    {

        [PrimaryKey, AutoIncrement]

        [MaxLength(50)]
        public int IdUsuario { get; set; }

        [MaxLength(50)]
        public string Nombre { get; set; }

        [MaxLength(50)]
        public string Email { get; set; }

        [MaxLength(50)]
        public int Password { get; set; }

        [MaxLength(50)]
        public int Password2 { get; set; }

    }
}
