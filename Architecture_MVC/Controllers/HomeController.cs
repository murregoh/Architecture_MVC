﻿using DALSQLServer;
using DALSQLServer.Models;
using System.Collections.Generic;
using System.Web.Mvc;


namespace Architecture_MVC.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";
            ViewBag.Test = "Controller Test";

            List<Pelicula> pelicula = new PeliculasServices().ObtenerPeliculas();

            return View(pelicula);
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";
            return View();
        }
    }
}