﻿using Domain.Entities;
using Domain.Enums;
using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Data
{
    public class UserRepository:BaseRepository<User>, IUserRepository
    {
        private readonly ApplicationContext _context;
        public UserRepository(ApplicationContext context) :base(context)
        {
            _context = context;
        }

            public User? GetUserByEmail(string email)
            {
                return _context.Set<User>().SingleOrDefault(u => u.Email == email);
            }
           
    }
}
