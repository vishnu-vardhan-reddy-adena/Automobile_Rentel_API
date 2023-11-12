using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json.Serialization;
using WebApplication16.Models;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;
using Microsoft.AspNetCore.Builder;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers().AddNewtonsoftJson(options => { options.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore; options.SerializerSettings.ContractResolver =
                                                     new DefaultContractResolver();
});
builder.Services.AddDbContext<CarDbContext>(item => item.UseSqlServer(builder.Configuration.GetConnectionString("DBConnection")));
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowReactApp",
    builder =>
    {
        builder.WithOrigins("http://localhost:3000").AllowAnyHeader()
        .AllowAnyMethod().AllowCredentials();
    }
    );
}
);
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{app.UseDeveloperExceptionPage();
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();
 app.UseCors("AllowReactApp");
app.MapControllers();

app.Run();
