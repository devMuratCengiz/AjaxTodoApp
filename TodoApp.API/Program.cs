using Microsoft.EntityFrameworkCore;
using System.Reflection;
using TodoApp.Business.Abstract;
using TodoApp.Business.Concrete;
using TodoApp.DataAccess.Abstract;
using TodoApp.DataAccess.Concrete;
using TodoApp.DataAccess.Context;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddScoped(typeof(IRepository<>), typeof(GenericRepository<>));
builder.Services.AddScoped(typeof(IGenericService<>), typeof(GenericManager<>));

builder.Services.AddAutoMapper(Assembly.GetExecutingAssembly());

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<SqlDbContext>(optionsAction =>
{
    optionsAction.UseSqlServer(builder.Configuration.GetConnectionString("SqlConnectionString"));
}); 

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
