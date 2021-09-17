using System;
using System.Collections.Generic;

#nullable disable

namespace DALPro.Models
{
    public partial class Employer
    {
        public int EmployerId { get; set; }
        public string EmployerPwd { get; set; }
        public string EmployerName { get; set; }
        public string EmployerInfo { get; set; }
        public string EmployerClients { get; set; }
        public string Email { get; set; }
    }
}
