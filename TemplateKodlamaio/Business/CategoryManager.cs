using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TemplateKodlamaio.DataAccess.Abstract;
using TemplateKodlamaio.Entities;

namespace TemplateKodlamaio.Business;

public class CategoryManager
{
    private readonly ICategoryDal _categoryDal;

    public CategoryManager(ICategoryDal categoryManager)
    {
        _categoryDal = categoryManager;
    }

    public List<Category> GetAll()
    {
        return _categoryDal.GetAll();
    }

    public void Add(Category category)
    {
        _categoryDal.Add(category);
    }

    public void Update(Category category)
    {
        _categoryDal.Update(category);
    }

    public void Delete(Category category)
    {
        _categoryDal.Delete(category);
    }
}
