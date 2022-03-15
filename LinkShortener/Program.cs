using LinkShortener.Options;
using Microsoft.OpenApi.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddMvcCore();

builder.Services.AddSwaggerGen(options =>
{
    options.SwaggerDoc("v1", new OpenApiInfo
    {
        Title = "Link Shortener",
        Version = "v1",
    });
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
} 
else
{
    app.UseHsts();
}

var swaggerOptions = new SwaggerOptions();
app.Configuration.GetSection(nameof(SwaggerOptions)).Bind(swaggerOptions);

app.UseSwagger(options =>
{
    options.RouteTemplate = swaggerOptions.JsonRoute;
});

app.UseSwaggerUI(options =>
{
    options.SwaggerEndpoint(swaggerOptions.UIEndpoint, swaggerOptions.Description);
});

app.UseHttpsRedirection();
app.UseStaticFiles();

app.MapControllers();

app.Run();
