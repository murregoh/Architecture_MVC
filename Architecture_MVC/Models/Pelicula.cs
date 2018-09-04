﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Architecture_MVC.Models
{
    public class Pelicula
    {
        public string titulo { get; set; }
        public int duracion { get; set; }
        public DateTime publicacion { get; set; }
        public string pais { get; set; }
    }
}