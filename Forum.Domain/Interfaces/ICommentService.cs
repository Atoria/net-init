using Forum.Models;

namespace Forum.Domain.Interfaces;

public interface ICommentService
{
    Task<OperationResult> CreateComment();
    Task<OperationResult> UpdateComment();
    Task<OperationResult> GetComments();
}