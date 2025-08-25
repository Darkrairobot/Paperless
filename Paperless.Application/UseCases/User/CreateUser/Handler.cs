using MediatR;
using Paperless.Application.Shared;
using Paperless.Domain.Abstractions;

namespace Paperless.Application.UseCases.User.CreateUser;

public class Handler(IUserRepository _userRepository) : IRequestHandler<Command, Result<Domain.Entities.User>>
{
    public async Task<Result<Domain.Entities.User>> Handle(Command request, CancellationToken cancellationToken = default)
    {
        if (request.Name == String.Empty) return Result<Domain.Entities.User>.Fail("Nome não pode ser nulo");

        if (await _userRepository.CreateUser((Domain.Entities.User)request, request.Password) == false)
        {
            return Result<Domain.Entities.User>.Fail("Não foi possivel criar usuário");
        }
        
        return Result<Domain.Entities.User>.Ok(null);
    }
}