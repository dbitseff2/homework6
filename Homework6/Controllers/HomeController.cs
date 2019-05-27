﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Homework6.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult CardForm()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CardForm(Models.CardResponse cardResponse)
        {
            if (ModelState.IsValid)
            {
                return View("Sent", cardResponse);
            }
            else
            {
                return View();
            }
        }
    }    
}