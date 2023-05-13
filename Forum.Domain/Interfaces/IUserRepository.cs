using Forum.Models;

namespace Forum.Domain.Interfaces;

public interface IUserRepository
{
    Task<OperationResult> Create();
    Task<OperationResult> Update();

}