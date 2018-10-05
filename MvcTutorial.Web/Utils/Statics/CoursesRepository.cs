using MvcTutorial.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcTutorial.Web.Utils.Statics
{
    public class CoursesRepository
    {
        private static List<Course> courses = new List<Course>();

        public List<Course> Courses { get { return courses; } }

        public CoursesRepository()
        {
            if (courses.Count > 0)
            {
                return;
            }

            for (int course = 0; course < 10; course++)
            {
                courses.Add(new Course
                {
                    CourseId = course,
                    Name = "Course " + course
                });
            }
        }
    }
}