using Core.Interfaces;
using Core.Interfaces.Repositories;
using Core.Interfaces.Services;
using Core.Services;
using Infrastructure.Data;
using Infrastructure.Repositories;
using Microsoft.EntityFrameworkCore;
using Services.Services;
using Microsoft.OpenApi.Models;
using Microsoft.Extensions.Options;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();


builder.Services.AddSwaggerGen(opciones =>
{
    opciones.SwaggerDoc("v1", new OpenApiInfo
    {
        Version = "v1",
        Title = "API Gracosoft .NET Core 2025",
        Description = "Aplicación desarrollada para practicar los temas vistos en clase",
        TermsOfService = new Uri("https://example.com/term"),
        Contact = new OpenApiContact
        {
            Name = "Guillermo Giménez",
            Url = new Uri("https://github.com/G3-Graco/graco-netcore-2025-entregable-2-NetCore2025Entregable2")
        },
        License = new OpenApiLicense
        {
            Name = "Example",
            Url = new Uri("https://example.com/license")
        }

    });


    var xmlFilename = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
    opciones.IncludeXmlComments(Path.Combine(AppContext.BaseDirectory, xmlFilename));

});



builder.Services.AddControllers();

builder.Services.AddScoped(typeof(IUnitOfWork), typeof(UnitOfWork));
builder.Services.AddScoped(typeof(IPersonajeService), typeof(PersonajeService));
builder.Services.AddScoped(typeof(IHabilidadService), typeof(HabilidadService));

builder.Services.AddScoped(typeof(IEquipoService), typeof(EquipoService));
builder.Services.AddScoped(typeof(IMisionService), typeof(MisionService));
builder.Services.AddScoped(typeof(IUbicacionService), typeof(UbicacionService));
builder.Services.AddScoped(typeof(IEnemigoService), typeof(EnemigoService));
builder.Services.AddScoped(typeof(IEquipoService), typeof(EquipoService));

builder.Services.AddScoped(typeof(IPersonajeRepository), typeof(PersonajeRepository));
builder.Services.AddScoped(typeof(IHabilidadRepository), typeof(HabilidadRepository));
builder.Services.AddScoped(typeof(IObjetivoRepository), typeof(ObjetivoRepository));
builder.Services.AddScoped(typeof(IObjetoRepository), typeof(ObjetoRepository));
builder.Services.AddScoped(typeof(IEquipoRepository), typeof(EquipoRepository));
builder.Services.AddScoped(typeof(IEstadisticaRepository), typeof(EstadisticaRepository));
builder.Services.AddScoped(typeof(IMisionRepository), typeof(MisionRepository));
builder.Services.AddScoped(typeof(IPersonajeMisionRepository), typeof(PersonajeMisionRepository));
builder.Services.AddScoped(typeof(IRanuraRepository), typeof(RanuraRepository));
builder.Services.AddScoped(typeof(ITipoEstadisticaRepository), typeof(TipoEstadisticaRepository));
builder.Services.AddScoped(typeof(ITipoObjetoRepository), typeof(TipoObjetoRepository));
builder.Services.AddScoped(typeof(IUbicacionRepository), typeof(UbicacionRepository));

builder.Services.AddScoped(typeof(IBaseRepository<>), typeof(BaseRepository<>));

builder.Services.AddDbContext<AppDbContext>(patata =>
        patata.UseNpgsql("Host=dpg-cvdjlolrie7s739p95i0-a;Server=dpg-cvdjlolrie7s739p95i0-a.oregon-postgres.render.com;Port=5432;Database=netcore2025graco_e6gd;Username=netcore2025graco_e6gd_user;Password=JySaSfBbVSvDX4BZSLhgjJYxOVTCntx8;Include Error Detail=true;",
        b => b.MigrationsAssembly("Infrastructure")));


//builder.Services.AddDbContext<AppDbContext>(options =>
//                    options.UseNpgsql(builder.Configuration.GetConnectionString("DefaultConnection"))
//            );

var app = builder.Build();

app.MapControllers();

// Configure the HTTP request pipeline.
//if (app.Environment.IsDevelopment())
//{
    app.UseSwagger();
    app.UseSwaggerUI();
//}

app.UseHttpsRedirection();



app.Run();

