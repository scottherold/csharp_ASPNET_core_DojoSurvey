using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DojoSurveyWithModel.Models
{
    public class Survey
    {
        public string Name { get; set;}
        public string Location { get; set; }
        public string Language { get; set; }
        public string Comment { get; set; }
    }
}