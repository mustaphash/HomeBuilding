using Core.Entity;
using Core.Queries;
using DAL;
using DAL.Queries.GetAllBrigades;
using DAL.Queries.GetAllBuildings;
using DAL.Queries.GetAllEmployees;
using DAL.Queries.GetAllMaterials;
using DAL.Queries.GetAllPlaces;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<BuildingContext>(x => x.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnectionStrings")));

builder.Services.AddScoped<IQueryHandler<GetAllBrigadesQuery, IList<Brigade>>, GetAllBrigadesQueryHandler>();
builder.Services.AddScoped<IQueryHandler<GetAllBuildingsQuery, IList<Building>>, GetAllBuildingsQueryHandler>();
builder.Services.AddScoped<IQueryHandler<GetAllEmployeesQuery, IList<Employee>>, GetAllEmployeesQueryHandler>();
builder.Services.AddScoped<IQueryHandler<GetAllMaterialsQuery, IList<Material>>, GetAllMaterialsQueryHandler>();
builder.Services.AddScoped<IQueryHandler<GetAllPlacesQuery, IList<Place>>, GetAllPlacesQueryHandler>();

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
