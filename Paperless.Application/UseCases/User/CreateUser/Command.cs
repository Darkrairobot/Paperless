using MediatR;
using Paperless.Application.Shared;

namespace Paperless.Application.UseCases.User.CreateUser;

public record Command : IRequest<Result<Domain.Entities.User>>
{
    public string Name { get; init; }
    
    public string Password { get; init; }
    
    public string Email { get; init; }
    
    public string CPF_CNPJ { get; init; }

    public static explicit operator Domain.Entities.User(Command command)
    {
        return new Domain.Entities.User()
        {
            Name = command.Name,
            Email = command.Email,
            CPF_CNPJ = command.CPF_CNPJ,
        };
    }
}