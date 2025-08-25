using Paperless.Api.Endpoints;

namespace Paperless.Api.Extensions;

public static class AppExtensions
{
    public static WebApplication UseArchitecture(this WebApplication app)
    {
        
        // Configure the HTTP request pipeline.
        if (app.Environment.IsDevelopment())
        {
            app.MapOpenApi();
        }

        app.UseHttpsRedirection();
        
        return app;
    }

    public static WebApplication AddEndpoint(this WebApplication app)
    {

        app.AddUserEndpoint();
        
        return app;
    }
    
}