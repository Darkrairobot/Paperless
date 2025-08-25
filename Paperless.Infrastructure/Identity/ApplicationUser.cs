using Microsoft.AspNetCore.Identity;
using Paperless.Domain.Entities;

namespace Paperless.Infrastructure.Identity;

public class ApplicationUser : IdentityUser
{
    public string Name { get; set; }

    public static explicit operator User(ApplicationUser user)
    {
        return new User
        {
            CPF_CNPJ = user.UserName,
            Email = user.Email,
            Name = user.Name,
            Id = user.Id
        };
    }

    public static explicit operator ApplicationUser(User user)
    {
        return new ApplicationUser()
        {
            Email = user.Email,
            UserName = user.CPF_CNPJ,
            Name = user.Name,
        };
    }
    
}