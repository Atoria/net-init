using Forum.Domain.Interfaces;
using Forum.Models;

namespace Forum.Domain.Repositories;

public interface  ICommentRepository
{
    public Task<OperationResult> Create()
    {
        throw new NotImplementedException();
    }

    public Task<OperationResult> Update()
    {
        throw new NotImplementedException();
    }

    public Task<OperationResult> Delete()
    {
        throw new NotImplementedException();
    }

    public Task<OperationResult> GetAll()
    {
        throw new NotImplementedException();
    }
}