using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TemplateKodlamaio.Entities;

namespace TemplateKodlamaio.DataAccess.Abstract;

public interface ICourseDal
{
    List<Course> GetAll();
    void Add(Course course);
    void Update(Course course);
    void Delete(Course course);
}
