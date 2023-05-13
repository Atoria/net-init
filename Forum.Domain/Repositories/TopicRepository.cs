using Forum.Domain.Interfaces;
using Forum.Models;

namespace Forum.Domain.Repositories;

public class TopicRepository: ITopicRepository
{

    public Task<OperationResult> Create()
    {
        throw new NotImplementedException();
    }

    public Task<OperationResult> Join()
    {
        throw new NotImplementedException();
    }

    public Task<OperationResult> GetAll()
    {
        throw new NotImplementedException();
    }
}