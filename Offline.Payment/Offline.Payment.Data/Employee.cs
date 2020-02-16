using System;
using System.Collections.Generic;

namespace Offline.Payment.Data
{
    public partial class Employee
    {
        public Employee()
        {
            User = new HashSet<User>();
        }

        public int Id { get; set; }
        public int? CompanyId { get; set; }
        public int? EmployeeId { get; set; }
        public string CreatedBy { get; set; }
        public DateTimeOffset? CreatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public DateTimeOffset? UpdatedDate { get; set; }

        public Company Company { get; set; }
        public ICollection<User> User { get; set; }
    }
}
