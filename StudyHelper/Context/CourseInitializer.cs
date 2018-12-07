using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using StudyHelper.WebUI.Models;

namespace StudyHelper.WebUI.Context
{
    public class CourseInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<CourseContext>
    {
        protected override void Seed(CourseContext context)
        {
            var Courses = new List<Course>
            {
                new Course {CourseID= 1017, CourseName="Biology", CourseDescription="Science cousre that explores the study of living organisms, divided into many specialized fields that cover their morphology, physiology, anatomy, behavior, origin, and distribution "  },
                new Course {CourseID= 1738, CourseName="Literature", CourseDescription="opics include wide reading of historical and contemporary children's literature, criteria for selection, and practice in presenting and responding to literature ."},
            };
        }
    }
}