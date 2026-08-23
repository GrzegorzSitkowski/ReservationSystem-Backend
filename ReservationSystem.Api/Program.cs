
using ReservationSystem.Infrastructure;

namespace ReservationSystem.Api
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddCors(options =>
            {
                options.AddPolicy(name:"MyAllowSpecificOrigins",
                builder =>
                {
                    builder.AllowAnyOrigin(); //withOrigins("http://localhost:3000", "https://localhost:3000") <- example
                });
            });
            builder.Services.AddInfrastructure(builder.Configuration);
            builder.Services.AddControllers();
            builder.Services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new Microsoft.OpenApi.Models.OpenApiInfo
                {
                    Title = "ReservationSystem",
                    Version = "v1",
                    Description = "Web apllication to book of services.",
                    Contact = new Microsoft.OpenApi.Models.OpenApiContact
                    {
                        Name = "Grzegorz",
                        Email = "sitkowskigrzegorz8@gmail.com"
                    }
                });
            });

            builder.Services.AddHealthChecks();

            builder.Services.AddOpenApi();

            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.MapOpenApi();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "ReservationSystem"));
            }
            app.UseHealthChecks("/hc");
            app.UseHttpsRedirection();

            app.UseCors();

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}
