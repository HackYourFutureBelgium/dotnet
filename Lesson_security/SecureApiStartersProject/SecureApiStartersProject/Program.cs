using Microsoft.AspNetCore.Authorization;
using SecureApiStartersProject.DataLayer;
using SecureApiStartersProject.Services;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using System.Security.Claims;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddSingleton<ITodoRepository, TodoRepository>();
builder.Services.AddSingleton<IAuthorizationHandler, HasScopeHandler>();

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
            new HasScopeRequirement($"https://{builder.Configuration["Auth0:Domain"]}/", "todo:read")
        )
    );
    options.AddPolicy(
        "todo:write",
        policy => policy.Requirements.Add(
            new HasScopeRequirement($"https://{builder.Configuration["Auth0:Domain"]}/", "todo:write")
        )
    );
    options.AddPolicy(
        "todo:delete",
        policy => policy.Requirements.Add(
            new HasScopeRequirement($"https://{builder.Configuration["Auth0:Domain"]}/", "todo:delete")
        )
    );
});

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();

app.Run();
