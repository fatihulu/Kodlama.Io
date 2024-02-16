using Kodlamaio.Business.Abstracts;
using Kodlamaio.DataAccess.Abstracts;
using Kodlamaio.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kodlamaio.Business.Concretes;

public class CourseManager : ICourseService
{
    //Dependncy Injection: Bir sınıfa bağlı kalmamak için yapılır.
    private readonly ICourseDal _courseDal;
    public CourseManager(ICourseDal courseDal)
    {
        _courseDal = courseDal;
    }

    public List<Course> GetAll()
    {
        //Busines rules
        return _courseDal.GetAll();
    }

    public void Add(Course course)
    {
        _courseDal.Add(course);
    }

    public void Delete(Course course)
    {
        _courseDal.Delete(course);
    }

    public void Update(Course course)
    {
        _courseDal.Update(course);
    }

    public Course GetById(int id)
    {
        return _courseDal.GetById(id);
    }
}
