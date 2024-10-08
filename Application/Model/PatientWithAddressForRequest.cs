using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Model
{
    public class PatientWithAddressForRequest
    {
        public PatientForRequest? Patient { get; set; }
        public AddressForRequest? Address { get; set; }
    }
}
