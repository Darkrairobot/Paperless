using Paperless.Domain.Entities;

namespace Paperless.Domain.Abstractions;

public interface IUserRepository
{
    
    Task<User> GetUserById(string id);
    
    Task<User> GetUserByEmail(string email);
    
    Task<bool> CreateUser(User user, string password);
    
    
}