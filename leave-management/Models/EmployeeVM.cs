using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace leave_management.Models
{
    public class EmployeeVM
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string Lastname { get; set; }
        public int TaxID { get; set; }
        public DateTime DateOfBirth { get; set; }
        public DateTime DateJoined { get; set; }
        public DateTime DateCreated { get; set; }
    }
}
