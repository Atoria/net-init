using Forum.Domain.Interfaces;
using Forum.Models;

namespace Forum.Domain.Services;

public class UserService: IUserService
{
    private readonly IUserService _userRepository;

    public UserService(IUserService userRepository)
    {
        _userRepository = userRepository;
    }    
    public Task<OperationResult> Create()
    {
        throw new NotImplementedException();
    }

    public Task<OperationResult> Update()
    {
        throw new NotImplementedException();
    }
}