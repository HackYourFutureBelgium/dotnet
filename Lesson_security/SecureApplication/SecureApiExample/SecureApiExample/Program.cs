using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using SecureApiExample.DataLayer;
using System.Security.Claims;
using SecureApiExample.Services;
using Microsoft.AspNetCore.Authorization;

var builder = WebApplication.CreateBuilder(args);


// Add services to the container.
builder.Services.AddSingleton<ITodoRepository, TodoRepository>();
builder.Services.AddSingleton<IAuthorizationHandler, HasScopeHandler>();

builder.Services.AddCors(options =>
{
    options.AddDefaultPolicy(
        policy =>
        {
            policy.AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod();
        });
});

builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
    .AddJwtBearer(options =>
    {
        options.Authority = $"https://{builder.Configuration["Auth0:Domain"]}/";
        options.Audience = builder.Configuration["Auth0:Audience"];
        options.TokenValidationParameters = new TokenValidationParameters
        {
            NameClaimType = ClaimTypes.NameIdentifier
        };
    });


builder.Services.AddAuthorization(options =>
{
    options.AddPolicy(
        "todo:read",
        policy => policy.Requirements.Add(
            new HasScopeRequirement("todo:read", $"https://{builder.Configuration["Auth0:Domain"]}/")
        )
    );
    options.AddPolicy(
        "todo:write",
        policy => policy.Requirements.Add(
            new HasScopeRequirement("todo:write", $"https://{builder.Configuration["Auth0:Domain"]}/")
        )
    );
    options.AddPolicy(
        "todo:delete",
        policy => policy.Requirements.Add(
            new HasScopeRequirement("todo:delete", $"https://{builder.Configuration["Auth0:Domain"]}/")
        )
    );
});

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

app.UseCors();
app.UseAuthentication();
app.UseAuthorization();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.MapControllers();

app.Run();
