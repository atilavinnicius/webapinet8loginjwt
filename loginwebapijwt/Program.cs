using loginwebapijwt.Data;
using loginwebapijwt.Data.Repositories;
using loginwebapijwt.Data.Repositories.Interfaces;
using loginwebapijwt.Services;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

builder.Services.AddScoped<IUserRepository, UserRepository>();

var jwtTokenService = new JwtTokenService(builder.Configuration);
jwtTokenService.AddJwtAuthentication(builder.Services);
builder.Services.AddSingleton(jwtTokenService);

var app = builder.Build();

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
