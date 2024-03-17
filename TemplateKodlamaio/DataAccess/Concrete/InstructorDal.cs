using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TemplateKodlamaio.DataAccess.Abstract;
using TemplateKodlamaio.Entities;

namespace TemplateKodlamaio.DataAccess.Concrete;

public class InstructorDal : IInstructorDal
{
    List<Instructor> instructors;
    public void Add(Instructor instructor)
    {
        instructors.Add(instructor);
        Console.WriteLine(instructor.FirstName + " " + instructor.LastName + "isimli eğitmenin kaydı yapıldı.");
    }

    public void Delete(Instructor instructor)
    {
        instructors.Remove(instructor);
        Console.WriteLine(instructor.FirstName + " " + instructor.LastName + "isimli eğitmenin kaydı silindi.");
    }

    public List<Instructor> GetAll()
    {
        return instructors;
    }

    public void Update(Instructor instructor)
    {
        var updatedInstructor = instructors.SingleOrDefault(e => e.Id == instructor.Id);

        updatedInstructor = instructor;

        Console.WriteLine(updatedInstructor.FirstName + " " + updatedInstructor.LastName + " ismi ile kayıtlı olan eğitmen "
            + instructor.FirstName + " " + instructor.LastName + " olacak şekilde başarı ile güncellendi.");

    }
}
