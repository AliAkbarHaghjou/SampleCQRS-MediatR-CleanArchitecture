using AutoMapper;
using MediatR;
using SampleCQRS.Application.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SampleCQRS.Application.Features.Products.Queries.GetAllProduct
{

    public class GetAllProductQuery : IRequest<List<GetAllProductResponse>>
    {
        public int id { get; set; }
    }
    public class GetAllProductQueryResponse : IRequestHandler<GetAllProductQuery, List<GetAllProductResponse>>
    {

        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public GetAllProductQueryResponse(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
        public async Task<List<GetAllProductResponse>> Handle(GetAllProductQuery request, CancellationToken cancellationToken)
        {
            var productList = await _unitOfWork.Products.GetAllAsync();
            var mappedProduct = _mapper.Map<List<GetAllProductResponse>>(productList);
            return mappedProduct;
        }
    }
}
