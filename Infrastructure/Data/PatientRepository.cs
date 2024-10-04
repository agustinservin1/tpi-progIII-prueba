﻿using Domain.Entities;
using Domain.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Data
{
    public class PatientRepository : BaseRepository<Patient>, IPatientRepository
    {
        private readonly ApplicationContext _context;
        public PatientRepository(ApplicationContext context) : base(context) 
        {
            _context = context;
        }
    }
}

