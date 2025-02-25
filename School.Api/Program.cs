using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using School.Api.Middlewarees;
using School.Application.Services;
using School.Application.Services.Impl;
using School.Application.Validations;
using School.Domain.Repository;
using School.Domain.Shared;
using School.Infrastructure.DataAcces;
using School.Infrastructure.Repository;
using School.Infrastructure.Shared;
using School.Infrastructure.Validations;
using System.Text;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<SchoolDbContext>(options => options.UseSqlServer("Server=DESKTOP-2IJ9EH5;Database=SchoolDb;Trusted_Connection=True;TrustServerCertificate=True;"));
builder.Services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
builder.Services.AddScoped<IStudentServices, StudentServices>();
builder.Services.AddScoped<ILoginservice, Loginservice>();
builder.Services.AddScoped<IStudentValidations, StudentValidations>();
builder.Services.AddScoped<IToken, Token>();


var secretKey = "TuClaveSecretaMuySeguraYConMasDe32Caracteres1234";
var key = Encoding.UTF8.GetBytes(secretKey);

builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
	.AddJwtBearer(options =>
	{
		options.RequireHttpsMetadata = false;
		options.SaveToken = true;
		options.TokenValidationParameters = new TokenValidationParameters
		{
			ValidateIssuerSigningKey = true,
			IssuerSigningKey = new SymmetricSecurityKey(key),
			ValidateIssuer = true,
			ValidateAudience = true,
			ValidIssuer = "TuIssuer",
			ValidAudience = "TuAudience",
			ValidateLifetime = true,
			ClockSkew = TimeSpan.Zero
		};
	});

builder.Services.AddAuthorization();
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
app.UseMiddleware<Middleware>();

app.MapControllers();

app.Run();
