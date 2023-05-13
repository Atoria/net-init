using System.Threading.Tasks;
using Forum.Domain.Interfaces;
using Forum.Domain.Requests;
using Forum.Models;
using Microsoft.AspNetCore.Mvc;

namespace Forum.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
   
    public class TopicController : ControllerBase
    {
        private readonly ITopicService _topicService;

        public TopicController(ITopicService topicService)
        {
            _topicService = topicService;
        }

        [HttpGet("")]
        public async Task<OperationResult> GetUserBalance()
        {
            return await _topicService.List();
        }
    
        [HttpPost("")]
        public async Task<OperationResult> UpdateUserInfo([FromBody] UserRequest request)
        {
            return await _topicService.Create();
        }

        [HttpPost("join")]
        public async Task<OperationResult> GetUserImage()
        {
            return await _topicService.Join();
        }
    }
}
