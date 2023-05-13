using Forum.Domain.Interfaces;
using Forum.Models;

namespace Forum.Domain.Repositories;

public class UserRepository: IUserRepository
{
    public Task<OperationResult> Create()
    {
        throw new NotImplementedException();
    }

    public Task<OperationResult> Update()
    {
        throw new NotImplementedException();
    }
}