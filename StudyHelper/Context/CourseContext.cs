using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using StudyHelper.WebUI.Models;
using System.Data.Entity.ModelConfiguration.Conventions;


namespace StudyHelper.WebUI.Context
{
    public class CourseContext : DbContext
    {
       
       public DbSet<Course> Courses { get; set; }
    }

    

}