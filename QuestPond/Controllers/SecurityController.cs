#region This file contains description of Security Controller.
/* This file contains defnition of Methods related to Security of application like JWT,Doctor Login and Decrypt Password.
 */
#endregion

using System;
using System.Security.Claims;
using System.Text;
using FewaTelemedicine.Domain;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace FewaTelemedicine.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SecurityController : ControllerBase
    {
        private QuestPondDbContext FewaDbContext = null;
        private readonly IConfiguration _config;

        public SecurityController(
            IConfiguration config,
            QuestPondDbContext fewaDbContext
            )
        {
            FewaDbContext = fewaDbContext;
            _config = config;
        }

        [HttpPost("Login")]
        public ActionResult Login()
        {
            try
            { 
                return Ok();
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex);
            }
        }


    }
}