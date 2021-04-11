using AutoMapper;
using SampleCQRS.Application.Features.Products.Commands.Create;
using SampleCQRS.Application.Features.Products.Commands.Delete;
using SampleCQRS.Application.Features.Products.Commands.Update;
using SampleCQRS.Application.Features.Products.Queries.GetAllProduct;
using SampleCQRS.Application.Features.Products.Queries.GetProductById;
using SampleCQRS.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleCQRS.Application.Mapping
{
    internal class ProductProfile : Profile
    {
        public ProductProfile()
        {
            CreateMap<CreateProductCommand, Product>().ReverseMap();
            CreateMap<UpdateProductCommand, Product>().ReverseMap();
            CreateMap<DeleteProductCommand, Product>().ReverseMap();
            CreateMap<GetAllProductResponse, Product>().ReverseMap();
            CreateMap<GetProductByIdResponse, Product>().ReverseMap();
        }
    }
}
