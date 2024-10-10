using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Model.Request
{
    public class CredentialRequest
    {
        public string email { get; set; } = string.Empty;
        public string password { get; set; } = string.Empty;
    }
}
