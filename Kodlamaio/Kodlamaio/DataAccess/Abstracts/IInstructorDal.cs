﻿using Kodlamaio.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kodlamaio.DataAccess.Abstracts;

public interface IInstructorDal
{
    List<Instructor> GetAll();
    Instructor GetById(int id);
    void Add(Instructor instructor);
    void Delete(Instructor instructor);
    void Update(Instructor instructor);
}
