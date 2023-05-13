using Forum.Models;

namespace Forum.Domain.Interfaces;

public interface IUserService
{
    Task<OperationResult> Create();
    Task<OperationResult> Update();
}