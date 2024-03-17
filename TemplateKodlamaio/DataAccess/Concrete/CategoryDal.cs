using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TemplateKodlamaio.DataAccess.Abstract;
using TemplateKodlamaio.Entities;

namespace TemplateKodlamaio.DataAccess.Concrete;

public class CategoryDal : ICategoryDal
{
    List<Category> categories;
    public void Add(Category category)
    {
        categories.Add(category);
        Console.WriteLine(category.CategoryName + "isimli kategori kaydı yapıldı.");
    }

    public void Delete(Category category)
    {
        categories.Remove(category);
        Console.WriteLine(category.CategoryName+ " " + "isimli kategori kaydı silindi.");
    }

    public List<Category> GetAll()
    {
        return categories;
    }

    public void Update(Category category)
    {
        var updatedCategory = categories.SingleOrDefault(e => e.Id == category.Id);

        updatedCategory = category;

        Console.WriteLine(updatedCategory.CategoryName + " " + " isimli kategori "
            + category.CategoryName + " olacak şekilde başarı ile güncellendi.");
    }
}
