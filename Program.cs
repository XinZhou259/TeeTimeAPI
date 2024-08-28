
using Microsoft.EntityFrameworkCore;
using TeeTimeAPI.DbContexts;
using TeeTimeAPI.Services;

namespace TeeTimeAPI
{
    public class Program
    {
        public static void Main(string[] args)
        { 
            var builder = WebApplication.CreateBuilder(args);
            //builder.Logging.ClearProviders();
            //builder.Logging.AddConsole();

            // Add services to the container.
            builder.Services.AddProblemDetails();
            builder.Services.AddControllers().AddNewtonsoftJson().AddXmlDataContractSerializerFormatters();
           
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();
           

            
            builder.Services.AddDbContext<CourseInfoContext>(dbContextOptions 
                => dbContextOptions.UseSqlite(
                    builder.Configuration["ConnectionStrings:CourseInfoDBConnectionString"]));
            builder.Services.AddScoped<ICourseInfoRepository, CourseInfoRepository>();
           
            builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());    

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler();
            }
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}
