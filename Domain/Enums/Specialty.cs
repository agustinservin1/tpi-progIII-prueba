using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Enums
{

    public enum Specialty
    {
        [EnumMember(Value = "Pediatrics")]
        Pediatrics,
        [EnumMember(Value = "Cardiology")]
        Cardiology,
        [EnumMember(Value = "Dermatology")]
        Dermatology,
        [EnumMember(Value = "Neurology")]
        Neurology,
        [EnumMember(Value = "Orthopedics")]
        Orthopedics,
        [EnumMember(Value = "Gynecology")]
        Gynecology,
        [EnumMember(Value = "Ophthalmology")]
        Ophthalmology,
        [EnumMember(Value = "Psychiatry")]
        Psychiatry,
        [EnumMember(Value = "Endocrinology")]
        Endocrinology,
        [EnumMember(Value = "Urology")]
        Urology,
        [EnumMember(Value = "Gastroenterology")]
        Gastroenterology,
        [EnumMember(Value = "Rheumatology")]
        Rheumatology,
        [EnumMember(Value = "Pulmonology")]
        Pulmonology,
        [EnumMember(Value = "Otolaryngology")]
        Otolaryngology,
        

    }
}
