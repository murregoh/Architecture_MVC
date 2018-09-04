using DALSQLServer.Models;
using System;
using System.Collections.Generic;

namespace DALSQLServer
{
    public class PeliculasServices
    {
        public Pelicula ObtenerPelicula()
        {
            return new Pelicula()
            {
                titulo = "La Matraca",
                duracion = 115,
                publicacion = new DateTime(2010, 02, 11),
                pais = "USA"
            };
        }

        public List<Pelicula> ObtenerPeliculas() {

            Pelicula p1 = new Pelicula()
            {
                titulo = "La Matraca",
                duracion = 115,
                publicacion = new DateTime(2010, 02, 11),
                pais = "USA"
            };

            Pelicula p2 = new Pelicula()
            {
                titulo = "Rambo",
                duracion = 1224,
                publicacion = new DateTime(2002, 11, 11),
                pais = "COL"
            };

            return new List<Pelicula> { p1, p2 };
        }
    }
}