using CookingApi.Models;
using CookingApi.Sevices.Accountapi;
using Microsoft.AspNetCore.Mvc;
using MyBackEnd.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CookingApi.Controllers
{
    [Route("login")]
    public class AccountController : Controller
    {
        private AccountService acc;

        public AccountController(AccountService _acc)
        {
            acc = _acc;
        }
        [Produces("application/json")]
        [HttpGet("create")]
        public IActionResult Create(Account account)
        {
            try
            {
                return Ok(acc.Create(account));
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }
        [Produces("application/json")]
        [HttpPost("login")]
        public IActionResult Login([FromBody] Login request)
        {
            try
            {
                return Ok(acc.Login(request));
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }

        [Produces("application/json")]
        [HttpPost("register")]
        public IActionResult Register([FromBody] Register request)
        {
            try
            {
                return Ok(acc.Register(request));
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }
    }
}
