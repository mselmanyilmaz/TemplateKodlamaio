using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TemplateKodlamaio.DataAccess.Abstract;
using TemplateKodlamaio.Entities;

namespace TemplateKodlamaio.DataAccess.Concrete;

public class CourseDal : ICourseDal
{
    List<Course> courses;
    public void Add(Course course)
    {
        courses.Add(course);
        Console.WriteLine(course.CourseName + "isimli kursun kaydı yapıldı.");
    }

    public void Delete(Course course)
    {
        courses.Remove(course);
        Console.WriteLine(course.CourseName + "isimli kurs kaydı silindi.");

    }

    public List<Course> GetAll()
    {
        return courses;
    }

    public void Update(Course course)
    {
        var updatedCourse = courses.SingleOrDefault(e => e.Id == course.Id);

        updatedCourse = course;

        Console.WriteLine(updatedCourse.CourseName + " " + updatedCourse.Description + " " + updatedCourse.Instructor + " özellikleri olan kayıtlı kurs "
            + course.CourseName + " " + course.Description + " " + course.Instructor + " olacak şekilde başarı ile güncellendi.");

    }
}
