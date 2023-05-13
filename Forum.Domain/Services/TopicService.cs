using Forum.Domain.Interfaces;
using Forum.Models;

namespace Forum.Domain.Services;

public class TopicService : ITopicService
{
    private readonly ITopicService _topicRepository;

    public TopicService(ITopicService topicRepository)
    {
        _topicRepository = topicRepository;
    }

    public Task<OperationResult> Create()
    {
        throw new NotImplementedException();
    }

    public Task<OperationResult> Join()
    {
        throw new NotImplementedException();
    }

    public Task<OperationResult> List()
    {
        throw new NotImplementedException();
    }
}