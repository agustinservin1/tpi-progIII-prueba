using Domain.Entities;
using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Data
{
    public class AppointmentRepository : BaseRepository<Appointment>, IAppointmentRepository
    {
        private readonly ApplicationContext _context;
        public AppointmentRepository(ApplicationContext context) : base(context)
        {
            _context = context;
        }
    }
}
