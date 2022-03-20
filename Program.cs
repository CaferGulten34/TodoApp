using TodoApi;
using TodoApi.Helpers;
using TodoApi.Services;
using WebApi.Helpers;

var builder = WebApplication.CreateBuilder(args);
{
    var services=builder.Services;
    services.AddCors();
    services.AddControllers();
    services.Configure<AppSettings>(builder.Configuration.GetSection("AppSettings"));
    services.AddScoped<IUserService,UserService>();
}
// Add services to the container.
builder.Services.AddControllers();

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
        app.UseCors(x => x
        .AllowAnyOrigin()
        .AllowAnyMethod()
        .AllowAnyHeader());
        app.UseMiddleware<JwtMiddleware>();
        app.MapControllers();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();