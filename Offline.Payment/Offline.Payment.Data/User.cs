using System;
using System.Collections.Generic;

namespace Offline.Payment.Data
{
    public partial class User
    {
        public User()
        {
            UserTransaction = new HashSet<UserTransaction>();
        }

        public int Id { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Phone { get; set; }
        public string EmailId { get; set; }
        public decimal? Balance { get; set; }
        public int? EmployeeId { get; set; }
        public int? VendorId { get; set; }

        public Employee Employee { get; set; }
        public Vendor Vendor { get; set; }
        public ICollection<UserTransaction> UserTransaction { get; set; }
    }
}
