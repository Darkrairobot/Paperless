using MediatR;
using Paperless.Application.Shared;
using Paperless.Domain.Abstractions;

namespace Paperless.Application.UseCases.User.GetByEmail;

public class Handler(IUserRepository _userRepository) :  IRequestHandler<Command, Result<Domain.Entities.User>>
{
    public async Task<Result<Domain.Entities.User>> Handle(Command request, CancellationToken cancellationToken = default)
    {
        return Result<Domain.Entities.User>.Ok(await _userRepository.GetUserByEmail(request.Email));
    }
}