// See https://aka.ms/new-console-template for more information
using Kodlamaio.Business.Abstracts;
using Kodlamaio.Business.Concretes;
using Kodlamaio.DataAccess.Abstracts;
using Kodlamaio.DataAccess.Concretes;
using Kodlamaio.Entities;


#region Course İşlemleri
Console.WriteLine("KURS İŞLEMLERİ");

ICourseService courseManager = new CourseManager(new CourseDal());

courseManager.Add(new Course() { Id = 4, Name = "Pythonn", Description = "Python Serisi,", Price = 25, CategoryId = 4, InstructorId = 1 });

courseManager.Update(new Course() { Id = 4, Name = "Python", Description = "Python Serisi", Price = 30, CategoryId = 4, InstructorId = 1 });

courseManager.Delete(new Course() { Id = 3 });

List<Course> courses = courseManager.GetAll();
for (int i = 0; i < courses.Count; i++)
{
    Console.WriteLine(courses[i].Name + " / " + courses[i].Description + " / " + courses[i].InstructorId + " / " + courses[i].Price + "TL");
}

#endregion

Console.WriteLine("\n");
Console.WriteLine("KATEGORİ İŞLEMLERİ");

#region Category İşlemleri

ICategoryService categoryManager = new CategoryManager(new CategoryDal());

categoryManager.Add(new Category() { Id = 4, Name = "Pythonn ", Description = "Pythonn Kursuna Ait Dersler," });

categoryManager.Update(new Category() { Id = 4, Name = "Python", Description = "Python Kursuna Ait Dersler" });

categoryManager.Delete(new Category() { Id = 3 });

List<Category> categories = categoryManager.GetAll();
for (int i = 0; i < categories.Count; i++)
{
    Console.WriteLine(categories[i].Name + " / " + categories[i].Description);
}

#endregion

Console.WriteLine("\n");

Console.WriteLine("EĞİTMEN İŞLEMLERİ");

#region Instructor İşlemleri

IInstructerService instructerManager = new InstructorManager(new InstructDal());

instructerManager.Add(new Instructor() { Id = 3, FirstName = "Mustafa Eymenn", LastName = "Uluu", Description = "Eğitmenn 3", ImagePath = "imagee 3" });

instructerManager.Update(new Instructor() { Id = 3, FirstName = "Mustafa Eymen", LastName = "Ulu", Description = "Eğitmen 3", ImagePath = "image 3" });

instructerManager.Delete(new Instructor() { Id = 3 });

List<Instructor> instructors = instructerManager.GetAll();
for (int i = 0; i < instructors.Count; i++)
{
    Console.WriteLine(instructors[i].FirstName + " / " + instructors[i].LastName + " / " + instructors[i].Description);
}

#endregion


Console.ReadLine();