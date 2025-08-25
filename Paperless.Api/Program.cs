using Paperless.Api.Extensions;
using Paperless.Application;
using Paperless.Infrastructure;

var builder = WebApplication.CreateBuilder(args);

builder.AddArchitecture().AddServices();

var app = builder.Build();

app.UseArchitecture().AddEndpoint();

app.Run();

