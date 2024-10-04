﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.DTO
{
    public class PatientForRequest
    {
        public string Name { get; set; } = string.Empty;
        public string LastName {  get; set; } = string.Empty;
        public string PhoneNumber {  get; set; } = string.Empty;    
        public DateTime DateOfBirth { get; set; } 
    }
}
