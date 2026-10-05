
namespace Campus02Demo
{
    public class Program
    {
        public static void Main(string[] args)
        {

            //dotnet new webapi -n Campus02Demo
            //Controller: //BackAccountController
            //HttpPost["Geldeinzahlen"]
            //HttpPost["Geldabheben"]   
            //Deposit(200), Withdraw(300), GetBalance();
            //static double balance = 0;

            //dotnet add package Swashbuckle.AspNetCore.SwaggerUI
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();
            // Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
            builder.Services.AddOpenApi();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.MapOpenApi();

                app.UseSwaggerUI(options =>
                {
                    options.SwaggerEndpoint(
                        "/openapi/v1.json",
                        "Campus02Demo API v1");
                });
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}
