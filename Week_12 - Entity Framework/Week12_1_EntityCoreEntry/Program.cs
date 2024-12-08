using Microsoft.EntityFrameworkCore;
using Week12_1_EntityCoreEntry.Data;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddDbContext<LibraryContext>(options =>
{
    // Connection string configured
    options.UseSqlServer(builder.Configuration.GetConnectionString("Default"), sqlServerOptionsAction: sqlOptions =>
    {
        // Try to reconnect if connection fails
        sqlOptions.EnableRetryOnFailure(maxRetryCount: 5, maxRetryDelay: TimeSpan.FromSeconds(2), errorNumbersToAdd: null);

    // Disable tracking behavior for improved performance
    }).UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking);
});


builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();

app.MapControllers();

app.Run();
