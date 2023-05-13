using Forum.Models;

namespace Forum.Domain.Interfaces;

public interface ITopicService
{
    Task<OperationResult> Create();
    Task<OperationResult> Join();
    Task<OperationResult> List();
}