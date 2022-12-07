using AutoMapper;
using AvaliacaoB3.Aplicacao.ViewModels;
using AvaliacaoB3.Dominio.Dto;
using AvaliacaoB3.Dominio.Entidades;
using AvaliacaoB3.Dominio.Interfaces.Servicos;
using AvaliacaoB3.Dominio.Servicos;
using AvaliacaoB3.ViewModels;
using Newtonsoft.Json;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllers().AddNewtonsoftJson(x => x.SerializerSettings.ReferenceLoopHandling = ReferenceLoopHandling.Ignore);
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddScoped<ICdbServico, CdbServico>();

builder.Services.AddSingleton(new MapperConfiguration(config =>
{
    config.CreateMap<CdbRequestViewModel, CdbRequestDto>();
    config.CreateMap<Cdb, CdbResponseViewModel>();
}).CreateMapper());

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
