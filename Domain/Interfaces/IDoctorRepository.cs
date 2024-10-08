﻿using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces
{
    public interface IDoctorRepository : IBaseRepository<Doctor>
    {
        Doctor? GetByIdIncludeAddress(int id);
        IEnumerable<Doctor> GetAllDoctorWithAddress();
        Doctor DeleteDoctor (int id);   
    }
}
