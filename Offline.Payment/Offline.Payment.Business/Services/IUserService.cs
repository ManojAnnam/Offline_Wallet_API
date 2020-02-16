using Offline.Payment.Business.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Offline.Payment.Business.Services
{
    public interface IUserService
    {
        User Authenticate(string username, string password);
        IEnumerable<User> GetAll();
    }
}
