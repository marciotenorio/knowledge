using System.Reflection;
using DotNetLearning.Configuration;
using DotNetLearning.Database;
using Microsoft.EntityFrameworkCore;
using Microsoft.FeatureManagement;
using Microsoft.FeatureManagement.FeatureFilters;
using Microsoft.OpenApi.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(options =>
{
    options.SwaggerDoc("v1", new OpenApiInfo
    {
        Version = "v1",
        Title = "DotNet Learning",
        Description = "A Web API to learn build .NET APIs"
    });
    
    var xmlFilename = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
    options.IncludeXmlComments(Path.Combine(AppContext.BaseDirectory, xmlFilename));

});
builder.Services.AddDbContext<DotNetLearningContext>(options =>
{
    options.UseSqlite("db");
});

builder.Services.ResolveDepencies();
//read more in https://timdeschryver.dev/blog/feature-flags-in-net-from-simple-to-more-advanced
//default place is "FeatureManagement" in appsettings, but you can customize here
builder.Services.AddFeatureManagement();
    // .AddFeatureFilter<PercentageFilter>()
    // .AddFeatureFilter<TimeWindowFilter>()
    // .AddFeatureFilter<TargetingFilter>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    var devValue = app.Configuration?.GetSection("IsDevelopmentYesOfCourse")?.Get<string>() ?? "Not dev =(";
    System.Console.WriteLine("=== " + devValue + " ===");
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();