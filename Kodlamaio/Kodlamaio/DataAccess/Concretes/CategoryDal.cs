using Kodlamaio.DataAccess.Abstracts;
using Kodlamaio.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kodlamaio.DataAccess.Concretes;

public class CategoryDal : ICategoryDal
{
    public List<Category> categories;
    public CategoryDal()
    {
        categories = new List<Category>
        {
            new Category{Id=1, Name="C#",Description="C# kursuna ait dersler"},
            new Category{Id=2,Name="Java",Description="Java kursuna ait dersler"},
            new Category{Id=3,Name="JavaScript",Description="JavaScript kursuna ait dersler"}
        };
    }
    public void Add(Category category)
    {
        categories.Add(category);
    }

    public void Delete(Category category)
    {
        var deletedCategory = categories.First(c => c.Id == category.Id);
        categories.Remove(deletedCategory);
    }

    public List<Category> GetAll()
    {
        return categories;
    }

    public Category GetById(int id)
    {
       return categories.First(c => c.Id == id);
    }

    public void Update(Category category)
    {
        var updatedCategory = categories.First(c => c.Id == category.Id);
        updatedCategory.Name = category.Name;
        updatedCategory.Description = category.Description;
    }
}
