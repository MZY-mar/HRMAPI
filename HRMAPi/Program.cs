using HRM.ApplicationCore.Contract.Repository;
using HRM.ApplicationCore.Contract.Service;
using HRM.Infrastructure.Repository;
using HRM.Infrastructure.Service;
using Microsoft.AspNetCore.Diagnostics;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
builder.Host.ConfigureLogging(logging => {
    logging.ClearProviders();
    logging.AddConsole();
});

// Add services to the container.

builder.Services.AddControllers();

builder.Services.AddDbContext<HRM.Infrastructure.Data.HRMDbContext>(option => {

    option.UseSqlServer(builder.Configuration.GetConnectionString("HrmDb"));
});


builder.Services.AddScoped<ICandidateServiceAsync, CandidateServiceAsync>();
builder.Services.AddScoped<ICandidateRepository, CandidateRepository>();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();

app.UseExceptionHandler(options =>{
    options.Run(async context =>{
        context.Response.StatusCode = (int)System.Net.HttpStatusCode.InternalServerError;
        var ex = context.Features.Get<IExceptionHandlerFeature>();
        if(ex != null){
            await context.Response.WriteAsync(ex.Error.Message);
        }
    });
});
}
app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
