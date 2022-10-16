using System;
using System.Collections.Generic;
using System.Text;
using SQLite;


namespace Ejercicio13
{
    public class Personas
    {
        [PrimaryKey, AutoIncrement]
        public int id { get; set; }

        [MaxLength(250)]
        public string nombre { get; set; }

        [MaxLength(250)]
        public string apellido { get; set; }

        [MaxLength(250)]
        public string edad { get; set; }

        [MaxLength(250)]
        public string mail { get; set; }

        [MaxLength(250)]
        public string direccion { get; set; }

    }
}
