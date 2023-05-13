using Forum.Domain.Interfaces;
using Forum.Models;

namespace Forum.Domain.Services;

public class CommentService : ICommentService
{
    private readonly ICommentService _commentRepository;

    public CommentService(ICommentService commentRepository)
    {
        _commentRepository = commentRepository;
    }

    public Task<OperationResult> CreateComment()
    {
        throw new NotImplementedException();
    }

    public Task<OperationResult> UpdateComment()
    {
        throw new NotImplementedException();
    }

    public Task<OperationResult> GetComments()
    {
        throw new NotImplementedException();
    }
}