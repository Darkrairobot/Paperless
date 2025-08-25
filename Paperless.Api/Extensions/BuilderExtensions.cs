using Paperless.Application;
using Paperless.Infrastructure;

namespace Paperless.Api.Extensions;

public static class BuilderExtensions
{

    public static WebApplicationBuilder AddArchitecture(this WebApplicationBuilder builder)
    {
        
        // Add services to the container.
        // Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
        builder.Services.AddOpenApi();
        
        builder.Services.AddInfrastructure(builder.Configuration);

        builder.Services.AddApplication();
        
        return builder;
    }

    public static WebApplicationBuilder AddServices(this WebApplicationBuilder builder)
    {
        
        return builder;
    }
    
    
}