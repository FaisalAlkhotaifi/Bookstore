using Api.Middlewares;
using Application;
using Domain.Entities.Account;
using Microsoft.AspNetCore.Identity;
using Model;
using Model.Common;
using Persistence;

var builder = WebApplication.CreateBuilder(args);

string MyAllowSpecificOrigins = "_myAllowSpecificOrigins";

// Add services to the container.
{
    var services = builder.Services;
    var env = builder.Environment;
    var config = builder.Configuration;

    // configure DI for application services in (Application and Persistence)
    services.AddApplicationServices();
    services.AddPresistenceServices(config);
    services.AddModelServices();

    // configure strongly typed settings object
    services.Configure<AppSettings>(config.GetSection("AppSettings"));

    builder.Services.AddControllers();

    // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
    builder.Services.AddEndpointsApiExplorer();
    builder.Services.AddSwaggerGen();
}

var app = builder.Build();

// Configure the HTTP request pipeline.
{
    if (app.Environment.IsDevelopment())
    {
        app.UseSwagger();
        app.UseSwaggerUI();
    }

    app.Use(async (context, next) =>
    {
        await next();

        if (context.Response.StatusCode == 404 && !Path.HasExtension(context.Request.Path.Value))
        {
            context.Request.Path = "/index.html";
            await next();
        }
    });

    app.UseDefaultFiles();
    app.UseStaticFiles();

    // global cors policy
    app.UseCors(x => x
        .AllowAnyOrigin()
        .AllowAnyMethod()
        .AllowAnyHeader());

    app.UseHttpsRedirection();
    
    app.UseAuthorization();

    // global error handler
    app.UseMiddleware<ExceptionHandlerMiddleware>();

    // custom jwt token auth middleware
    app.UseMiddleware<JwtTokenMiddleware>();

    app.MapControllers();
}

app.Run();
