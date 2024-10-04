using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Data
{
    public class AppointmentRepository : BaseRepository<Appointment>
    {
        private readonly ApplicationContext _context;
        public AppointmentRepository(ApplicationContext context) : base(context)
        {
            _context = context;
        }
    }
}
