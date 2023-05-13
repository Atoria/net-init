using System.Threading.Tasks;
using Forum.Domain.Interfaces;
using Forum.Domain.Requests;
using Forum.Models;
using Microsoft.AspNetCore.Mvc;

namespace Forum.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
   
    public class CommentController : ControllerBase
    {
        private readonly ICommentService _commentService;

        public CommentController(ICommentService commentService)
        {
            _commentService = commentService;
        }

        [HttpGet("")]
        public async Task<OperationResult> GetUserBalance()
        {
            return await _commentService.GetComments();
        }
    
        [HttpPost("")]
        public async Task<OperationResult> UpdateUserInfo([FromBody] UserRequest request)
        {
            return await _commentService.CreateComment();
        }

        [HttpPut("")]
        public async Task<OperationResult> GetUserImage()
        {
            return await _commentService.UpdateComment();
        }
    }
}
