using Kodlamaio.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kodlamaio.DataAccess.Abstracts;

public interface ICourseDal
{
    List<Course> GetAll();
    Course GetById(int id);
    void Add(Course course);
    void Update(Course course);
    void Delete(Course course);
}
