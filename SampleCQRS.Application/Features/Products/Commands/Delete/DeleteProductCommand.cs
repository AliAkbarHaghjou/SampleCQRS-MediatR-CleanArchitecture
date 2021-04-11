using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleCQRS.Application.Features.Products.Commands.Delete
{
    public class DeleteProductCommand : IRequest<int>
    {
        public int id { get; set; }
    }
}
