using Domain.Entities;
using Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces
{
    public interface IUserRepository:IBaseRepository<User>
    {
        User? GetUserByEmail(string email);
        User? Authenticate(string email, string password);
    }
}
