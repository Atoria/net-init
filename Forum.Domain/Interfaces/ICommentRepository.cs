using Forum.Models;

namespace Forum.Domain.Interfaces;

public interface ICommentRepository
{
    Task<OperationResult> Create();
    Task<OperationResult> Update();
    Task<OperationResult> Delete();
    Task<OperationResult> GetAll();
}