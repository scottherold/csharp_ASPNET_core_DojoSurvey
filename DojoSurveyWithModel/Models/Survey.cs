using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace DojoSurveyWithModel.Models
{
    public class Survey
    {
        // Validations and error messages added
        [Required]
        [MinLength(2, ErrorMessage = "Your name must be longer than two characters.")]
        public string Name { get; set;}
        [Required(ErrorMessage = "Dojo Location is required.")]
        public string Location { get; set; }
        [Required(ErrorMessage = "Favorite Language is required.")]
        public string Language { get; set; }
        [MinLength(20, ErrorMessage = "Comments must be longer than 20 characters")]
        public string Comment { get; set; }
    }
}