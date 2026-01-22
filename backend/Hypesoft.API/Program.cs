using Hypesoft.Application.Commands.CreateUser;
using MediatR;
using FluentValidation;
using FluentValidation.AspNetCore;
using Hypesoft.Application.Validators;
using Hypesoft.Domain.Repositories;
using Hypesoft.Infrastructure.Data;
using Hypesoft.Infrastructure.Repositories;
using MongoDB.Driver;
using Hypesoft.Infrastructure;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using Hypesoft.Domain.Repositories;
using Hypesoft.Infrastructure.Repositories;



var builder = WebApplication.CreateBuilder(args);

// Controllers
builder.Services.AddControllers();

// Swagger
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// MediatR (Application layer)
builder.Services.AddMediatR(
    typeof(Hypesoft.Application.Commands.CreateUser.CreateUserCommand).Assembly
);

builder.Services.AddScoped<IUserRepository, UserRepository>();
builder.Services.AddScoped<IProductRepository, ProductRepository>();
builder.Services.AddScoped<ICategoryRepository, CategoryRepository>();


builder.Services.AddFluentValidationAutoValidation();
builder.Services.AddValidatorsFromAssembly(
    typeof(CreateUserCommandValidator).Assembly
);

builder.Services.AddSingleton(sp =>
{
    var configuration = sp.GetRequiredService<IConfiguration>();
    var connectionString = configuration["MongoDb:ConnectionString"];
    var databaseName = configuration["MongoDb:Database"];

    return new MongoDbContext(connectionString!, databaseName!);
});

builder.Services.AddSingleton<IMongoDatabase>(sp =>
    sp.GetRequiredService<MongoDbContext>().Database
);

builder.Services.AddScoped<IUserRepository, UserRepository>();

builder.Services.AddInfrastructure();

builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
    .AddJwtBearer(options =>
    {
        options.Authority = "http://localhost:8080/realms/hypesoft";
        options.Audience = "hypesoft-api";
        options.RequireHttpsMetadata = false;

        options.TokenValidationParameters = new TokenValidationParameters
        {
            ValidateIssuer = true,
            ValidateAudience = true,
            ValidateLifetime = true
        };
    });

builder.Services.AddAuthorization();



var app = builder.Build();

app.UseAuthentication();
app.UseAuthorization();


// Pipeline HTTP
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
