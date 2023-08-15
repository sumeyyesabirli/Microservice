using CasgemMicroservice.Services.Cargo.DataAccesLayer.Abstract;
using CasgemMicroservice.Services.Cargo.DataAccesLayer.Context;
using CasgemMicroservice.Services.Cargo.DataAccesLayer.EntityFramework;
using CasgemMicroServices.Services.Cargo.BussinessLayer.Abstract;
using CasgemMicroServices.Services.Cargo.BussinessLayer.Concrete;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.Authorization;
using System.IdentityModel.Tokens.Jwt;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
var requireAuthorizePolicy = new AuthorizationPolicyBuilder().RequireAuthenticatedUser().Build();
JwtSecurityTokenHandler.DefaultInboundClaimTypeMap.Remove("sub");
builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme).AddJwtBearer(opt =>
{

    opt.Authority = builder.Configuration["IdentityServerUrl"];
    opt.Audience = "resource_cargo";
    opt.RequireHttpsMetadata = false;
});

builder.Services.AddControllers(opt =>
{
    opt.Filters.Add(new AuthorizeFilter(requireAuthorizePolicy));

});
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<CargoContext>();
builder.Services.AddScoped<ICargoDetailService,CargoDetailManager>();
builder.Services.AddScoped<ICargoDetailDal,EfCargoDetailDal>();
builder.Services.AddScoped<ICargoStateService, CargoStateManager>();
builder.Services.AddScoped<ICargoStateDal,EfCargoStateDal>();
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();

app.Run();
