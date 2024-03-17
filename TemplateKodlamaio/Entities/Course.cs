using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateKodlamaio.Entities;

public class Course
{
    public int Id { get; set; }
    public string CourseName { get; set; }
    public string Description { get; set; }
    public string Instructor { get; set; }
    public Instructor CourseInstructor { get; set; }
    public Category Category { get; set; }
}
