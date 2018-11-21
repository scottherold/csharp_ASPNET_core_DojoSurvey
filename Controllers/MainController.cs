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
        [HttpPost("/survey")]
        public IActionResult Survey(string name, string location, string language, string comment)
        {
            Models.Survey newSurvey = new Models.Survey()
            {
                Name = name,
                Location = location,
                Language = language,
                Comment = comment,
            };

            return View("Result", newSurvey);
        }
    }
}