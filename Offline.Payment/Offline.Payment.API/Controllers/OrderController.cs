using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Offline.Payment.Business.Models;
using Offline.Payment.Business.Services;

namespace Offline.Payment.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        IUserTransactionService _userTransactionService;
        public OrderController(IUserTransactionService userTransactionService)
        {
            _userTransactionService = userTransactionService;
        }
      
        [HttpGet]
        public async Task<IEnumerable<UserTransaction>> Get(int userId)
        {
            return await _userTransactionService.GetAll(userId);
        }
       
        [HttpPost]
        [ProducesResponseType(200, Type = typeof(UserTransaction))]
        [ProducesResponseType(400)]
        public async Task<UserTransaction> Create([FromBody]UserTransaction userTransaction)
        {
            return await _userTransactionService.Create(userTransaction);
        }
    }
}