using EmployeeManagement.Api.Models;
using Microsoft.EntityFrameworkCore;


var builder = WebApplication.CreateBuilder(args);
//Add connectionString
var connectionString = builder.Configuration.GetConnectionString("DBConnection"); //DBConnection is defined in appsettings.json


builder.Services.AddDbContext<AppDbContext>(x => x.UseSqlServer(connectionString));
//Add Swagger Support
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
//Add Repository
//builder.Services.AddScoped<IDepartmentRepository, DepartmentRepository>();
//builder.Services.AddScoped<IEmployeeRepository, EmployeeRepository>();

builder.Services.AddHttpClient<IDepartmentRepository, DepartmentRepository>(client =>
{
    client.BaseAddress = new Uri("https://localhost:7062/");
});
builder.Services.AddHttpClient<IEmployeeRepository, EmployeeRepository>(client =>
{
    client.BaseAddress = new Uri("https://localhost:7062/");
});
// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddAutoMapper(typeof(EmployeeProfile));
var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

app.Run();

