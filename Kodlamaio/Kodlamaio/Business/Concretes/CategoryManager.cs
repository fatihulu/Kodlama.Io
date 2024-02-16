using Kodlamaio.Business.Abstracts;
using Kodlamaio.DataAccess.Abstracts;
using Kodlamaio.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kodlamaio.Business.Concretes;

public class CategoryManager : ICategoryService
{
    private readonly ICategoryDal _categoryDal;
    public CategoryManager(ICategoryDal categoryDal)
    {
        _categoryDal = categoryDal;
    }

    public List<Category> GetAll()
    {
        return _categoryDal.GetAll();
    }

    public void Add(Category category)
    {
        _categoryDal.Add(category);
    }

    public void Delete(Category category)
    {
        _categoryDal.Delete(category);
    }

    public void Update(Category category)
    {
        _categoryDal.Update(category);
    }

    public Category GetById(int id)
    {
        return _categoryDal.GetById(id);
    }
}
