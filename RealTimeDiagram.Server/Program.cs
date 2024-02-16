using RealTimeDiagram.Server.HubConfig;
using RealTimeDiagram.Server.TimerFeatures;

namespace RealTimeDiagram.Server
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddCors(options =>
            {
                options.AddPolicy("CorsPolicy", builder => builder
                    .WithOrigins("http://localhost:4200")
                    .AllowAnyMethod()
                    .AllowAnyHeader()
                    .AllowCredentials());
            });
            builder.Services.AddSignalR();
            builder.Services.AddSingleton<TimerManager>();

            builder.Services.AddControllers();

            var app = builder.Build();

            app.UseHttpsRedirection();
            app.UseCors("CorsPolicy");
            app.UseAuthorization();
            app.MapHub<DiagramHub>("/diagram");
            app.MapControllers();

            app.Run();
        }
    }
}
