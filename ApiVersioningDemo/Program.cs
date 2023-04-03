var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddApiVersioning(option =>
{
    //Set default api versioning configuration
    option.AssumeDefaultVersionWhenUnspecified = true;
    option.DefaultApiVersion = new Microsoft.AspNetCore.Mvc.ApiVersion(2, 0);
});
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseApiVersioning();
app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();

