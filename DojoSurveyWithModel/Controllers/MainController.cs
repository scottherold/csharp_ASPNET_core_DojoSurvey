// This is the main controller

using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DojoSurveyWithModel
{
    public class MainController : Controller
    {
        // renders the view with the form for submittal
        [HttpGet("")]
        public IActionResult Index()
        {
            return View("Index");
        }

        // takes information from the form and inserts it into a new Survey model class, then returns that object to the Results.cshtml view
        [HttpPost("create")]
        public IActionResult Create(Models.Survey survey)
        {
            // Validations added here
            if(ModelState.IsValid)
            {
                return RedirectToAction("result", survey);
            }
            // if Validations fail, return the Index view
            else
            {
                return View("Index");
            }
        }
        [HttpGet("result")]
        public IActionResult Result(Models.Survey survey)
        {
            return View("Result", survey);
        }
    }
}