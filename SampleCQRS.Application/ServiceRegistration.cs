using Microsoft.Extensions.DependencyInjection;
using SampleCQRS.Application.Features.Products.Commands.Create;
using System.Reflection;
using AutoMapper;
using SampleCQRS.Application.Features.Products.Commands.Update;
using SampleCQRS.Application.Features.Products.Commands.Delete;
using SampleCQRS.Application.Features.Products.Queries.GetAllProduct;
using System.Collections.Generic;
using SampleCQRS.Application.Features.Products.Queries.GetProductById;
using MediatR;

namespace SampleCQRS.Application
{
    public static class ServiceRegistration
    {
        public static void AddApplicationInfrastructure(this IServiceCollection services)
        {
            services.AddAutoMapper(Assembly.GetExecutingAssembly());
            services.AddScoped(typeof(ServiceProvider), x => services.BuildServiceProvider());
            services.AddMediatR(Assembly.GetExecutingAssembly());
        }
    }
}
