using MediatR;
using Microsoft.AspNetCore.Mvc;
using CreateUserCommand = Paperless.Application.UseCases.User.CreateUser.Command;
using GetUserByEmailCommand = Paperless.Application.UseCases.User.GetByEmail.Command;

namespace Paperless.Api.Endpoints;

public static class UserEndpoint
{
    public static WebApplication AddUserEndpoint(this WebApplication app)
    {
        //Criar novo usuário
        app.MapPost("v1/user/register", async (ISender sender, CreateUserCommand request) =>
        {
            var result = await sender.Send(request);
            return Results.Created($"v1/user/register", result);
        });
        
        
        //Pegar Usuário pelo Email
        app.MapGet("v1/user/GetByEmail/{email}", async (ISender sender, string email) =>
        {
            
            GetUserByEmailCommand request = new GetUserByEmailCommand(email);
            
            return Results.Ok(await sender.Send(request));
        });

        return app;
    }
}