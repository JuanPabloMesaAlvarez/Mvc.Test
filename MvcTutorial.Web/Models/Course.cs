using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MvcTutorial.Web.Models
{
    public class Course
    {
        public int CourseId { get; set; }
        [Required]
        [StringLength(10, MinimumLength = 2)]
        [Display(Name = "Nombre")]
        public string Name { get; set; }
    }
}