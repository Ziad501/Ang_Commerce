using eStoreApi.Data;
using Microsoft.EntityFrameworkCore;
using System.Text.Json.Serialization;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers()
    .AddJsonOptions(options =>
    {
        options.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles;
    });


builder.WebHost.ConfigureKestrel(serverOptions =>
{
    serverOptions.ListenAnyIP(7014, listenOptions => listenOptions.UseHttps());
});


builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAngularApp",
        policy => policy.WithOrigins("http://localhost:4200") 
                        .AllowAnyMethod()
                        .AllowAnyHeader());
});



builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"))
);

var app = builder.Build();

// Configure middleware
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
<<<<<<< HEAD
=======
app.UseExceptionHandler("/error");
>>>>>>> 7e958f3e18f1c79c194329ac778d43bc437a68b7
app.UseHttpsRedirection();
app.UseCors("AllowAngularApp");
app.UseAuthorization();
app.MapControllers();

<<<<<<< HEAD
// Test endpoint for fetching all products
=======
>>>>>>> 7e958f3e18f1c79c194329ac778d43bc437a68b7

app.Run();
