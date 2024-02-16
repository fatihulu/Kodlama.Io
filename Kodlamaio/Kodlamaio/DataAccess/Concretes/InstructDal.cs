using Kodlamaio.DataAccess.Abstracts;
using Kodlamaio.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kodlamaio.DataAccess.Concretes;

public class InstructDal : IInstructorDal
{
    public List<Instructor> instructors;

    public InstructDal()
    {
        instructors = new List<Instructor>
        {
            new Instructor{Id=1, FirstName="Engin", LastName="Demiroğ", Description="Eğitmen 1", ImagePath="image1"},
            new Instructor{Id=2,FirstName="Fatih",LastName="Ulu",Description="Eğitmen 2", ImagePath="image2"}
        };
    }

    public void Add(Instructor instructor)
    {
        instructors.Add(instructor);
    }

    public void Delete(Instructor instructor)
    {
        var deletedInstructor = instructors.First(i => i.Id == instructor.Id);
        instructors.Remove(deletedInstructor);
    }

    public List<Instructor> GetAll()
    {
        return instructors;
    }

    public Instructor GetById(int id)
    {
        return instructors.First(i => i.Id == id);
    }

    public void Update(Instructor instructor)
    {
        var updatedInstructor = instructors.First(i => i.Id == instructor.Id);
        updatedInstructor.FirstName = instructor.FirstName;
        updatedInstructor.LastName = instructor.LastName;
        updatedInstructor.Description = instructor.Description;
        updatedInstructor.ImagePath = instructor.ImagePath;
    }
}
