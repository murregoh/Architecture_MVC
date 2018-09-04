using System;

namespace DALSQLServer.Models
{
    public class Pelicula
    {
        public string titulo { get; set; }
        public int duracion { get; set; }
        public DateTime publicacion { get; set; }
        public string pais { get; set; }
    }
}