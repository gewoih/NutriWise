using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using NutriWise.Domain.Entities.Identity;
using NutriWise.Infrastructure.Database;

namespace NutriWise;

public class Program
{
	public static void Main(string[] args)
	{
		var builder = WebApplication.CreateBuilder(args);

		builder.Services.AddControllers();
		
		var connectionString = builder.Configuration.GetConnectionString("Default");
		builder.Services.AddDbContext<AppDbContext>(options => options.UseNpgsql(connectionString));

		builder.Services.AddIdentity<User, Role>()
			.AddEntityFrameworkStores<AppDbContext>()
			.AddDefaultTokenProviders();

		builder.Services.Configure<IdentityOptions>(options =>
		{
			options.Password.RequireDigit = true;
			options.Password.RequireLowercase = true;
			options.Password.RequireUppercase = true;
			options.Password.RequireNonAlphanumeric = false;
			options.Password.RequiredLength = 8;
		});

		builder.Services.AddAuthentication(options =>
			{
				options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
				options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
			})
			.AddGoogle(options =>
			{
				options.ClientId = "633948126557-rqver9vq5bjbkoq8hqqjj5f4phndefmb.apps.googleusercontent.com";
				options.ClientSecret = "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";
				options.CallbackPath = "/api/auth/google-callback";
			})
			.AddJwtBearer(options =>
		{
			options.TokenValidationParameters = new TokenValidationParameters
			{
				ValidateIssuer = false,
				ValidateAudience = false,
				ValidateLifetime = true,
				ValidateIssuerSigningKey = true,
				IssuerSigningKey = new SymmetricSecurityKey("k3d34kCYECVNl02kINQUlIoW75TXcgFkJAhtEam7Nvk="u8.ToArray())
			};
		});
		
		builder.Services.AddCors(options =>
		{
			options.AddPolicy("AllowSpecificOrigin", configure =>
				configure.WithOrigins("http://localhost:8080")
					.AllowAnyMethod()
					.AllowAnyHeader());
		});


		builder.Services.AddAuthorization();

		builder.Services.AddEndpointsApiExplorer();
		builder.Services.AddSwaggerGen();

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
	}
}