using Offline.Payment.Business.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Offline.Payment.Business.Services
{
   public interface IUserTransactionService
    {
        Task<List<UserTransaction>> GetAll(int userId);
        Task<UserTransaction> Create(UserTransaction userTransaction);
    }
}
