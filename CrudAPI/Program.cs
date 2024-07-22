using CrudApi.Dados.Context;
using CrudApi.Dados.Repositorio;
using CrudApi.RegraNegocio.Interfaces;
using Microsoft.Build.Framework;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

var builder = WebApplication.CreateBuilder(args);

string connString = builder.Configuration.GetConnectionString("AzureDatabase");

builder.Services.AddDbContext<ContextDB>(options =>
{
    options.UseSqlServer(connString);
});

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//Injeção de Dependências
builder.Services.AddScoped<ContextDB>();
builder.Services.AddScoped<IContaRepositorio, ContaRepositorio>();
builder.Services.AddScoped<IMovimentoContaRepositorio, MovimentoContaRepositorio>();
builder.Services.AddScoped<IPagamentoContaRepositorio, PagamentoContaRepositorio>();

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
