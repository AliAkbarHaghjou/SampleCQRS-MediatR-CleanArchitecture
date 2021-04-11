using SampleCQRS.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleCQRS.Application.Repositories
{
    public interface IProductRepository : IBaseRepository<Product>
    {
    }
}
