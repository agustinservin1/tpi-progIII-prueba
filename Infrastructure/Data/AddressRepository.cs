using Domain.Entities;
using Domain.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Data
{
    public class AddressRepository : BaseRepository<Address>, IAddressRepository
    {
        private readonly ApplicationContext _context;
        public AddressRepository(ApplicationContext context) : base(context)
        {
            _context = context;
        }
    }
}
