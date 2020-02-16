using System;
using System.Collections.Generic;

namespace Offline.Payment.Data
{
    public partial class UserTransaction
    {
        public int Id { get; set; }
        public int? UserId { get; set; }
        public int? VendorId { get; set; }
        public decimal? Amount { get; set; }
        public string TransactionType { get; set; }
        public string CreatedBy { get; set; }
        public DateTimeOffset? CreatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public DateTimeOffset? UpdatedDate { get; set; }

        public User User { get; set; }
        public Vendor Vendor { get; set; }
    }
}
