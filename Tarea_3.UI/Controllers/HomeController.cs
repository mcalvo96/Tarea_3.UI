﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Tarea_3.UI.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Personas()
        {
            return View();
        }

        public ActionResult PersonaJuridicas()
        {
            return View();
        }

        public ActionResult Objetos()
        {
            return View();
        }

        public ActionResult Vehiculos()
        {
            return View();
        }
    }
}