using Microsoft.AspNetCore.Identity;
using Paperless.Domain.Abstractions;
using Paperless.Domain.Entities;
using Paperless.Infrastructure.Data;
using Paperless.Infrastructure.Identity;

namespace Paperless.Infrastructure.Repositories;

public class UserRepository(SignInManager<ApplicationUser> signInManager, UserManager<ApplicationUser> userManager) :  IUserRepository
{
    public async Task<User> GetUserById(string id)
    {
        return (User)await userManager.FindByIdAsync(id);
    }

    public async Task<User> GetUserByEmail(string email)
    {
        return (User)await userManager.FindByEmailAsync(email);
    }

    public async Task<bool> CreateUser(User user, string password)
    {
        var result = await userManager.CreateAsync((ApplicationUser)user, password);
        return result.Succeeded;
    }
}