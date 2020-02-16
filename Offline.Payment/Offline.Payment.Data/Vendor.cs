using System;
using System.Collections.Generic;

namespace Offline.Payment.Data
{
    public partial class Vendor
    {
        public Vendor()
        {
            User = new HashSet<User>();
            UserTransaction = new HashSet<UserTransaction>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string CreatedBy { get; set; }
        public DateTimeOffset? CreatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public DateTimeOffset? UpdatedDate { get; set; }

        public ICollection<User> User { get; set; }
        public ICollection<UserTransaction> UserTransaction { get; set; }
    }
}
