using System.Threading.Tasks;
using Forum.Domain.Interfaces;
using Forum.Domain.Requests;
using Forum.Models;
using Microsoft.AspNetCore.Mvc;

namespace Forum.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
   
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpGet("")]
        public async Task<OperationResult> GetUserBalance()
        {
            return await _userService.Create();
        }
    
        [HttpGet("{id}")]
        public async Task<OperationResult> UpdateUserInfo([FromBody] UserRequest request)
        {
            return null;
        }

        [HttpPost("")]
        public async Task<OperationResult> GetUserImage()
        {
            return null;
        }

        [HttpPut("")]
        public async Task<OperationResult> SetCloudToken()
        {
            return null;

        }
    }
}
