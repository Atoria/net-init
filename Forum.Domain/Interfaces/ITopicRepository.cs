using Forum.Models;

namespace Forum.Domain.Interfaces;

public interface ITopicRepository
{
    Task<OperationResult> Create();
    Task<OperationResult> Join();
    Task<OperationResult> GetAll();

}