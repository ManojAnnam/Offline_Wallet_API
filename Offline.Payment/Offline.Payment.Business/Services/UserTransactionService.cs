using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Offline.Payment.Business.Models;

namespace Offline.Payment.Business.Services
{
    public class UserTransactionService 
    {
        public Task<UserTransaction> Create(UserTransaction userTransaction)
        {
            throw new NotImplementedException();
        }

        public Task<List<UserTransaction>> GetAll(int userId)
        {
            throw new NotImplementedException();
        }
    }
}
