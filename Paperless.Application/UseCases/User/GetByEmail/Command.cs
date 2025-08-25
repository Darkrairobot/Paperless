using MediatR;
using Paperless.Application.Shared;

namespace Paperless.Application.UseCases.User.GetByEmail;

public record Command(string Email) : IRequest<Result<Domain.Entities.User>>
{
    
}