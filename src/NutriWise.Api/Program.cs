using Microsoft.EntityFrameworkCore;
using NutriWise.Infrastructure.Database;

namespace NutriWise;

public class Program
{
	public static void Main(string[] args)
	{
		var builder = WebApplication.CreateBuilder(args);

		var connectionString = builder.Configuration.GetConnectionString("Default");
		builder.Services.AddDbContext<AppDbContext>(options => options.UseNpgsql(connectionString));
		
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
		app.UseAuthorization();

		app.Run();
	}
}