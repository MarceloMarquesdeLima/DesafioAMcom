using DesafioAMcom.Application.Interfaces;
using DesafioAMcom.Application.Services;
using DesafioAMcom.Infrastructure;
using Microsoft.OpenApi;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo { Title = "AMcom API", Version = "v1" });
});

// Add services to the container.

builder.Services.AddMemoryCache();
builder.Services.AddHttpClient<HttpUsersRepository>()
    .AddTransientHttpErrorPolicy(p => p.WaitAndRetryAsync(3, _ => TimeSpan.FromSeconds(2)));

builder.Services.AddScoped<JsonCountryRepository>();
builder.Services.AddScoped<CacheTemperatureRepository>();
builder.Services.AddScoped<HttpUsersRepository>();

builder.Services.AddScoped<ICountryService, CountryService>();
builder.Services.AddScoped<ITemperatureService, TemperatureService>();
builder.Services.AddScoped<IUsersService, UsersService>();

builder.Services.AddControllers();
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
    app.MapOpenApi();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
