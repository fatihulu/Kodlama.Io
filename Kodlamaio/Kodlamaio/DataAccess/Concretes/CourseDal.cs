using Kodlamaio.DataAccess.Abstracts;
using Kodlamaio.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kodlamaio.DataAccess.Concretes;

public class CourseDal : ICourseDal
{
    public List<Course> courses;
    public CourseDal()
    {
        courses = new List<Course>()
            {
                new Course {Id=1, Name="Asp.NET",Description=".NET 8 v.s....",Price=0,InstructorId=1,CategoryId=1},
                new Course {Id=2, Name="Java",Description="Java Serisi",Price=10,InstructorId=2,CategoryId=2 },
                new Course {Id=3, Name="React",Description="React Serisi",Price=20,InstructorId=2,CategoryId=3 }
            };
    }
    public void Add(Course course)
    {
        courses.Add(course);
    }

    public void Delete(Course course)
    {
        var deletedCourse = courses.First(c => c.Id == course.Id);
        courses.Remove(deletedCourse);
    }

    public List<Course> GetAll()
    {
        return courses;
    }

    public Course GetById(int id)
    {
       return courses.First(c => c.Id == id);
    }

    public void Update(Course course)
    {
        var updatedCourse = courses.First(c => c.Id == course.Id);
        updatedCourse.Name = course.Name;
        updatedCourse.Description = course.Description;
        updatedCourse.Price = course.Price;
        updatedCourse.ImagePath = course.ImagePath;
        updatedCourse.InstructorId = course.InstructorId;
        updatedCourse.CategoryId = course.CategoryId;
    }
}
