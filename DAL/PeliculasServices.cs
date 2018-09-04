using Architecture_MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class PeliculasServices
    {
        public Pelicula ObtenerPelicula()
        {
            return new Pelicula()
            {
                titulo = "Rambo",
                duracion = 115,
                publicacion = new DateTime(2018, 02, 11),
                pais = "USA"
            };
        }
    }
}
