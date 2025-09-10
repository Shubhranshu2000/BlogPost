using BlogPost.Services.Implementations;
using BlogPost.Services.Interfaces;

namespace BlogPost
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddSingleton<IUserService, UserService>();

            builder.Services.AddControllers();

            builder.Services.AddSwaggerGen();

            var app = builder.Build();

            app.MapControllers();

            app.UseSwagger();
            app.UseSwaggerUI();

            app.MapGet("/", () => "Hello World!");

            app.Run();
        }
    }
}
