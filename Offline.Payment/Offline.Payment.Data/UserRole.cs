using System;
using System.Collections.Generic;

namespace Offline.Payment.Data
{
    public partial class UserRole
    {
        public int Id { get; set; }
        public string Type { get; set; }
        public string CreatedBy { get; set; }
        public DateTimeOffset? CreatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public DateTimeOffset? UpdatedDate { get; set; }
    }
}
