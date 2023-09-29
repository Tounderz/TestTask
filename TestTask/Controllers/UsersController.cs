using Microsoft.AspNetCore.Mvc;
using TestTask.Services.Interfaces;

namespace TestTask.Controllers
{
    /// <summary>
    /// Users controller.
    /// DO NOT change anything here. Use created contract and provide only needed implementation.
    /// </summary>
    [Route("api/v1/users")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IUserService userService;

        public UsersController(IUserService userService)
        {
            this.userService = userService;
        }

        /// <summary>
        /// Returns selected user. 
        /// Selection rules are specified in Task description provided by recruiter
        /// </summary>
        [HttpGet]
        [Route("selected-user")]
        public async Task<IActionResult> Get()
        {
            var result = await this.userService.GetUser();
            if (result == null)
            {
                return BadRequest(new { message = "There are no users with orders" });
            }

            return this.Ok(result);
        }

        /// <summary>
        /// Returns list of selected users. 
        /// Selection rules are specified in Task description provided by recruiter
        /// </summary>
        [HttpGet]
        [Route("selected-users")]
        public async Task<IActionResult> GetUsers()
        {
            var result = await this.userService.GetUsers();
            if (result == null)
            {
                return BadRequest(new { message = "There are no users with the status Inaсtive" });
            }

            return this.Ok(result);
        }
    }
}
