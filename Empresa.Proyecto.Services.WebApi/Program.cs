using AutoMapper;
using Microsoft.AspNetCore.Mvc.ApiExplorer;
using Empresa.Proyecto.Aplicacion.DTO;
using Empresa.Proyecto.Aplicacion.Interface;
using Empresa.Proyecto.Aplicacion.Main;
using Empresa.Proyecto.Domain.Core;
using Empresa.Proyecto.Domain.Entity;
using Empresa.Proyecto.Domain.Interface;
using Empresa.Proyecto.Infraestructura.data;
using Empresa.Proyecto.Infraestructura.Interface;
using Empresa.Proyecto.Infraestructura.Repository;
using Empresa.Proyecto.Transversal.Common;
using Empresa.Proyecto.Transversal.Mapper;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;
using System.Text.Json.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

var builder = WebApplication.CreateBuilder(args);



// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddAuthentication();
builder.Services.AddAutoMapper(x => x.AddProfile(new MappingsProfile()));
builder.Services.AddMvc()
    .AddNewtonsoftJson(options => { options.SerializerSettings.ContractResolver = new Newtonsoft.Json.Serialization.DefaultContractResolver(); }); ;

builder.Services.AddSingleton<IConnectionFactory, ConnectionFactory>();
builder.Services.AddScoped<ICustomersAplication, CustomersAplication>();
builder.Services.AddScoped<ICustomerDomain, CustomersDomain>();
builder.Services.AddScoped<ICustomerRepository, CustomerRepository>();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();
app.UseAuthentication();
app.MapControllers();
app.UseSwagger();
app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "Api Ejemplo"));

app.MapRazorPages();


app.Run();
