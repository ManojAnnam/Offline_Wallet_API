using System;
using System.Collections.Generic;
using System.Text;

namespace Offline.Payment.Business.Models
{
   public class UserTransaction
    {
        public int Id { get; set; }
        public int? UserId { get; set; }
        public int? VendorId { get; set; }
        public decimal? Amount { get; set; }
        public string TransactionType { get; set; }
    }
}
